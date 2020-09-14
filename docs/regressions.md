# Investigating regressions reported in the [dotnet/runtime](https://github.com/dotnet/runtime) repository

## Table of Contents

- [Introduction](#Introduction)
- [Repro](#Repro)

# Introduction

**This doc explains how to investigate regressions reported in the [dotnet/runtime](https://github.com/dotnet/runtime) repository and it's targetted at [dotnet/runtime](https://github.com/dotnet/runtime) repository contributors.**

Before you start any performance investigation, you need to open the issue, click on the link that leads to the full historical data, and evaluate the data.

In most of the cases, it's obvious that there is a regression ([source](https://github.com/DrewScoggins/performance-2/issues/910)):

![Ovious regression](img/regressions_obvious.png)

And you just continue to the [next step](#Repro).

But some benchmarks are simply multimodal (bimodal in the examples below [1](https://github.com/DrewScoggins/performance-2/issues/1683), [2](https://github.com/DrewScoggins/performance-2/issues/1379), [3](https://github.com/DrewScoggins/performance-2/issues/1378)) and there is no regression:

![Bimodal benchmark, no actual regression](img/regressions_bimodal.png)

![Bimodal benchmark, no actual regression](img/regressions_bimodal_2.png)

![Bimodal benchmark, no actual regression](img/regressions_bimodal_3.png)

**If the historical data shows that there is no regression, you can just close the issue and explain it**. The more mature the system becomes, the less frequent it should be.

Some benchmarks can be unstable like in [this example](https://github.com/DrewScoggins/performance-2/issues/759):

![Unstable](img/regressions_unstable.png)

**If the benchmark is unstable and it measures something from an area that you [own](https://github.com/dotnet/runtime/blob/master/docs/area-owners.md), you should investigate why and most probably rewrite it.**

Last but not least, it might not be clear whether there is a regression or not, like in the following [example](https://github.com/DrewScoggins/performance-2/issues/1253):

![Not sure](img/regressions_notsure.png)

Is such cases, you should estimate how important could be such a regression and decide whether you want to investigate it or not. You should always focus on the obvious regressions first, as they are very often caused by a problem that affects many other benchmarks. Fixing it might simply close few issues at once.

# Repro

The next step is to reproduce the regression locally. The most convenient way to do it is by using the [benchmarks_ci.py](../scripts/benchmarks_ci.py)
 script using the command provided in the reported issue.
 
 
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
 