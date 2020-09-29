# Investigating regressions reported in the [dotnet/runtime](https://github.com/dotnet/runtime) repository

## Table of Contents

- [Introduction](#Introduction)
- [Repro](#Repro)
- [Disassembly](#Disassembly)
  - [DisassemblyDiagnoser](#DisassemblyDiagnoser)
  - [JitDump](#JitDump)
    - [InProcessToolchain](#InProcessToolchain)
    - [CoreRunToolchain](#CoreRunToolchain)
  - [Analysis](#Analysis)
    - [The managed implementation was changed and the produced assembly code has changed as well](#The-managed-implementation-was-changed-and-the-produced-assembly-code-has-changed-as-well)
    - [The managed implementation was not changed, but the produced assembly code has changed](#The-managed-implementation-was-not-changed-but-the-produced-assembly-code-has-changed)
    - [The generated assembly code has not changed, but the performance has regressed](#The-generated-assembly-code-has-not-changed-but-the-performance-has-regressed)
        - [Memory Alignment](#Memory-Alignment)
        - [Code Alignment](#Code-Alignment)
- [Profiling](#Profiling)
  - [Visual Studio Profiler](#Visual-Studio-Profiler)
- [Workshop](#Workshop)
  - [Historical Data](#Historical-Data)
  - [Disassembly](#Disassembly)
  - [Profilers](#Profilers)

# Introduction

**This doc explains how to investigate regressions reported in the [dotnet/runtime](https://github.com/dotnet/runtime) repository and it's targetted at [dotnet/runtime](https://github.com/dotnet/runtime) repository contributors.**

Before you start any performance investigation, you need to open the issue with regression report, click on the link that leads to the full historical data, and evaluate the data.

In most of the cases, it's obvious that there is a regression (see the [example](https://github.com/DrewScoggins/performance-2/issues/910) below) and you just continue to the [next step](#Repro).

![Ovious regression](img/regressions_obvious.png)


But some benchmarks are multimodal (bimodal in the examples below [1](https://github.com/DrewScoggins/performance-2/issues/1683), [2](https://github.com/DrewScoggins/performance-2/issues/1379), [3](https://github.com/DrewScoggins/performance-2/issues/1378)) and there is no regression:

![Bimodal benchmark, no actual regression](img/regressions_bimodal.png)

![Bimodal benchmark, no actual regression](img/regressions_bimodal_2.png)

![Bimodal benchmark, no actual regression](img/regressions_bimodal_3.png)

**If the historical data shows that there is no regression, you can just close the issue and provide a comment with an explanation**.
The more mature the system becomes, the less frequent false positives should be.

Some benchmarks can be unstable like in [this example](https://github.com/DrewScoggins/performance-2/issues/759):

![Unstable](img/regressions_unstable.png)

If the benchmark is unstable and it measures something from an area that you [own](https://github.com/dotnet/runtime/blob/master/docs/area-owners.md), you should investigate why it's unstable and most probably rewrite it.

**You own the area, you own it's benchmarks ;)**

Last but not least, it might not be clear whether there is a regression or not, like in the following [example](https://github.com/DrewScoggins/performance-2/issues/1253):

![Not sure](img/regressions_notsure.png)

Is such cases, you should estimate how important could be such a regression and decide whether you want to investigate it or not. You should always focus on the obvious regressions first, as they are very often caused by a problem that affects many other benchmarks. Fixing one big regression might simply solve a few other reported issues at once.

# Repro

The next step is to reproduce the regression locally. The most convenient way to do it is by using the [benchmarks_ci.py](../scripts/benchmarks_ci.py)
 script with the arguments provided in the reported issue.
 
 
```cmd
git clone https://github.com/dotnet/performance.git
# For Windows
py .\performance\scripts\benchmarks_ci.py -f netcoreappX netcoreappY --filter '$yourFilter*'
# For Unix systems
python3 ./performance/scripts/benchmarks_ci.py -f netcoreappX netcoreappY --filter '$yourFilter*'
```

The script downloads the latest .NET SDK for given framework moniker(s) and runs the benchmark(s) that match the provided filter. You can read more about filtering [here](benchmarkdotnet.md#Filtering-the-Benchmarks).

Few important things:

* [python 3.5](prerequisites.md) or newer needs to be installed and added to `PATH`.
* The script ignores the current environment variables and starts the process with no environment variables.
* By default, the `x64` architecture is used. If the issue mentions a different architecture, you need to provide it in an explicit way via `--architecture arm64|arm|x86`.
* On Unix systems, you need to:
  * use python**3** in an explicit way. Otherwise, you might get a very vague syntax error from python **2**.
  * escape the asterisks provided to the filter `'*'`. If you don't, the OS is going to replace `*` with the names of files in your current folder and you won't run any benchmarks.

If you can't reproduce the problem locally, you need to double-check that you are using the exact same architecture and OS.

If you've ensured that you are using the right config and you still can't repo the problem, you should diff the disassembly. If there is no difference, you can close the issue. Please don't forget to include the exported disassembly. 

# Disassembly

Using the disassembly can be very useful for nano-benchmarks (time reported by BenchmarkDotNet is less than one microsecond). But before we take a look at some assembly code, let's find out how to get the disassembly first.

## DisassemblyDiagnoser

BenchmarkDotNet has a built-in disassembler called [DisassemblyDiagnoser](https://adamsitnik.com/Disassembly-Diagnoser/). You can read more about it [here](benchmarkdotnet.md#Disassembly).

It supports Windows (both `x64` and `x86`) and Linux `x64`. ARM64 and ARM are not supported ([yet](https://github.com/dotnet/BenchmarkDotNet/issues/1422#issuecomment-691036956)). Internally it uses [ClrMD](https://github.com/Microsoft/clrmd) to get a byte representation of the disassembly (`byte[]`) and [Iced](https://github.com/0xd4d/iced) to turn it into a human-readable text (`string`). It disassembles the code after the benchmarks are executed, so it does not add any overhead to the reported results.

To get the disassembly, you need to pass `--disasm` or just `-d` to `dotnet cli`.

This particular disassembler is recursive, and you can control the depth via `--disasmDepth` argument. By default it's set to `1` so it disassembles just the benchmark and methods called by the benchmark directly.

**Important:** The [benchmarks_ci.py](../scripts/benchmarks_ci.py) script exposes some BDN arguments, but not all of them. Those which are not exposed by the python script needs to be passed via `--bdn-arguments` argument as **pairs of strings**.

Example:

```cmd
benchmarks_ci.py --bdn-arguments "--disasm true --disasmDepth 3"
```

**Note:** By default, the `DisassemblyDiagnoser` does not show the **addresses of the instructions**. It's possible to enable it, but only from the [code level](../src/harness/BenchmarkDotNet.Extensions/RecommendedConfig.cs):

```cs
.AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(printInstructionAddresses: true)))
```

## JitDump

JitDump is the most powerfull .NET Core disassembler. It's also the only disassembler that supports all architectures and indirect method calls. It has an [excellent documentation](https://github.com/dotnet/runtime/blob/master/docs/design/coreclr/jit/viewing-jit-dumps.md) that describes how to use it when working with **standalone** .NET applications.

There are two ways of using it with BenchmarkDotNet.

### CoreRunToolchain

When working with local builds of .NET Core it's [recommended](benchmarking-workflow-dotnet-runtime.md) to use [CoreRun](benchmarkdotnet.md#CoreRun) to run the benchmarks against a local build of .NET Core.

To combine the powers of `JitDump`, `CoreRun` and `BenchmarkDotNet` you need to copy a `checked` version of `clrjit.dll` into `Release` TestHost folder (**Checked -> Release**, kudos to @kunalspathak for the idea!):

```cmd
copy /y ".\runtime\artifacts\bin\coreclr\Windows_NT.x64.Checked\clrjit.dll" \\
 ".\runtime\artifacts\bin\testhost\net5.0-Windows_NT-Release-x64\shared\Microsoft.NETCore.App\6.0.0\"
```

**Note:** You might need to do it every time after you rebuild the product (the checked version of `clrjit.dll` is going to get replaced with release version).

And then tell BenchmarkDotNet to use it to run the benchmarks with appropriate environment variables:

```cmd
py .\performance\scripts\benchmarks_ci.py -f netcoreapp5.0 \\
--corerun .\runtime\artifacts\bin\testhost\net5.0-Windows_NT-Release-x64\shared\Microsoft.NETCore.App\6.0.0\CoreRun.exe 
--bdn-arguments "--envVars COMPlus_JitDump:$value"
--filter $yourFilter
--dotnet-compilation-mode NoTiering
```

**Important:** to disable Tiered JIT (otherwise you get Tier **0** code) you need to pass `--dotnet-compilation-mode NoTiering` to the python script (or `--envVars  COMPlus_TieredCompilation:0`).

**Note:** The filter accepted by `COMPlus_JitDump` uses `:` (colon) to separate type and method names. The filter accepted by BDN uses dots (only).

```cmd
--filter Burgers.Test0
--envVars COMPlus_JitDump:Burgers:Test0
```

### InProcessToolchain

By default BenchmarkDotNet runs every benchmark in a standalone process. But it's possible to run the benchmarks in the same process. As long as they don't have any side-effects (allocating memory, creating threads etc) it *should be fine*.

* follow the steps described [here](https://github.com/dotnet/runtime/blob/master/docs/design/coreclr/jit/viewing-jit-dumps.md#setting-up-our-environment) for [MicroBenchmarks.csproj](../src/benchmarks/micro/MicroBenchmarks.csproj) project
* the [src/benchmarks/micro](../src/benchmarks/micro/) folder contains a solution file and a project file named `MicroBenchmarks`. To publish a self-contained version of the project you need to specify the **path to project file** in explicit way. If you don't, it's going to try to publish all projects from the [solution file](../src/benchmarks/micro/MicroBenchmarks.sln) and fail!

```cmd
# make sure that the local copy of dotnet is used (not the default version from your PATH)
set DOTNET_MULTILEVEL_LOOKUP=0
# publish a self-contained version in Release using dotnet downloaded by the python script
.\performance\tools\dotnet\x64\dotnet.exe publish .\performance\src\benchmarks\micro\MicroBenchmarks.csproj \\
 -c Release -f netcoreapp5.0 --self-contained -r win-x64
# copy the files
robocopy /e .\runtime\artifacts\bin\coreclr\Windows_NT.x64.Release .\performance\artifacts\bin\MicroBenchmarks\Release\netcoreapp5.0\win-x64\publish
# copy a checked version of "clrjit.dll" (the most important file)
copy /y .\runtime\artifacts\bin\coreclr\Windows_NT.x64.Checked\clrjit.dll .\performance\artifacts\bin\MicroBenchmarks\Release\netcoreapp5.0\win-x64\publish\
```

* and when running a self-contained version of `MicroBenchmarks` app force BenchmarkDotNet to use the [InProcessToolchain](https://benchmarkdotnet.org/articles/configs/toolchains.html#sample-introinprocess) by passing `--inProcess` or just `-i`.

```cmd
# set the COMPlus_JitDump env var to filter the disasm
set COMPlus_JitDump=namespace.typeName:methoName

.\performance\artifacts\bin\MicroBenchmarks\Release\netcoreapp5.0\win-x64\publish\MicroBenchmarks.exe \\ 
 --inProcess \\
 --filter namespace.typeName.methodName
```


## Analysis

Analyzing the assembly code is a non-trivial skill and the goal of this doc is definitely not to try to teach you that. There are some common recurring patterns and we are going to focus only on these.

### The managed implementation was changed and the produced assembly code has changed as well

If the C# source code became:

* more complex to solve a different problem (like added a few `if` statements to fix a bug):
  * if it's an important code path you should optimize it or ask for help if you don't know how to do it (**it's perfectly fine to not know all C# perf tricks!!**).
  * if it can not be optimized or it's not worth it, you should close the issue and explain why it's a by-design regression.
* simpler, but the produced assembly code has gotten worse you should label the issue as `area-CodeGen-coreclr` and tag @dotnet/jit-contrib to get help. Depending on the complexity of the problem and the judgment of the JIT Team the issue might get fixed on the JIT side or given change might be simply reverted.

### The managed implementation was **not** changed, but the produced assembly code has changed

It's most probably caused by changes in the JIT. You should label the issue as `area-CodeGen-coreclr` and tag @dotnet/jit-contrib to get help.

An [example](https://github.com/dotnet/runtime/issues/41738) of such issue where `System.Numerics.Quaternion.Conjugate(System.Numerics.Quaternion)` stopped being inlined:

<table>
<tr>
<th>
.NET Core 3.1.6
</th>
<th>
.NET Core 5.0.20.41714
</th>
</tr>
<tr>
<td style="vertical-align: top">
<pre>
; System.Numerics.Tests.Perf_Quaternion.ConjugateBenchmark()
       sub       rsp,18
       vzeroupper
       lea       rax,[rsp+8]
       vxorps    xmm0,xmm0,xmm0
       vmovss    dword ptr [rax],xmm0
       vmovss    dword ptr [rax+4],xmm0
       vmovss    dword ptr [rax+8],xmm0
       vmovss    xmm0,dword ptr [7FFF277E5718]
       vmovss    dword ptr [rax+0C],xmm0
       lea       rax,[rsp+8]
       vmovss    xmm0,dword ptr [rax]
       vmovss    xmm1,dword ptr [rax+4]
       vmovss    xmm2,dword ptr [rax+8]
       vmovss    xmm3,dword ptr [rax+0C]
       vmovss    xmm4,dword ptr [7FFF277E571C]
       vxorps    xmm0,xmm0,xmm4
       vmovss    xmm4,dword ptr [7FFF277E571C]
       vxorps    xmm1,xmm1,xmm4
       vmovss    xmm4,dword ptr [7FFF277E571C]
       vxorps    xmm2,xmm2,xmm4
       vmovss    dword ptr [rdx],xmm0
       vmovss    dword ptr [rdx+4],xmm1
       vmovss    dword ptr [rdx+8],xmm2
       vmovss    dword ptr [rdx+0C],xmm3
       mov       rax,rdx
       add       rsp,18
       ret
; Total bytes of code 130
</pre>
</td>
<td style="vertical-align: top">
<pre>
; System.Numerics.Tests.Perf_Quaternion.ConjugateBenchmark()
       push      rsi
       sub       rsp,40
       vzeroupper
       mov       rsi,rdx
       lea       rcx,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm0
       vmovss    dword ptr [rcx+8],xmm0
       vmovss    xmm0,dword ptr [7FFF3AEB4610]
       vmovss    dword ptr [rcx+0C],xmm0
       mov       rcx,rsi
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+20],xmm0
       lea       rdx,[rsp+20]
       call      System.Numerics.Quaternion.Conjugate(System.Numerics.Quaternion)
       mov       rax,rsi
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 81
</pre>
<pre>
; System.Numerics.Quaternion.Conjugate(System.Numerics.Quaternion)
       vzeroupper
       vmovss    xmm0,dword ptr [rdx]
       vmovss    xmm1,dword ptr [7FFF3AEB46E0]
       vxorps    xmm0,xmm0,xmm1
       vmovss    xmm1,dword ptr [rdx+4]
       vmovss    xmm2,dword ptr [7FFF3AEB46E0]
       vxorps    xmm1,xmm1,xmm2
       vmovss    xmm2,dword ptr [rdx+8]
       vmovss    xmm3,dword ptr [7FFF3AEB46E0]
       vxorps    xmm2,xmm2,xmm3
       vmovss    xmm3,dword ptr [rdx+0C]
       vmovss    dword ptr [rcx],xmm0
       vmovss    dword ptr [rcx+4],xmm1
       vmovss    dword ptr [rcx+8],xmm2
       vmovss    dword ptr [rcx+0C],xmm3
       mov       rax,rcx
       ret
; Total bytes of code 81
</pre>
</td>
</tr>
</table>

### The generated assembly code has not changed, but the performance has regressed

This is possible and happens more frequently than we would like to ;) It's typically caused by the alignment changes.

#### Memory Alignment

If given benchmark is using arrays (or any other continious segments of memory) and they are being iterated over and over it's likely that you are facing a memory alignment issue.

In https://github.com/dotnet/runtime/issues/37814 @jkotas has [provided](https://github.com/dotnet/runtime/issues/37814#issuecomment-667804880) a small repro that shows *"the many modal nature of memory copying"*:

```cs
using System;
using System.Diagnostics;

class Program
{
    static void Work(ReadOnlySpan<string> from, Span<string> to)
    {
        for (int i = 0; i < 1000000; i++) from.CopyTo(to);
    }

    static void Main(string[] args)
    {
        Random r = new Random();
        for (;;)
        {
            var sw = new Stopwatch();
            GC.KeepAlive(new byte[r.Next(32)]); // the trick
            var from = new string[2048];
            GC.KeepAlive(new byte[r.Next(32)]);
            var to = new string[2048];
            if (r.Next(10) == 0) GC.Collect();
            sw.Start();
            Work(from, to);       
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
```

In this particular example using my machine I am getting values oscilating between ~430 and ~630 ms.

The best thing you can do is to **make sure that the produced assembly code has not changed and just close the issue**. If you want to be 100% sure you can handcraft a modified version of the benchmark that allocates an aligned array, pins it and reuses for all benchmarking iterations. If you want to go deeper than that, you need to use a specialized profiler like [VTune](profiling-workflow-dotnet-runtime.md#VTune) or [uProf](profiling-workflow-dotnet-runtime.md#uProf).

<details>

```cs
private static T[] AllocateAlignedArray<T>(int size, out GCHandle pinnedArrayHandle)
{
    Random r = new Random();

    while (true)
    {
        T[] result = new T[size];
        pinnedArrayHandle = GCHandle.Alloc(result, GCHandleType.Pinned);

        if ((long)pinnedArrayHandle.AddrOfPinnedObject() % 32 == 0)
        {
            return result;
        }
        else
        {
            pinnedArrayHandle.Free();
        }

        GC.KeepAlive(new byte[r.Next(32)]);
    }
}
```

</details>


#### Code Alignment

If the assembly code is identical but performs worse it might be caused by code alignment changes. If the produced code size is small, you can just enforce the disassembler to print instruction addresses and check if the hot path alignment has changed.


Typically the most important is the alignment of the first instruction of the loop (where the code jumps after every iteration). You can use an experimental JIT feature that aligns the loops to verify that. It's configurable with the environment variable called `COMPlus_JitAlignLoops`.

```cmd
dotnet run --envVars COMPlus_JitAlignLoops:1
# or via the python script
benchmarks_ci.py --bdn-arguments "--envVars COMPlus_JitAlignLoops:1"
```

An [example](https://github.com/dotnet/runtime/issues/39721) that shows how loop alignment changes *"regressed"* `Span<Byte>.BinarySearch`:

```cs
.AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(printInstructionAddresses: true)))
```

```cmd
py .\performance\scripts\benchmarks_ci.py -f netcoreapp5.0 --filter 'System.Memory.Span<Byte>.BinarySearch' --bdn-arguments "--envVars COMPlus_JitAlignLoops:0"
```


|       Method | Size |     Mean |    Error |   StdDev |   Median |      Min |      Max | Code Size |
|------------- |----- |---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| BinarySearch |  512 | 17.55 ns | 0.313 ns | 0.278 ns | 17.56 ns | 17.23 ns | 18.13 ns |     113 B |

```cmd
py .\performance\scripts\benchmarks_ci.py -f netcoreapp5.0 --filter 'System.Memory.Span<Byte>.BinarySearch' --bdn-arguments "--envVars COMPlus_JitAlignLoops:1"
```

|       Method | Size |     Mean |    Error |   StdDev |   Median |      Min |      Max | Code Size |
|------------- |----- |---------:|---------:|---------:|---------:|---------:|---------:|----------:|
| BinarySearch |  512 | 11.80 ns | 0.172 ns | 0.153 ns | 11.77 ns | 11.61 ns | 12.12 ns |     116 B |

<table>
<tr>
<th>
Loop not aligned
</th>
<th>
Loop aligned
</th>
</tr>
<tr>
<td style="vertical-align: top">
<pre>
; BinarySearch()
       7FFB797C58B0 sub       rsp,28
       7FFB797C58B4 mov       rdx,[rcx+18]
       7FFB797C58B8 test      rdx,rdx
       7FFB797C58BB jne       short M00_L00
       7FFB797C58BD xor       r8d,r8d
       7FFB797C58C0 xor       edx,edx
       7FFB797C58C2 jmp       short M00_L01
M00_L00:
       7FFB797C58C4 lea       r8,[rdx+10]
       7FFB797C58C8 mov       edx,[rdx+8]
M00_L01:
       7FFB797C58CB movzx     eax,byte ptr [rcx+2C]
       7FFB797C58CF mov       rcx,r8
       7FFB797C58D2 mov       r8d,eax
       7FFB797C58D5 call      BinarySearch(Byte ByRef, Int32, Byte)
       7FFB797C58DA nop
       7FFB797C58DB add       rsp,28
       7FFB797C58DF ret
; Total bytes of code 48
</pre>
<pre>
; BinarySearch(Byte ByRef, Int32, Byte)
       7FFB797C5980 mov       [rsp+18],r8d
       7FFB797C5985 xor       eax,eax
       7FFB797C5987 dec       edx
       7FFB797C5989 test      edx,edx
       7FFB797C598B jl        short M01_L03
M01_L00:
       7FFB797C598D lea       r8d,[rdx+rax]
       7FFB797C5991 shr       r8d,1
       7FFB797C5994 movsxd    r9,r8d
       7FFB797C5997 movzx     r9d,byte ptr [rcx+r9]
       7FFB797C599C movzx     r10d,byte ptr [rsp+18]
       7FFB797C59A2 sub       r10d,r9d
       7FFB797C59A5 je        short M01_L04
       7FFB797C59A7 test      r10d,r10d
       7FFB797C59AA jle       short M01_L01
       7FFB797C59AC lea       eax,[r8+1]
       7FFB797C59B0 jmp       short M01_L02
M01_L01:
       7FFB797C59B2 lea       edx,[r8+0FFFF]
M01_L02:
       7FFB797C59B6 cmp       eax,edx
       7FFB797C59B8 jle       short M01_L00
M01_L03:
       7FFB797C59BA not       eax
       7FFB797C59BC ret
M01_L04:
       7FFB797C59BD mov       eax,r8d
       7FFB797C59C0 ret
; Total bytes of code 65
</pre>
</td>
<td style="vertical-align: top">
<pre>
; BinarySearch()
       7FFB797D5930 sub       rsp,28
       7FFB797D5934 mov       rdx,[rcx+18]
       7FFB797D5938 test      rdx,rdx
       7FFB797D593B jne       short M00_L00
       7FFB797D593D xor       r8d,r8d
       7FFB797D5940 xor       edx,edx
       7FFB797D5942 jmp       short M00_L01
M00_L00:
       7FFB797D5944 lea       r8,[rdx+10]
       7FFB797D5948 mov       edx,[rdx+8]
M00_L01:
       7FFB797D594B movzx     eax,byte ptr [rcx+2C]
       7FFB797D594F mov       rcx,r8
       7FFB797D5952 mov       r8d,eax
       7FFB797D5955 call      BinarySearch(Byte ByRef, Int32, Byte)
       7FFB797D595A nop
       7FFB797D595B add       rsp,28
       7FFB797D595F ret
; Total bytes of code 48
</pre>
<pre>
; BinarySearch(Byte ByRef, Int32, Byte)
       7FFB797D5A00 mov       [rsp+18],r8d
       7FFB797D5A05 xor       eax,eax
       7FFB797D5A07 dec       edx
       7FFB797D5A09 test      edx,edx
       7FFB797D5A0B jl        short M01_L03
       7FFB797D5A0D nop       dword ptr [rax] // the aligning NOP!!
M01_L00:
       7FFB797D5A10 lea       r8d,[rdx+rax]
       7FFB797D5A14 shr       r8d,1
       7FFB797D5A17 movsxd    r9,r8d
       7FFB797D5A1A movzx     r9d,byte ptr [rcx+r9]
       7FFB797D5A1F movzx     r10d,byte ptr [rsp+18]
       7FFB797D5A25 sub       r10d,r9d
       7FFB797D5A28 je        short M01_L04
       7FFB797D5A2A test      r10d,r10d
       7FFB797D5A2D jle       short M01_L01
       7FFB797D5A2F lea       eax,[r8+1]
       7FFB797D5A33 jmp       short M01_L02
M01_L01:
       7FFB797D5A35 lea       edx,[r8+0FFFF]
M01_L02:
       7FFB797D5A39 cmp       eax,edx
       7FFB797D5A3B jle       short M01_L00
M01_L03:
       7FFB797D5A3D not       eax
       7FFB797D5A3F ret
M01_L04:
       7FFB797D5A40 mov       eax,r8d
       7FFB797D5A43 ret
; Total bytes of code 68
</pre>
</td>
</tr>
</table>

Again, you should just close the issue and provide the disassembly with an explanation.

# Profiling

If the benchmark that has regressed is not a nano-benchmark, you should use a profiler to find out what exactly has regressed. This is explained in the [Profiling workflow for dotnet/runtime repository](profiling-workflow-dotnet-runtime.md) doc. Below you can find a quick recap.

You need to:

1. Create a small [Repro](profiling-workflow-dotnet-runtime.md#Repro) app.
2. Set the recommended [Project Settings](profiling-workflow-dotnet-runtime.md#Project-Settings).
3. Use [PerfView](profiling-workflow-dotnet-runtime.md#Perfview) (for Windows) or [PerfCollect](profiling-workflow-dotnet-runtime.md#PerfCollect) (for Linux) to profile the repro app and capture two trace files: one using an older version of .NET without the regression and one using a newer version with the regression.
4. Use PerfView to open both trace files (it supports PerfCollect trace files as well) and [filter](profiling-workflow-dotnet-runtime.md#Filtering) the trace files in an exact same way to allow for an apples-to-apples comparison.
5. Use PerfView's [built-in support for identifying regressions](profiling-workflow-dotnet-runtime.md#Identifying-Regressions).

## Visual Studio Profiler

In case the entire CPU time is spent in a single big method, you should use [Visual Studio Profiler](profiling-workflow-dotnet-runtime.md#Visual-Studio-Profiler) to see CPU usage per C# source line. As of today, to be able to see the source code of the `System.*.dll` libraries you need to build the dotnet/runtime repo locally, use `CoreRun.exe` to run the precompiled repro app (`.dll` file) and attach VS Profiler to the CoreRun process.

# Workshop

## Historical Data

Evaluate the historical data in the following issues:

- [System.Collections.IndexerSet<String>.Array](https://github.com/DrewScoggins/performance-2/issues/1908)
- [ByteMark.BenchIDEAEncryption](https://github.com/DrewScoggins/performance-2/issues/1609) (ignore the dead link, use the other one)
- [System.Xml.Linq.Perf_XElementList.Enumerator](https://github.com/DrewScoggins/performance-2/issues/1877)
- [System.Buffers.Tests.ReadOnlySequenceTests<Char>.IterateGetPositionTenSegments](https://github.com/DrewScoggins/performance-2/issues/1906)
- [Span.IndexerBench.KnownSizeCtor2](https://github.com/DrewScoggins/performance-2/issues/1854)
- [System.Buffers.Tests.RentReturnArrayPoolTests.ProducerConsumer](https://github.com/DrewScoggins/performance-2/issues/1047)
- [System.IO.Tests.Perf_Directory.EnumerateFiles](https://github.com/DrewScoggins/performance-2/issues/1596) (just `EnumerateFiles` benchmark, not all 3 mentioned in the issue)
- [PerfLabTests.BlockCopyPerf.CallBlockCopy](https://github.com/DrewScoggins/performance-2/issues/1861)

and assign them to one of the following categories:

* actual regression
* multimodal benchmark
* unstable benchmark
* noisy benchmark (within the range of 10% noise)

Click on the details to verify your answers:

<details>

Actual regression:

- `ByteMark.BenchIDEAEncryption`
- `System.IO.Tests.Perf_Directory.EnumerateFiles`

Multimodal:

- `System.Collections.IndexerSet<String>.Array`
- `Span.IndexerBench.KnownSizeCtor2`

Unstable:

- `System.Buffers.Tests.RentReturnArrayPoolTests<Object>.ProducerConsumer`
- `PerfLabTests.BlockCopyPerf.CallBlockCopy`

Noisy:

- `System.Buffers.Tests.ReadOnlySequenceTests<Char>.IterateGetPositionTenSegments`
- `System.Xml.Linq.Perf_XElementList.Enumerator`

</details>

## Disassembly

### Simple

Run `System.Tests.Perf_Char.GetUnicodeCategory` [benchmark](https://github.com/dotnet/performance/blob/1c160f6fd074d104e6de39b2fae48d657673a5ab/src/benchmarks/micro/libraries/System.Runtime/Perf.Char.cs#L85-L89) for .NET Core 3.1 and 5.0 x64, get the disassembly and answer the following questions:

1. What arguments do you need to pass to the `benchmarks_ci.py` script to run given benchmarks for .NET Core 3.1 & 5.0 and get the disassembly for depth equal 3?
2. Which test cases have regressed, which did not?
3. Why some of them have regressed?
4. Why others did not regress?
5. What could be a potential fix?
6. What is the recommended way of veryfing the fix?
7. Is it a big and important regression?

Click on the details to verify your answers:

<details>

1. `-f netcoreapp3.1 netcoreapp5.0 --filter System.Tests.Perf_Char.GetUnicodeCategory --bdn-arguments "--disasm true --disasmDepth 3"`
2. `.` and `a` have not regressed, `\x05D0` (represented as `?` in the console) did. The regression might not be visible on Skylake processors.
3. Because the `\x05D0` character requires 4 instead of 2 method calls now.
4. Because the code path for `.` and `a` has not changed.
5. Inlining `System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)` and `System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)` into `System.Globalization.CharUnicodeInfo.GetUnicodeCategory(Int32)`
6. Running the benchmarks against local build of dotnet/runtime repository by using CoreRun and passing it's path via `--corerun` to the harness.
7. No, it's a very minor regression used mainly for educational purpose.

</details>

### Medium

Run `Benchstone.BenchI.Fib.Test` [benchmark](https://github.com/dotnet/performance/blob/8aed638c9ee65c034fe0cca4ea2bdc3a68d2a6b5/src/benchmarks/micro/runtime/Benchstones/BenchI/Fib.cs) for .NET Core 3.1 and 5.0 **x86**, get the disassembly and answer the following questions:

1. What arguments do you need to pass to the `benchmarks_ci.py` script to run given benchmark for .NET Core 3.1 & 5.0 **x86** and get the disassembly?
2. Have the generated assembly code changed?
3. Have the performance regressed?
4. Have the code alignment changed?
5. What needs to be changed to enforce the harness to print instruction addresses?
6. If the generated codegen is the same, but the random code alignment have changed and the performance has regressed, is it worth investigating the issue further?

Click on the details to verify your answers:

<details>

1. `-f netcoreapp3.1 netcoreapp5.0 --architecture x86 --filter Benchstone.BenchI.Fib.Test --bdn-arguments "--disasm true"`
2. No.
3. Depending on the code alignment, it might have regressed.
4. Most likely yes.
4. You need to modify the [code](../src/harness/BenchmarkDotNet.Extensions/RecommendedConfig.cs) type and add `.AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(printInstructionAddresses: true)))`.
5. Most likely not as we have very little control over that.

</details>

### Hard

Run `System.Memory.Span<Char>.IndexOfValue` [benchmark](https://github.com/dotnet/performance/blob/8aed638c9ee65c034fe0cca4ea2bdc3a68d2a6b5/src/benchmarks/micro/libraries/System.Memory/Span.cs#L69) for .NET Core 3.1 and 5.0 x64, get the disassembly and answer the following questions:

1. What arguments do you need to pass to the `benchmarks_ci.py` script to run given benchmark for .NET Core 3.1 & 5.0 and get the disassembly?
2. Do `<` and `>` characters needs to be escaped when using Windows Command Prompt?
3. Have the total size of the generated code increased or decreased? If yes, by how many bytes?
4. Are there any instructions that have been removed in the newer version of .NET Core? If so, which ones?
5. Have the performance regressed?
6. What arguments needs to be passed to the `benchmarks_ci.py` script to enforce the JIT to align the loops? 
7. How can you verify that the loops have been aligned?
8. Does the performance change if you enforce JIT to align the loops?

Click on the details to verify your answers:

<details>

1. `-f netcoreapp3.1 netcoreapp5.0 --filter "System.Memory.Span<Char>.IndexOfValue" --bdn-arguments "--disasm true"`
2. Yes, otherwise you get an error saying *"The system cannot find the file specified"*.
3. Decreased, by `19` bytes (at least on Windows, `56 - 48 + 462 - 451`)
4. Two `mov`s from the benchmark and two `test` instructions from `System.SpanHelpers.IndexOf(Char ByRef, Char, Int32)`.
5. Depending on the code alignment, it might have regressed.
6. `--bdn-arguments "--envVars COMPlus_JitAlignLoops:1"`
7. You need to modify the [code](../src/harness/BenchmarkDotNet.Extensions/RecommendedConfig.cs) type and add `.AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(printInstructionAddresses: true)))`. Then run the benchmarks, open the exported disassembly and check if the address of the first instruction of the loop is aligned.
8. If the loop was not aligned before (the memory layout is random) it should improve.

</details>

## Profilers

### Simple

Create a small, stand-alone app that calls `DateTime.UtcNow` for 3-5 seconds and quits. Publish a self-contained executable for .NET Core **2.1** and **3.1** and profile both exes using PerfView. Answer the following questions:

1. How can a .NET Core console app project target both .NET Core 2.1 and 3.1?
2. Should you disable Tiered JIT? If yes, why and how.
3. What arguments needs to be passed to `dotnet publish` to publish a self-contained .NET Core 3.1 Windows x64 `.exe` in Release mode?
4. When profiling a standalone executable that quits after a few seconds, should you use Perview's `Collect -> Run` or `Collect -> Collect` option?
5. What needs to be set to prevent PerfView from grouping all methods that don't belong to the profiled `.exe` to `OTHER << X >>` group?
6. What needs to be done to see the full names of native methods without `?!` signs? Is there a shortcut for doing this for all the methods?
7. How to filter out process startup and rundown time? What's the easiest way of doing it?
8. What are the top three inclusive and exclusive CPU time contributors for .NET Core 2.1 and 3.1 (methods only)?
9. Should you search for top inclusive or exclusive CPU time contributors? Why?
10. What has caused the regression?

Click on the details to verify your answers:

<details>

1. The project file needs to target both TFMs: `<TargetFrameworks>netcoreapp2.1;netcoreapp3.1</TargetFrameworks>`.
2. Yes, to make the analysis easier by setting `<TieredCompilation>false</TieredCompilation>` in the project file.
3. `-c Release -f netcoreapp3.1 --self-contained -r win-x64`
4. `Collect -> Run`
5. Grouping needs to by disabled by choosing  `[no grouping]` from the `GroupPats` menu.
6. Symbols needs to be loaded by using the `Lookup Symbols` option. `Ctrl+A` to select all the methods and `Alt+S` to load the symbols.
7. By setting proper `Time Range`. The easiest way is to find `Main` method, right click on it and choose `Set Time Range`.
8. Top 3 (methods only):
   * inclusive 2.1: `ntdll!RtlUserThreadStart`, `kernel32!BaseThreadInitThunk`, `workshop!__scrt_common_main_seh`
   * exclusive 2.1: `ntdll!RtlQueryPerformanceCounter`, `ntdll!RtlGetSystemTimePrecise`, `coreclr!SystemNative::__GetSystemTimeAsFileTime`
   * inclusive 3.1: `ntdll!RtlUserThreadStart`, `kernel32!BaseThreadInitThunk`, `workshop!__scrt_common_main_seh`
   * exclusive 3.1: `ntdll!RtlpTimeToTimeFields`, `ntdll!RtlQueryPerformanceCounter`, `kernelbase!FileTimeToSystemTime`
9. Exclusive, as they perform the actual work.
10. Adding leap second support by introducting an extra call to `kernelbase!FileTimeToSystemTime` and two conversions: `DateToTicks` and `TimeToTicks`.

</details>


### Medium

Create a small, stand-alone app that excercises `BinaryFormatter.Deserialize(MemoryStream)` for 3-5 seconds and quits. The stream should contain a previously serialized instance of `LoginViewModel` (see definition below). Publish a self-contained executable for .NET Core **2.1** and **3.1** and profile both exes using PerfView.

```cs
[Serializable]
public class LoginViewModel
{
    public string Email { get; set; } = "name.familyname@not.com";
    public string Password { get; set; } = "abcdefgh123456!@";
    public bool RememberMe { get; set; } = true;
}
```

Answer the following questions:

1. Should the repro app allocate a new `MemoryStream` every time it tries to deserialize an instance of `LoginViewModel` type or perhaps reuse a single instance? Why?
2. How a single instance of `MemoryStream` could be reused multiple times for deserialization?
3. How could you possibly filter out the allocations of `MemoryStream` and `BinaryFormatter`?
4. What metric exposed by PerfView allows us to find out if given work was CPU bound or not? How to interpret it? Is it CPU bound this time?
5. Can you easily find the source of the regression in the `By Name` view? Why?
6. Does every box width in the Flame Graph correspond to CPU inclusive or exclusive time? What about the leaf boxes?
7. Can you easily find the source of the regression when eyeballing two Flame Graphs at the same time? Why?
8. Does PerfView offer any built-in feature that allows for identyfing the regressions?
9. What has caused the regression?
10. Is it recommended to use the built-in binary serialization in .NET 5?

Click on the details to verify your answers:

<details>

1. It should allocate a single `MemoryStream` instance, serialize `LoginViewModel` once and call deserialize in a loop. To make sure that we are profiling the deserialization only. Not allocation of `MemoryStream` and deserialization.
2. Stream's `Position` needs to be reset before every call to `Deserialize`.
3. There are many ways:
   * The loop with the deserialization could be moved out to a non-inlinable method and then you could just find the method, right click on it and select `Set Time Range`.
   * Right click on each of the unwanted methods and choose `Exclude Item`.
   * Create a new `EventSource` with `Start` and `Stop` events and emit them at runtime. Enable the Additional Provider in Advanced Options prior to profiling. Find the emited events in the `Events` view and use them to set the time range.
4. `Metric/Interval`. If it reports a value close to 1.00 and the code is single-threaded, the work is CPU bound. Yes, this example is CPU bound.
5. Most probably not, because there is no single, new and big exclusive time contributor.
6. Inclusive. For leafs the inclusive == exclusive as they are the last thing on the call stack and the only thing being executed.
7. It's possible, but unlikely. Both graphs are big (there is a lot of methods on the call stack).
8. Yes, it [does](profiling-workflow-dotnet-runtime.md#Identifying-Regressions).
9. Introduction of `ThreadDeserializationTracker`, it requires expensive stack walking.
10. No, it has been obsoleted and nobody should be using it.

</details>

### Hard

Copy the source code of [System.Text.Encodings.Web.Tests.Perf_Encoders.EncodeUtf8](https://github.com/dotnet/performance/blob/2a4232d994b88c37093399537b0b2a62ef163aeb/src/benchmarks/micro/libraries/System.Text.Encodings.Web/Perf.Encoders.cs) benchmark and create a small repro app using the following test case: `new EncoderArguments("no escaping required", 512, JavaScriptEncoder.Default)`. Publish a self-contained executable for .NET Core **3.1** and **5.0** and profile both exes using PerfView. Answer the following questions:

1. Is using PerfView enough to identify this particular regression? Why?
2. Which profilers can be used to see CPU time per C# source code line? Which one is recommended on Windows?
3. Which profiler can show CPU consumption per source line for both C# **and** C++ on Linux?
4. Use the recommended profiler and profile a local build of .NET Core 3.1 and 5.0 using CoreRun.exe ([Hint](#Visual-Studio-Profiler)). Is there any difference in the reported CPU time? Is it true for both when Tiered JIT is enabled and disabled?
5. What arguments need to be passed to the `benchmarks_ci.pi` script to run the benchmarks with Tiered JIT disabled?
6. Can DisassemblyDiagnoser be used to get the disassembly of the [System.Text.Encodings.Web.TextEncoder.EncodeUtf8](https://apisof.net/catalog/System.Text.Encodings.Web.TextEncoder.EncodeUtf8(ReadOnlySpan%3CByte%3E,Span%3CByte%3E,Int32,Int32,Boolean)) method? Why?
7. Which disassembler support indirect method calls?
8. Which profiler is capable of showing CPU consumption per machine code instruction?
9. If C# source code has not been modified, but the generated assembly code runs slower, to which area should you assign the issue?

<details>

1. If you are not a hardcore PerfView user, it's not because most of the exclusive CPU time is spent in one big method and you can't tell why it's slower.
2. Visual Studio Profiler (recommended), VTune and dotTrace.
3. [VTune](profiling-workflow-dotnet-runtime.md#Linux).
4. When Tiered JIT is disabled, there is almost no difference.
5. `--dotnet-compilation-mode NoTiering`
6. It can not, because the method is virtual and this disassembler does not support indirect method calls.
7. JitDump
8. VTune for Intel hardware and uProf for AMD hardware.
9. `area-CodeGen-coreclr`

</details>
