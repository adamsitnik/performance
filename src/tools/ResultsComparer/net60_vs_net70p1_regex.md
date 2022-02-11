# Legend

* Statistical Test threshold: 10%, the noise filter: 2 ns
* Result is conslusion: Slower|Faster|Same
* Base is median base execution time in nanoseconds
* Diff is median diff execution time in nanoseconds
* Ratio = Base/Diff (the higher the better)
* Alloc Delta = Allocated bytes diff - Allocated bytes base (the lower the better)
* Base V = Base Runtime Version
* Diff V = Diff Runtime Version

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes|Watson|Irene|Adler|John|Baker", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  722745.54 | 1678461.88 |  0.43 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  600029.57 | 1348359.11 |  0.45 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  932771.09 | 2019190.63 |  0.46 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1611262.50 | 3806445.52 |  0.42 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  865622.40 | 1898259.72 |  0.46 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  815050.66 | 1932060.94 |  0.42 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  888743.23 | 2075622.66 |  0.43 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1276999.04 | 2898391.15 |  0.44 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1118947.32 | 2581766.15 |  0.43 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  618729.85 | 1424509.93 |  0.43 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  936239.04 | 2096441.36 |  0.45 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1738060.40 | 4386862.42 |  0.40 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1294305.64 | 3023409.10 |  0.43 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  858693.23 | 1934665.63 |  0.44 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  884582.99 | 2042198.44 |  0.43 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  870348.61 | 1956876.56 |  0.44 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1588231.88 | 3397853.75 |  0.47 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  786325.00 | 2478466.52 |  0.32 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2328459.82 | 4357641.07 |  0.53 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1177498.71 | 2722937.84 |  0.43 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1067045.34 | 2459937.87 |  0.43 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.CtorInvoke(Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  96509.49 | 215879.34 |  0.45 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  81276.60 | 169100.10 |  0.48 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 132344.96 | 286334.65 |  0.46 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 186037.31 | 389427.05 |  0.48 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 103236.64 | 231721.88 |  0.45 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 101920.09 | 222009.33 |  0.46 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 106084.77 | 244393.85 |  0.43 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 146342.47 | 332079.95 |  0.44 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 173780.18 | 341268.13 |  0.51 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  82504.38 | 163246.71 |  0.51 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 129777.18 | 268324.71 |  0.48 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 256431.45 | 481134.38 |  0.53 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 181324.01 | 357438.64 |  0.51 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 121297.27 | 251314.82 |  0.48 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 113092.50 | 239564.68 |  0.47 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 109968.42 | 238149.29 |  0.46 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 184171.88 | 324840.88 |  0.57 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 135483.84 | 304080.05 |  0.45 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 208301.77 | 353259.72 |  0.59 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 192486.04 | 366966.41 |  0.52 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 173197.52 | 334128.12 |  0.52 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.CtorInvoke(Options: IgnoreCase, Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 133109.78 | 231763.34 |  0.57 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 108264.22 | 179224.93 |  0.60 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 178814.63 | 296730.58 |  0.60 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 331945.34 | 417696.39 |  0.79 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 147479.85 | 249061.14 |  0.59 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 145175.58 | 239147.92 |  0.61 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 155589.14 | 284004.58 |  0.55 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 210474.52 | 351834.10 |  0.60 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 207302.10 | 372993.60 |  0.56 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 113214.96 | 167133.07 |  0.68 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 183078.19 | 291765.25 |  0.63 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 326115.00 | 521152.35 |  0.63 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 240147.19 | 384301.84 |  0.62 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 171909.38 | 272303.62 |  0.63 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 158318.69 | 258185.21 |  0.61 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 157176.17 | 266542.37 |  0.59 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 239877.98 | 347767.01 |  0.69 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 193589.73 | 323520.15 |  0.60 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 262797.60 | 383554.04 |  0.69 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 266985.57 | 392581.93 |  0.68 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 234069.05 | 362657.57 |  0.65 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: ".{0,2}(Tom|Sawyer|Huckleberry|Finn)", Options: None)

| Result |           Base |           Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------------:| --------------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  3642113000.00 |  5587675600.00 |  0.65 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  2946013100.00 |  3531785850.00 |  0.83 |          +0 | bimodal    | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4518690750.00 |  5975230200.00 |  0.76 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7033177750.00 |  9227097400.00 |  0.76 |          +0 | several?   | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3854693300.00 |  5395809150.00 |  0.71 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4735119100.00 |  6508938400.00 |  0.73 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4310361200.00 |  5447049600.00 |  0.79 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower |  6407024650.00 |  8080086900.00 |  0.79 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  6038558200.00 |  7452722700.00 |  0.81 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  2695484505.00 |  3517862930.00 |  0.77 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4259281131.50 |  5899057983.00 |  0.72 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 12767088309.00 | 15787215268.00 |  0.81 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8570264280.50 | 10743147911.00 |  0.80 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3969345800.00 |  5680257600.00 |  0.70 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3951060800.00 |  5556319800.00 |  0.71 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3988659800.00 |  5649864900.00 |  0.71 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7116166600.00 |  8498239000.00 |  0.84 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4272888600.00 |  6109422100.00 |  0.70 |          +0 | bimodal    | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8899745700.00 |  9972140400.00 |  0.89 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  5599016927.00 |  7412011257.00 |  0.76 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4886674864.00 |  6836840845.00 |  0.71 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Ctor(Pattern: "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])", Options: None)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  6093.71 |  8179.98 |  0.74 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3891.61 |  5526.60 |  0.70 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  6298.35 |  8335.50 |  0.76 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12434.54 | 11113.66 |  1.12 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  5443.21 |  7243.42 |  0.75 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  5158.46 |  7033.72 |  0.73 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  5668.07 |  7689.87 |  0.74 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7539.25 | 11152.17 |  0.68 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8722.99 |  9795.56 |  0.89 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  5195.98 |  7368.20 |  0.71 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7248.18 |  8744.68 |  0.83 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 15391.89 | 20908.54 |  0.74 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 10841.37 | 14789.67 |  0.73 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7990.15 |  8978.36 |  0.89 |          +0 | bimodal  | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7466.18 | 10619.43 |  0.70 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7336.87 |  9948.71 |  0.74 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  9503.20 | 13086.94 |  0.73 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  6354.10 |  8327.52 |  0.76 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 11352.51 | 16901.43 |  0.67 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8648.75 | 11546.02 |  0.75 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7820.25 | 10537.33 |  0.74 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesWord(Options: Compiled)

| Result |    Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 1864.66 |  2700.97 |  0.69 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1535.51 |  1824.12 |  0.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2346.52 |  3072.23 |  0.76 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3862.60 |  3781.30 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1996.86 |  2186.79 |  0.91 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1964.92 |  2284.51 |  0.86 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2046.68 |  2467.78 |  0.83 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2794.10 |  3365.30 |  0.83 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3053.48 |  3392.11 |  0.90 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1747.37 |  2023.71 |  0.86 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2272.53 |  2872.91 |  0.79 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 5762.61 | 10322.76 |  0.56 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 3073.38 |  4071.79 |  0.75 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2405.19 |  4168.14 |  0.58 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2519.34 |  4042.03 |  0.62 |          +0 | bimodal  | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2533.00 |  4026.94 |  0.63 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 3763.18 |  4384.12 |  0.86 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1941.10 |  3532.61 |  0.55 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4393.97 |  4484.94 |  0.98 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2916.55 |  3870.49 |  0.75 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2633.59 |  3661.45 |  0.72 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: ".{2,4}(Tom|Sawyer|Huckleberry|Finn)", Options: None)

| Result |           Base |           Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------------:| --------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  3728110200.00 |  5493430500.00 |  0.68 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3006108200.00 |  3702816200.00 |  0.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4351757450.00 |  6055820100.00 |  0.72 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7785415100.00 |  9978317100.00 |  0.78 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3964384800.00 |  5578598100.00 |  0.71 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4440730900.00 |  6431345500.00 |  0.69 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4101414150.00 |  5742242350.00 |  0.71 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower |  6159308700.00 |  8169897200.00 |  0.75 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6673100400.00 |  7081055700.00 |  0.94 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  2737609954.50 |  3553481512.00 |  0.77 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4313464345.00 |  5860972543.00 |  0.74 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 12069368873.00 | 14720230890.00 |  0.82 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  9070326711.00 | 10646739863.00 |  0.85 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4072212200.00 |  5604067900.00 |  0.73 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4031649600.00 |  5505331700.00 |  0.73 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4052171600.00 |  5600770500.00 |  0.72 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  7238944900.00 |  8174238100.00 |  0.89 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4337919100.00 |  6083673650.00 |  0.71 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8990780800.00 |  9730330600.00 |  0.92 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  5663021266.00 |  7395918043.00 |  0.77 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  4985122221.00 |  7394105901.50 |  0.67 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Backtracking(Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 1092.21 | 1296.46 |  0.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  806.13 | 1006.38 |  0.80 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1405.52 | 1610.85 |  0.87 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2049.87 | 3359.34 |  0.61 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1270.36 | 1491.90 |  0.85 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1621.84 | 1736.47 |  0.93 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1424.68 | 1557.60 |  0.91 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2188.43 | 2119.00 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2049.79 | 2053.76 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  907.36 | 1036.69 |  0.88 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1317.52 | 1576.81 |  0.84 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 3105.46 | 4472.68 |  0.69 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1966.73 | 3240.34 |  0.61 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1145.61 | 1429.15 |  0.80 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1172.22 | 1439.51 |  0.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1170.03 | 1463.32 |  0.80 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2097.45 | 2279.12 |  0.92 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1298.32 | 1597.25 |  0.81 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2711.37 | 3132.03 |  0.87 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1736.03 | 2105.35 |  0.82 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1522.91 | 1891.54 |  0.81 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 0, Options: Compiled)

| Result |  Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 28.83 |  44.17 |  0.65 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 32.18 |  26.55 |  1.21 |          +0 | bimodal  | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 37.54 |  46.49 |  0.81 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 78.87 |  64.98 |  1.21 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 35.63 |  44.49 |  0.80 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 38.51 |  45.97 |  0.84 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34.87 |  43.70 |  0.80 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 47.49 |  56.81 |  0.84 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 42.73 |  58.53 |  0.73 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 21.71 |  28.14 |  0.77 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 39.15 |  47.01 |  0.83 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 77.05 | 100.38 |  0.77 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 54.83 |  66.83 |  0.82 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34.51 |  42.48 |  0.81 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34.33 |  45.32 |  0.76 |          +0 | several? | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34.83 |  44.10 |  0.79 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 59.89 |  69.20 |  0.87 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 37.71 |  53.91 |  0.70 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 82.67 |  88.46 |  0.93 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 48.41 |  58.55 |  0.83 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 44.21 |  55.61 |  0.80 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Ctor(Pattern: "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])", Options: Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 20726.79 | 24753.57 |  0.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 14348.63 | 17088.81 |  0.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 24714.77 | 28035.60 |  0.88 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49415.08 | 39899.76 |  1.24 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 21912.77 | 24475.48 |  0.90 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 21167.96 | 23408.12 |  0.90 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 22676.18 | 25858.77 |  0.88 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 31104.18 | 37447.87 |  0.83 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 34092.31 | 32492.30 |  1.05 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 17561.80 | 22604.54 |  0.78 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 26492.36 | 30463.68 |  0.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 61593.61 | 71646.10 |  0.86 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 42797.29 | 49546.49 |  0.86 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26293.31 | 29591.34 |  0.89 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27335.61 | 33218.36 |  0.82 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27728.25 | 33571.90 |  0.83 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34551.57 | 39499.10 |  0.87 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 24190.41 | 29058.79 |  0.83 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 44707.80 | 53137.22 |  0.84 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 36589.09 | 42013.84 |  0.87 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 32330.39 | 39082.42 |  0.83 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock|Holmes|Watson|Irene|Adler|John|Baker", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 25638342.86 | 31465368.75 |  0.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 17958000.00 | 19106030.00 |  0.94 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27980785.71 | 34994666.67 |  0.80 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 57715650.00 | 51133837.50 |  1.13 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 24554775.00 | 30155871.43 |  0.81 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 26756528.57 | 37049658.33 |  0.72 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 25950450.00 | 33694921.43 |  0.77 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 36844750.00 | 46666625.00 |  0.79 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 37869350.00 | 41208325.00 |  0.92 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18054107.11 | 20145333.44 |  0.90 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27191329.14 | 34182036.08 |  0.80 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 59335712.25 | 77303914.00 |  0.77 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 46522583.75 | 58540296.13 |  0.79 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 25152850.00 | 31771664.29 |  0.79 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 24796187.50 | 31200587.50 |  0.79 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 24999806.25 | 31631337.50 |  0.79 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 41543700.00 | 45460962.50 |  0.91 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27206105.56 | 37063125.00 |  0.73 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 50732150.00 | 60605250.00 |  0.84 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 35176963.25 | 42091252.00 |  0.84 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 32561135.88 | 38173044.13 |  0.85 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?m)^Sherlock Holmes|Sherlock Holmes$", Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  73587.32 | 105224.19 |  0.70 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  59253.85 |  79942.43 |  0.74 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 101840.81 | 124051.97 |  0.82 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 337609.86 | 274033.89 |  1.23 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  88891.24 | 108643.77 |  0.82 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  97652.15 | 116072.07 |  0.84 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  94997.84 | 114304.84 |  0.83 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 129930.26 | 152882.69 |  0.85 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 141906.37 | 141711.28 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  59031.91 |  76612.93 |  0.77 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  96884.15 | 116172.93 |  0.83 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 224007.92 | 299095.23 |  0.75 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 158184.62 | 225023.33 |  0.70 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  86640.66 | 111575.94 |  0.78 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 101225.89 | 129657.44 |  0.78 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  87028.11 | 113848.30 |  0.76 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 163116.91 | 180023.28 |  0.91 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  97701.94 | 120931.60 |  0.81 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 366898.26 | 402926.91 |  0.91 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 123947.35 | 149733.82 |  0.83 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 117103.79 | 138206.42 |  0.85 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\b\w+n\b", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 25541133.33 | 33076450.00 |  0.77 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 20206738.89 | 25013735.71 |  0.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 31554850.00 | 36413612.50 |  0.87 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 44842200.00 | 73197862.50 |  0.61 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 26950038.89 | 31498106.25 |  0.86 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 31224837.50 | 40983333.33 |  0.76 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 29721916.67 | 34140675.00 |  0.87 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 46010037.50 | 51162687.50 |  0.90 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 53504850.00 | 43315387.50 |  1.24 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 18419426.46 | 24470379.60 |  0.75 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 29668431.75 | 32150954.50 |  0.92 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 61590254.75 | 81553993.50 |  0.76 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 44575114.25 | 55092389.75 |  0.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 26939633.33 | 32175512.50 |  0.84 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27380977.78 | 32320650.00 |  0.85 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27657461.11 | 32428018.75 |  0.85 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 42965000.00 | 43826075.00 |  0.98 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 30474793.75 | 35187812.50 |  0.87 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 59279400.00 | 70506325.00 |  0.84 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 37882944.38 | 41602460.25 |  0.91 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 33613596.17 | 37881421.00 |  0.89 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 0, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  53.45 |  75.80 |  0.71 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  42.79 |  52.51 |  0.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  77.13 |  93.43 |  0.83 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 145.37 | 134.30 |  1.08 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  65.18 |  77.55 |  0.84 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  73.38 |  83.51 |  0.88 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  65.57 |  77.28 |  0.85 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower |  93.15 | 109.98 |  0.85 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  82.52 | 103.85 |  0.79 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.03 |  49.45 |  0.93 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75.05 |  83.43 |  0.90 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 155.73 | 174.96 |  0.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 106.18 | 119.02 |  0.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  62.93 |  70.63 |  0.89 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  62.90 |  70.06 |  0.90 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  59.45 |  70.07 |  0.85 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 108.50 | 114.81 |  0.95 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  74.34 |  85.99 |  0.86 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 131.47 | 154.17 |  0.85 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  96.28 | 106.53 |  0.90 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  85.29 |  96.74 |  0.88 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchWord(Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 1176.52 | 1472.32 |  0.80 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  855.63 | 1233.41 |  0.69 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1486.90 | 1838.01 |  0.81 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2153.96 | 2714.87 |  0.79 |          +0 | multimodal | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1310.46 | 1560.04 |  0.84 |          +0 | bimodal    | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1584.68 | 1703.03 |  0.93 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1412.80 | 1605.39 |  0.88 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2167.01 | 2225.81 |  0.97 |          +0 | several?   | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2203.45 | 2175.26 |  1.01 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  917.15 | 1110.43 |  0.83 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1442.95 | 1638.25 |  0.88 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 3842.85 | 4634.51 |  0.83 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2709.20 | 3447.42 |  0.79 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1378.28 | 1770.81 |  0.78 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1388.68 | 1836.59 |  0.76 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1383.19 | 1753.56 |  0.79 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2221.15 | 2485.93 |  0.89 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1398.39 | 1735.63 |  0.81 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2853.62 | 3257.37 |  0.88 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2745.77 | 2198.45 |  1.25 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1698.77 | 1900.19 |  0.89 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\s[a-zA-Z]{0,12}ing\s", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 15282090.91 | 17860463.64 |  0.86 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11233843.75 | 11955600.00 |  0.94 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18682840.00 | 20546655.56 |  0.91 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27047850.00 | 38493775.00 |  0.70 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 16325653.33 | 18779725.00 |  0.87 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 18130968.18 | 20753209.09 |  0.87 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 17839172.73 | 20101630.00 |  0.89 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26366600.00 | 28796414.29 |  0.92 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 22268068.75 | 25632825.00 |  0.87 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 11193808.88 | 15604425.50 |  0.72 |          +0 | several? | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 17385010.82 | 20288221.70 |  0.86 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 38624092.50 | 44017634.00 |  0.88 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 27174250.43 | 32490658.00 |  0.84 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 16775606.67 | 19355620.00 |  0.87 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 17043025.00 | 18953227.27 |  0.90 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 17065127.27 | 19433720.00 |  0.88 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26893550.00 | 26865244.44 |  1.00 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 16742350.00 | 22148555.56 |  0.76 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 36660250.00 | 38002300.00 |  0.96 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 22639662.00 | 26892939.69 |  0.84 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20856754.44 | 23146646.28 |  0.90 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "(?i)Tom|Sawyer|Huckleberry|Finn", Options: None)

| Result |         Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| -------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 362775100.00 |  426953150.00 |  0.85 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 246919450.00 |  290176850.00 |  0.85 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 432618250.00 |  486411050.00 |  0.89 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 621184400.00 |  710982600.00 |  0.87 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 376394350.00 |  410937000.00 |  0.92 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 402180700.00 |  484440550.00 |  0.83 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 397605200.00 |  444777100.00 |  0.89 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 601776500.00 |  612326750.00 |  0.98 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 521208550.00 |  673160500.00 |  0.77 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 252448224.00 |  289836062.00 |  0.87 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 435003809.00 |  469902610.00 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 920771894.00 | 1097414711.00 |  0.84 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 685822206.00 |  807241871.00 |  0.85 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 391637200.00 |  452263650.00 |  0.87 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 392916000.00 |  454056400.00 |  0.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 389116850.00 |  450863400.00 |  0.86 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 563752000.00 |  611567500.00 |  0.92 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 421561500.00 |  542826400.00 |  0.78 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 707063400.00 |  840196350.00 |  0.84 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 558694175.00 |  591589683.00 |  0.94 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 498739770.00 |  542079879.00 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsNotMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  89.51 | 147.51 |  0.61 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  65.56 |  81.10 |  0.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 120.81 | 139.02 |  0.87 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 220.19 | 274.54 |  0.80 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 104.76 | 117.40 |  0.89 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 127.69 | 144.64 |  0.88 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 113.48 | 139.18 |  0.82 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 154.02 | 192.06 |  0.80 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 172.06 | 189.03 |  0.91 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  73.05 |  95.26 |  0.77 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 128.75 | 150.56 |  0.86 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 247.14 | 285.33 |  0.87 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 178.56 | 197.11 |  0.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 118.11 | 142.61 |  0.83 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 115.03 | 136.90 |  0.84 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 115.31 | 142.79 |  0.81 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 182.33 | 178.89 |  1.02 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 135.75 | 140.93 |  0.96 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 267.16 | 224.43 |  1.19 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 157.28 | 180.20 |  0.87 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 141.01 | 165.42 |  0.85 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.SplitWords(Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  44174.55 |  53691.10 |  0.82 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  33957.87 |  39290.82 |  0.86 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  56643.99 |  69447.63 |  0.82 |          +0 | bimodal    | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  81307.17 |  97452.19 |  0.83 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49783.88 |  55812.46 |  0.89 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60377.60 |  62290.69 |  0.97 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54301.65 |  58478.87 |  0.93 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  81513.78 |  80573.85 |  1.01 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  83735.75 |  77655.81 |  1.08 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  34749.02 |  37593.64 |  0.92 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  54782.21 |  66498.71 |  0.82 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 138847.12 | 165316.90 |  0.84 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 101112.28 | 137437.07 |  0.74 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  51771.76 |  65856.81 |  0.79 |          +0 | several?   | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  52107.24 |  65148.86 |  0.80 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  52233.03 |  62797.34 |  0.83 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  79819.99 |  86407.80 |  0.92 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  54217.59 |  62610.24 |  0.87 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 103162.34 | 117682.24 |  0.88 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  74342.45 |  77173.18 |  0.96 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62428.54 |  69401.28 |  0.90 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Ctor(Options: IgnoreCase, Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 26736.53 | 30488.31 |  0.88 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18863.38 | 20660.80 |  0.91 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 30185.27 | 35164.02 |  0.86 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 61880.50 | 48596.00 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 27917.07 | 30087.29 |  0.93 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 28200.82 | 28726.35 |  0.98 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 28967.40 | 31605.99 |  0.92 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 38969.73 | 43078.16 |  0.90 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 36807.20 | 42862.35 |  0.86 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 22187.15 | 26291.25 |  0.84 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 36163.63 | 38418.41 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 77188.99 | 86779.64 |  0.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 60539.05 | 58641.00 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 32505.19 | 37008.10 |  0.88 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34379.57 | 40625.86 |  0.85 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 34435.47 | 40763.30 |  0.84 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 44102.40 | 49221.55 |  0.90 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 33433.65 | 35844.38 |  0.93 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 57171.69 | 65919.60 |  0.87 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 46146.73 | 52372.24 |  0.88 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 42618.33 | 46978.91 |  0.91 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesWords(Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  44124.76 |  51515.42 |  0.86 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  33659.95 |  37174.99 |  0.91 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  56041.77 |  64996.76 |  0.86 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  82371.48 |  94057.53 |  0.88 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49615.47 |  54901.07 |  0.90 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  60090.98 |  70113.55 |  0.86 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54402.46 |  58024.30 |  0.94 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  81237.79 |  78838.70 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  83896.02 |  80560.15 |  1.04 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  34638.31 |  38145.37 |  0.91 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55047.02 |  60297.66 |  0.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 143784.21 | 165302.49 |  0.87 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 101045.86 | 124245.37 |  0.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  51679.10 |  63231.34 |  0.82 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  53082.55 |  66463.86 |  0.80 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  52270.05 |  64209.24 |  0.81 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  83996.10 |  86046.33 |  0.98 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  52666.45 |  62169.62 |  0.85 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 103508.59 | 115763.21 |  0.89 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  96654.74 |  87405.76 |  1.11 |          +0 | bimodal  | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62740.72 |  69000.35 |  0.91 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.ReplaceWords(Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  44691.64 |  52712.11 |  0.85 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  33618.78 |  36710.27 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58846.05 |  65627.80 |  0.90 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  81517.22 |  99429.27 |  0.82 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  49933.34 |  56989.26 |  0.88 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58469.58 |  62330.93 |  0.94 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54552.58 |  58193.72 |  0.94 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  84414.74 |  80341.87 |  1.05 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  84531.02 |  79739.88 |  1.06 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  35339.76 |  41685.60 |  0.85 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57129.36 |  58827.78 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 139385.69 | 168334.14 |  0.83 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 101129.72 | 122805.59 |  0.82 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  51448.36 |  73004.07 |  0.70 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  51659.28 |  66092.33 |  0.78 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  51998.43 |  63729.74 |  0.82 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  79896.76 |  85948.09 |  0.93 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  53088.09 |  66889.82 |  0.79 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 103798.47 | 114524.79 |  0.91 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76125.04 |  76276.29 |  1.00 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62907.74 |  68636.49 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "([A-Za-z]awyer|[A-Za-z]inn)\s", Options: None)

| Result |          Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------------:| -------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  791456200.00 |  964584600.00 |  0.82 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  701677400.00 |  732223250.00 |  0.96 |          +0 | bimodal  | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1008519900.00 | 1238262800.00 |  0.81 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1480371800.00 | 1789946850.00 |  0.83 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  909749950.00 |  974029700.00 |  0.93 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1075618000.00 | 1157574750.00 |  0.93 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  980790400.00 | 1024260900.00 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1390137800.00 | 1510189500.00 |  0.92 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1212691300.00 | 1388266600.00 |  0.87 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  667065431.00 |  674985549.00 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  981516851.00 | 1024734660.00 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2498617249.50 | 2737884176.50 |  0.91 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1665651411.00 | 2008399516.00 |  0.83 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  936002600.00 | 1248187700.00 |  0.75 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  934137900.00 | 1231692850.00 |  0.76 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  932077000.00 | 1215724600.00 |  0.77 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1503420700.00 | 1413943850.00 |  1.06 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1019753800.00 | 1202223850.00 |  0.85 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2022544300.00 | 2111295300.00 |  0.96 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1283845760.00 | 1315645942.50 |  0.98 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1120615747.00 | 1174755450.00 |  0.95 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesSet(Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  42665.63 |  52423.40 |  0.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  31966.77 |  36469.32 |  0.88 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58475.06 |  53627.59 |  1.09 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 108060.04 |  87874.81 |  1.23 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49960.89 |  52771.31 |  0.95 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62863.79 |  54898.20 |  1.15 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55555.58 |  52631.01 |  1.06 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77592.06 |  69420.17 |  1.12 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  86728.75 |  74148.10 |  1.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  34532.50 |  37618.75 |  0.92 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  56541.59 |  63304.39 |  0.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 144295.70 | 134866.90 |  1.07 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77807.30 |  83970.32 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58775.94 |  56486.57 |  1.04 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58692.97 |  59378.05 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58419.61 |  58039.51 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  82120.42 |  87370.52 |  0.94 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  53957.78 |  64277.67 |  0.84 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 104791.77 | 112407.07 |  0.93 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  72183.89 |  74632.69 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  65485.33 |  73179.91 |  0.89 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\p{L}", Options: None)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  41002675.00 |  42376925.00 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  29317371.43 |  29211737.50 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48701287.50 |  53031900.00 |  0.92 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  69051337.50 | 115389700.00 |  0.60 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  40961800.00 |  44612950.00 |  0.92 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  41226175.00 |  45590725.00 |  0.90 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  44436950.00 |  45241325.00 |  0.98 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66411025.00 |  68968700.00 |  0.96 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57675675.00 |  59702712.50 |  0.97 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  38487946.00 |  45091318.50 |  0.85 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  52378989.25 |  55857100.25 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 104499137.00 | 110015247.50 |  0.95 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  75323317.50 |  88952112.50 |  0.85 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46362112.50 |  48341850.00 |  0.96 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53643950.00 |  57302762.50 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54782000.00 |  56783225.00 |  0.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76999150.00 |  79371287.50 |  0.97 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  44867400.00 |  50793450.00 |  0.88 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  92869950.00 | 100699550.00 |  0.92 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  70389048.50 |  74277010.75 |  0.95 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  59101119.25 |  80500068.63 |  0.73 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "[^\n]*", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 2341021.43 | 2790416.25 |  0.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1663093.75 | 1925428.13 |  0.86 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2995976.25 | 3226582.50 |  0.93 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5792422.92 | 4455095.83 |  1.30 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2466930.73 | 2708320.00 |  0.91 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2509413.54 | 2689109.38 |  0.93 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2692700.00 | 2900048.75 |  0.93 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4101311.72 | 4355558.33 |  0.94 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3531256.25 | 3809851.56 |  0.93 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2269570.82 | 2499100.69 |  0.91 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3095512.55 | 3350011.02 |  0.92 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6547170.02 | 6874337.72 |  0.95 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4518453.89 | 4715361.61 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2847676.25 | 3074890.00 |  0.93 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3390789.38 | 3658596.88 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3411051.25 | 3643334.38 |  0.94 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4667664.58 | 4914083.33 |  0.95 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2828061.98 | 2992592.50 |  0.95 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 5346833.33 | 6011476.56 |  0.89 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 4095509.37 | 4626076.91 |  0.89 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3627718.73 | 3932110.17 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes|Watson|Irene|Adler|John|Baker", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 2160888.75 | 2419051.04 |  0.89 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1578112.19 | 1797682.81 |  0.88 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2724881.77 | 2822856.77 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 3890346.88 | 5346480.21 |  0.73 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2386257.50 | 2456405.21 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2490621.43 | 2738317.71 |  0.91 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2595981.25 | 2533735.94 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3886730.47 | 3725325.78 |  1.04 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3224397.50 | 3338440.63 |  0.97 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1644924.64 | 1997577.10 |  0.82 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2795727.44 | 2865247.56 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5896985.75 | 6031033.81 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 4249876.09 | 4814625.71 |  0.88 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2459300.89 | 2675788.54 |  0.92 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2464131.88 | 2697018.75 |  0.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2469702.68 | 2682469.27 |  0.92 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3783251.04 | 3573923.44 |  1.06 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2715113.54 | 3152008.75 |  0.86 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5403431.25 | 5182483.33 |  1.04 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3734039.67 | 3828962.91 |  0.98 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3173357.36 | 3355390.40 |  0.95 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Street", Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 103844.43 | 111519.64 |  0.93 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  74011.49 |  84948.27 |  0.87 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 128679.71 | 143053.39 |  0.90 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 251448.91 | 202076.62 |  1.24 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 106585.00 | 119786.88 |  0.89 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 115346.24 | 131404.69 |  0.88 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 119708.71 | 124726.43 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 180297.95 | 189886.26 |  0.95 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 178756.81 | 159040.81 |  1.12 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  77276.56 |  90624.97 |  0.85 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121362.85 | 131933.91 |  0.92 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 286282.59 | 321914.37 |  0.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 205633.50 | 241194.82 |  0.85 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 107429.32 | 124078.54 |  0.87 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 123443.37 | 141550.17 |  0.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 109836.84 | 130886.79 |  0.84 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 199057.04 | 203095.45 |  0.98 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121739.18 | 135509.73 |  0.90 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 410118.20 | 423825.34 |  0.97 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 160240.62 | 175804.95 |  0.91 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142505.74 | 155349.95 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  68.54 | 104.92 |  0.65 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  54.23 |  73.41 |  0.74 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 110.29 | 116.19 |  0.95 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 156.16 | 228.76 |  0.68 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower |  86.24 | 104.34 |  0.83 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 100.26 | 112.67 |  0.89 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Slower |  93.09 | 115.59 |  0.81 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 132.61 | 156.38 |  0.85 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142.31 | 155.87 |  0.91 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.89 |  70.08 |  0.91 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 110.73 | 127.95 |  0.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 202.89 | 237.60 |  0.85 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Slower | 151.95 | 173.71 |  0.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  92.50 | 116.97 |  0.79 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  91.71 | 115.29 |  0.80 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  92.85 | 114.60 |  0.81 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 158.67 | 149.31 |  1.06 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 117.12 | 130.29 |  0.90 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 222.18 | 192.65 |  1.15 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 194.73 | 163.03 |  1.19 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 150.07 | 148.13 |  1.01 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock|Holmes|Watson", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  7370650.00 |  7689246.88 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5628222.92 |  6215904.17 |  0.91 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9456607.81 | 10593700.00 |  0.89 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 14130884.62 | 17223411.54 |  0.82 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8194421.88 |  8485406.25 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8628537.50 | 11820095.31 |  0.73 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8669409.38 |  9635912.50 |  0.90 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11889880.95 | 13084510.00 |  0.91 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12925111.54 | 11916705.00 |  1.08 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5950689.98 |  6324379.23 |  0.94 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9457940.13 |  9815527.92 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 22008872.67 | 24590254.00 |  0.90 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16541611.42 | 17884267.17 |  0.92 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8962362.50 | 10427387.50 |  0.86 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  9064089.06 | 10345864.06 |  0.88 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  8994246.88 | 10573304.69 |  0.85 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13166842.11 | 12172000.00 |  1.08 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9733001.56 | 10777526.56 |  0.90 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16787994.44 | 17544218.18 |  0.96 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12161674.07 | 13622825.73 |  0.89 |          +0 | several? | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11127619.06 | 11123898.14 |  1.00 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\w+\s+Holmes\s+\w+", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 3238053.75 | 3514896.88 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2458779.17 | 2729705.21 |  0.90 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3803485.16 | 4217241.41 |  0.90 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5474266.67 | 5684204.88 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3604250.63 | 3787693.75 |  0.95 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4314442.19 | 4080760.00 |  1.06 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4178748.44 | 3822250.00 |  1.09 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6232287.50 | 5626335.56 |  1.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5165881.25 | 4800233.33 |  1.08 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2545894.32 | 2900963.18 |  0.88 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4015918.93 | 4313911.90 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 7398121.56 | 8019951.52 |  0.92 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5326533.05 | 5740233.98 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3575207.50 | 3845391.25 |  0.93 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3621355.00 | 3879968.75 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3597723.75 | 3862776.25 |  0.93 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5411830.21 | 5246804.17 |  1.03 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4482207.81 | 4462365.63 |  1.00 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6844481.25 | 7017023.61 |  0.98 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5072574.24 | 5511887.46 |  0.92 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Slower | 4609723.17 | 5202473.86 |  0.89 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsNotMatch(Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 362.39 | 376.64 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 238.19 | 244.30 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 393.66 | 441.70 |  0.89 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 960.92 | 967.49 |  0.99 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 381.88 | 374.18 |  1.02 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 485.58 | 462.38 |  1.05 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 383.23 | 397.62 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 571.69 | 550.26 |  1.04 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 607.10 | 536.39 |  1.13 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 238.60 | 233.69 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 416.26 | 396.30 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 830.40 | 933.41 |  0.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 583.52 | 644.19 |  0.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 371.94 | 401.46 |  0.93 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 363.32 | 389.18 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 377.28 | 382.30 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 593.21 | 546.93 |  1.08 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 394.28 | 446.72 |  0.88 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 836.01 | 849.83 |  0.98 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 518.28 | 510.02 |  1.02 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 471.49 | 457.09 |  1.03 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "\p{Sm}", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 11403503.13 | 11512731.25 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9763990.63 |  9906731.25 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12360589.06 | 12258909.38 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22844481.82 | 17241285.71 |  1.32 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11741507.81 | 11646231.25 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11328671.88 | 11347196.88 |  1.00 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12344203.13 | 12257671.88 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 17600907.69 | 18238933.33 |  0.97 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18377395.83 | 17094117.86 |  1.08 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  9905007.81 | 13485106.66 |  0.73 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12662094.70 | 12466477.13 |  1.02 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 30850128.25 | 29143274.83 |  1.06 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20328860.58 | 20389754.92 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 12905515.63 | 15608043.75 |  0.83 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 12627481.25 | 15632700.00 |  0.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 12570662.50 | 15600466.67 |  0.81 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 24898440.00 | 23855860.00 |  1.04 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11431675.00 | 11071742.19 |  1.03 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 24254980.00 | 22884463.64 |  1.06 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16002107.00 | 15878440.19 |  1.01 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 14505075.29 | 14470697.53 |  1.00 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\w+", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  8845059.38 |  9297826.67 |  0.95 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6349729.17 |  6702356.76 |  0.95 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10970242.19 | 11372025.00 |  0.96 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15514875.00 | 15392744.44 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9192670.31 |  9867800.00 |  0.93 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9226071.88 |  9595165.38 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9997359.38 | 12071893.33 |  0.83 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15268953.33 | 15472162.50 |  0.99 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13155172.22 | 12789030.56 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9013013.19 |  9912728.36 |  0.91 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11437243.61 | 12155081.19 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 23044401.55 | 24224795.60 |  0.95 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16588306.08 | 17397560.05 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10407428.13 | 10717504.35 |  0.97 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12693172.22 | 13155057.69 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12967727.78 | 13511076.92 |  0.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16857545.45 | 16615210.00 |  1.01 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10259625.00 | 11168050.00 |  0.92 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20466700.00 | 20599637.50 |  0.99 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 15151839.17 | 17361891.33 |  0.87 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13346911.35 | 14478409.65 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Ctor(Pattern: "[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?", Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 3520.47 | 3707.18 |  0.95 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2418.07 | 2483.38 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3572.10 | 3664.91 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 5074.36 | 9833.95 |  0.52 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3127.50 | 3159.87 |  0.99 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2984.29 | 3098.68 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3241.70 | 3339.12 |  0.97 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4440.88 | 4395.79 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4979.89 | 4086.39 |  1.22 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 3066.77 | 3433.55 |  0.89 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3801.14 | 3838.98 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 9267.10 | 9831.05 |  0.94 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6577.98 | 6962.36 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3853.57 | 4006.69 |  0.96 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 4125.70 | 5029.72 |  0.82 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4250.45 | 4725.41 |  0.90 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5644.81 | 5666.22 |  1.00 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3589.14 | 3826.80 |  0.94 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6641.66 | 7243.64 |  0.92 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5075.00 | 5246.71 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4390.99 | 4696.02 |  0.94 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsNotMatch(Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 338.87 | 327.80 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 211.03 | 209.66 |  1.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 387.55 | 378.11 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 538.94 | 566.59 |  0.95 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 332.38 | 335.66 |  0.99 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 410.27 | 372.17 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 356.92 | 349.89 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 540.16 | 491.84 |  1.10 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 541.25 | 466.52 |  1.16 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 216.00 | 211.47 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 391.43 | 369.41 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 742.67 | 730.21 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 587.63 | 562.13 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 358.41 | 335.58 |  1.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 361.63 | 325.67 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 357.65 | 335.26 |  1.07 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 534.45 | 516.38 |  1.04 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 352.76 | 407.10 |  0.87 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 744.56 | 727.51 |  1.02 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 490.42 | 467.23 |  1.05 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 446.98 | 420.80 |  1.06 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\p{Ll}", Options: None)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  40009275.00 |  40705800.00 |  0.98 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  28308928.57 |  27816057.14 |  1.02 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47302025.00 |  51835362.50 |  0.91 |          +0 | several?   | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  67970887.50 |  99811650.00 |  0.68 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  40149187.50 |  43006150.00 |  0.93 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  39194875.00 |  42419075.00 |  0.92 |          +0 |            | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42860287.50 |  47483025.00 |  0.90 |          +0 | several?   | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65261775.00 |  67818400.00 |  0.96 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  64240275.00 |  57358075.00 |  1.12 |          +0 | multimodal | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  37396638.67 |  43263339.25 |  0.86 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  51537000.88 |  52931472.38 |  0.97 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 102686228.00 | 108529987.25 |  0.95 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  73336448.13 |  75134050.50 |  0.98 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45402625.00 |  45229000.00 |  1.00 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50864312.50 |  54691150.00 |  0.93 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  52837475.00 |  55232725.00 |  0.96 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75165400.00 |  76985775.00 |  0.98 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45031537.50 |  49636250.00 |  0.91 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  89179550.00 |  97678450.00 |  0.91 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65998488.50 |  73638315.50 |  0.90 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58049701.38 |  62938651.00 |  0.92 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsMatch(Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 279.49 | 267.33 |  1.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 185.85 | 183.58 |  1.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 334.57 | 345.48 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 544.97 | 580.34 |  0.94 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 302.60 | 325.93 |  0.93 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 346.21 | 352.18 |  0.98 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 314.25 | 324.58 |  0.97 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 461.03 | 441.20 |  1.04 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 482.34 | 437.23 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 187.81 | 189.50 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 335.27 | 354.15 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 626.05 | 665.77 |  0.94 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 458.32 | 467.83 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Slower | 284.41 | 319.58 |  0.89 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 285.49 | 313.94 |  0.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 289.11 | 320.74 |  0.90 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 474.52 | 425.40 |  1.12 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 335.70 | 379.43 |  0.88 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 653.38 | 635.23 |  1.03 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 415.87 | 455.63 |  0.91 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 380.85 | 404.38 |  0.94 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 10, Options: Compiled)

| Result |  Base |  Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----:| -----:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 33.53 | 45.13 |  0.74 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 25.69 | 25.95 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 48.06 | 45.91 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 85.51 | 87.01 |  0.98 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 40.82 | 41.15 |  0.99 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43.35 | 46.85 |  0.93 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43.29 | 44.89 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 61.51 | 59.91 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 52.44 | 60.47 |  0.87 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 27.39 | 27.61 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 46.63 | 47.22 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 94.43 | 95.56 |  0.99 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 67.46 | 68.54 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 41.72 | 40.54 |  1.03 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 41.79 | 40.14 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 41.38 | 40.57 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 72.50 | 71.88 |  1.01 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 51.00 | 49.60 |  1.03 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 92.65 | 93.35 |  0.99 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 60.44 | 55.82 |  1.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 53.53 | 52.74 |  1.01 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes|Watson", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 118011.56 | 117665.72 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77834.64 |  79131.50 |  0.98 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 147983.76 | 153246.49 |  0.97 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 228708.06 | 295431.96 |  0.77 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 139505.37 | 138185.56 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 133957.48 | 140092.51 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 147388.00 | 150749.46 |  0.98 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 197518.79 | 227307.99 |  0.87 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 188253.31 | 199056.25 |  0.95 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  99684.85 |  99003.99 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 163302.84 | 157700.29 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 369913.70 | 357417.97 |  1.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 256262.25 | 254566.60 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 151093.60 | 149367.86 |  1.01 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 187157.87 | 181093.32 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 162701.50 | 164937.20 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 359124.72 | 356986.51 |  1.01 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 163761.59 | 157179.72 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 813355.26 | 806725.49 |  1.01 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 213487.02 | 219844.96 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 196261.46 | 194209.57 |  1.01 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\w+\s+Holmes", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 3200557.50 | 3369295.00 |  0.95 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2502355.36 | 2738700.00 |  0.91 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4092985.94 | 3979524.22 |  1.03 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5712647.92 | 5869946.51 |  0.97 |          +0 | several?   | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3567905.63 | 3795036.25 |  0.94 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4231955.47 | 4318020.31 |  0.98 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4029534.38 | 3968490.63 |  1.02 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6088143.75 | 5576704.55 |  1.09 |          +0 | multimodal | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4906085.42 | 5454414.58 |  0.90 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2542344.57 | 2863785.17 |  0.89 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3994938.80 | 4327096.55 |  0.92 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 7391903.88 | 8081389.26 |  0.91 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5288198.54 | 5822319.61 |  0.91 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3606257.50 | 3877160.00 |  0.93 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3678031.25 | 3909601.56 |  0.94 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3604380.00 | 3907023.75 |  0.92 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5449030.21 | 5272666.67 |  1.03 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4309752.34 | 4641590.63 |  0.93 |          +0 | bimodal    | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6388818.75 | 6821367.71 |  0.94 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5061135.38 | 5548684.66 |  0.91 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4591237.30 | 4937166.04 |  0.93 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: ".*", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower | 2363939.29 | 2817944.38 |  0.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1640771.25 | 1903991.67 |  0.86 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3009995.00 | 3110438.13 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 8121520.31 | 6201860.94 |  1.31 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2485813.54 | 2734762.50 |  0.91 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2477851.04 | 2726497.50 |  0.91 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2715527.60 | 2895508.75 |  0.94 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3690121.09 | 3929832.81 |  0.94 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5289026.56 | 3803600.00 |  1.39 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2378936.92 | 2674935.67 |  0.89 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3790295.97 | 3693126.97 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6599783.61 | 6898371.02 |  0.96 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4416822.66 | 4679968.24 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2889378.75 | 3035775.63 |  0.95 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3414576.25 | 3668490.63 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3380742.50 | 3663196.88 |  0.92 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4682272.92 | 4916716.67 |  0.95 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2715595.31 | 2910885.00 |  0.93 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5653691.67 | 6083092.71 |  0.93 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4081965.55 | 4408355.41 |  0.93 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3661569.51 | 3977580.08 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\p{L}", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 29162316.67 | 29883607.14 |  0.98 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20969770.00 | 19431663.64 |  1.08 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 36268900.00 | 34404566.67 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 51929637.50 | 69768750.00 |  0.74 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 31318275.00 | 29325887.50 |  1.07 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 31065971.43 | 28879156.25 |  1.08 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 32655314.29 | 31100000.00 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 49835600.00 | 48305150.00 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43294800.00 | 43081650.00 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 32108658.86 | 33057937.14 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 41195700.17 | 38600914.67 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 81486693.75 | 79190635.25 |  1.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 59157434.00 | 56924071.00 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 35371908.33 | 34066314.29 |  1.04 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 44028350.00 | 43494800.00 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 44536475.00 | 44033450.00 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 59127825.00 | 55765350.00 |  1.06 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 34487416.67 | 32219478.57 |  1.07 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 72081650.00 | 68912625.00 |  1.05 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 51327770.25 | 53036541.38 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 46186381.88 | 45482240.00 |  1.02 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\p{Lu}", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 1405245.63 | 1523305.63 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1062145.00 | 1002358.20 |  1.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1654774.31 | 1605878.13 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 2421711.98 | 3144156.25 |  0.77 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1468493.75 | 1417293.18 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1408610.42 | 1378000.00 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1532275.57 | 1496440.34 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2346191.52 | 2345479.02 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1973909.38 | 1968678.52 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1465227.99 | 1588573.46 |  0.92 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1821553.51 | 1754212.13 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3770509.25 | 3906332.65 |  0.97 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2669387.88 | 2767666.58 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1661128.82 | 1683653.13 |  0.99 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2001371.09 | 2194246.48 |  0.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1987556.64 | 2001637.50 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2765850.63 | 2683717.71 |  1.03 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1531606.25 | 1462273.01 |  1.05 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3270196.88 | 3071963.54 |  1.06 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2404941.23 | 2506852.77 |  0.96 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2107829.82 | 2147842.49 |  0.98 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  89386.68 |  91286.01 |  0.98 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62202.06 |  62738.45 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 117720.30 | 116139.56 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 174590.70 | 224523.66 |  0.78 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  99970.86 |  96861.69 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 101851.54 |  97463.12 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 108367.19 | 105366.88 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 146615.22 | 162242.12 |  0.90 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 141328.89 | 137914.64 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77138.20 |  81388.35 |  0.95 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 126084.35 | 119511.27 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 268983.42 | 273341.40 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 204520.55 | 202896.96 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118260.60 | 110667.53 |  1.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 140246.32 | 140361.16 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 125823.85 | 125229.87 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 279986.16 | 278160.36 |  1.01 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 123009.89 | 119106.89 |  1.03 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 579583.05 | 571379.57 |  1.01 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 170890.14 | 171654.91 |  1.00 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 148120.98 | 150831.67 |  0.98 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Huck[a-zA-Z]+|Saw[a-zA-Z]+", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  2127885.94 |  2099466.07 |  1.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  1177676.79 |  1262138.84 |  0.93 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2797283.33 |  2683401.04 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  3542218.13 |  4502328.13 |  0.79 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2241023.21 |  2168426.79 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2357005.36 |  2334475.89 |  1.01 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2427186.61 |  2367883.04 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  4240016.41 |  4200487.50 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  3933599.22 |  4014714.84 |  0.98 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  1267104.74 |  1301830.19 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2782157.01 |  2691200.59 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5309678.67 |  5214887.34 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  4140627.68 |  4157293.30 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2272491.96 |  2185771.43 |  1.04 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2681167.19 |  2686310.42 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2136207.81 |  2184886.61 |  0.98 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5422725.00 |  5382835.42 |  1.01 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2889138.02 |  2855846.88 |  1.01 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13074489.47 | 13033394.74 |  1.00 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  3105045.20 |  3011827.30 |  1.03 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  2841939.46 |  2797176.47 |  1.02 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\p{Ll}", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 26788450.00 | 28329785.71 |  0.95 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19877400.00 | 18490140.91 |  1.08 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 34618616.67 | 34194007.14 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 49401075.00 | 62024150.00 |  0.80 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 29707525.00 | 28966312.50 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 28289237.50 | 27529868.75 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 30815350.00 | 30100692.86 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 46784575.00 | 47803587.50 |  0.98 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 39619666.67 | 39369933.33 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 32076422.57 | 32035868.36 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 37260034.17 | 36992988.75 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 77423766.75 | 76684617.50 |  1.01 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 54959656.38 | 53304255.00 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 33923841.67 | 36923985.71 |  0.92 |          +0 | several? | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 41800816.67 | 41369591.67 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43179687.50 | 41439783.33 |  1.04 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 56674350.00 | 54078575.00 |  1.05 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 31926264.29 | 31640385.71 |  1.01 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 66932425.00 | 65749650.00 |  1.02 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 48723039.00 | 51796239.63 |  0.94 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43543564.50 | 43856341.50 |  0.99 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch_Multithreading(total: 400000, unique: 7, cacheSize: 15)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  71893325.00 |  71800862.50 |  1.00 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  26057100.00 |  27324168.75 |  0.95 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55055137.50 |  53413962.50 |  1.03 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 104280775.00 | 159059800.00 |  0.66 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48385550.00 |  47379425.00 |  1.02 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42878600.00 |  40519450.00 |  1.06 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47699762.50 |  44600575.00 |  1.07 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76966787.50 |  71606037.50 |  1.07 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  99492775.00 |  70218975.00 |  1.42 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  29870064.19 |  27139238.63 |  1.10 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60338522.25 |  54361981.50 |  1.11 |          +0 | bimodal    | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 120256221.50 | 123715139.25 |  0.97 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  67818251.00 |  60514435.88 |  1.12 |          +0 | bimodal    | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  41536308.33 |  41078137.50 |  1.01 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  43448937.50 |  43561900.00 |  1.00 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  44544900.00 |  42690600.00 |  1.04 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  67143550.00 |  67628400.00 |  0.99 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66036925.00 |  62211100.00 |  1.06 |          +0 | bimodal    | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 108577950.00 |  96705425.00 |  1.12 |          +0 | multimodal | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  74706232.13 |  78061761.50 |  0.96 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65185855.50 |  65515652.25 |  0.99 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesBoundary(Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 111694.24 | 121643.31 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  86635.43 |  82003.17 |  1.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 140886.54 | 148900.65 |  0.95 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 211873.40 | 219611.79 |  0.96 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 124284.02 | 127818.28 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 152305.78 | 139009.02 |  1.10 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 132211.63 | 134038.05 |  0.99 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 199779.21 | 179607.39 |  1.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 215098.42 | 181015.19 |  1.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  87353.11 |  91595.76 |  0.95 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 136652.31 | 136997.80 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 287112.91 | 293728.12 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 210513.66 | 215081.31 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121477.20 | 124623.01 |  0.97 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 122955.96 | 123729.46 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 123474.21 | 126752.60 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 198427.41 | 173631.94 |  1.14 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower | 129319.86 | 151701.97 |  0.85 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 260729.40 | 257666.91 |  1.01 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 176099.73 | 193553.10 |  0.91 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 158988.17 | 164862.34 |  0.96 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch(total: 40000, unique: 1600, cacheSize: 800)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  73748625.00 |  74666700.00 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50340750.00 |  51132125.00 |  0.98 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  80088525.00 |  85842062.50 |  0.93 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142340500.00 | 126588650.00 |  1.12 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  81950900.00 |  82615687.50 |  0.99 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  84158225.00 |  78913575.00 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  73615750.00 |  76291862.50 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 140170600.00 | 133688600.00 |  1.05 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 139128750.00 | 118786950.00 |  1.17 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  68558459.50 |  68360170.00 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  87840922.00 |  88557548.50 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 202991134.00 | 198727801.00 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 149118931.00 | 148886450.00 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  88115600.00 |  90071400.00 |  0.98 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  96678250.00 | 100529850.00 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  95587300.00 | 100742000.00 |  0.95 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 130923800.00 | 124442800.00 |  1.05 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 179882600.00 | 176012900.00 |  1.02 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 165055200.00 | 171667100.00 |  0.96 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 177872167.00 | 150061134.00 |  1.19 |          +0 | bimodal  | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116693638.50 | 113661315.00 |  1.03 |          +0 | several? | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sher[a-z]+|Hol[a-z]+", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  88583.48 |  96154.82 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65676.91 |  64328.49 |  1.02 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 117779.84 | 121877.76 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 179437.96 | 169197.72 |  1.06 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 102619.74 | 101106.90 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 105286.82 | 101047.81 |  1.04 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121240.47 | 110388.05 |  1.10 |          +0 | several? | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 155571.23 | 169555.98 |  0.92 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142121.90 | 144158.18 |  0.99 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  82578.28 |  85532.08 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 130690.36 | 125651.79 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 278590.22 | 286867.13 |  0.97 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 208608.47 | 213214.95 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118591.68 | 115120.71 |  1.03 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 145163.08 | 149468.27 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 127951.54 | 128351.76 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 285935.34 | 284563.52 |  1.00 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 127953.78 | 129601.01 |  0.99 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 585883.29 | 581601.50 |  1.01 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 175811.08 | 181017.56 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 157011.30 | 157745.17 |  1.00 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 1, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  58.69 |  66.83 |  0.88 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |  44.74 |  50.72 |  0.88 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  82.17 |  80.66 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 142.88 | 108.27 |  1.32 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  68.84 |  69.25 |  0.99 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77.53 |  77.06 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75.21 |  78.42 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Slower | 102.84 | 120.30 |  0.85 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  91.36 | 102.33 |  0.89 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  46.83 |  52.53 |  0.89 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  86.31 |  83.59 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 181.02 | 185.86 |  0.97 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 124.64 | 118.61 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71.15 |  70.10 |  1.01 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71.55 |  71.48 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71.17 |  70.99 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 125.07 | 109.44 |  1.14 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  98.03 |  94.04 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 172.37 | 157.54 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 106.28 | 104.79 |  1.01 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  95.90 |  94.44 |  1.02 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\w+", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 15223107.14 | 14452580.77 |  1.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10393968.75 |  9301329.63 |  1.12 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 17909746.15 | 16628637.50 |  1.08 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 25582983.33 | 23700900.00 |  1.08 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15021514.29 | 14213807.14 |  1.06 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 14619093.33 | 14197861.54 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15744773.33 | 15287592.31 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 23887983.33 | 22771875.00 |  1.05 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20481785.00 | 20301830.00 |  1.01 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13141642.71 | 12970293.26 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18484573.08 | 17751389.09 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 33940943.83 | 33222962.42 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 25594095.19 | 24332435.31 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15972621.43 | 15948783.33 |  1.00 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18314358.33 | 18044609.09 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18452775.00 | 17863381.82 |  1.03 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 25951312.50 | 23961328.57 |  1.08 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16929007.69 | 16524391.67 |  1.02 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 34496783.33 | 34348950.00 |  1.00 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 24596830.60 | 24461521.00 |  1.01 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 21096664.27 | 20810020.22 |  1.01 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.CtorInvoke(Options: None)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  5955.37 |  5875.78 |  1.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  3823.03 |  3735.86 |  1.02 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5778.12 |  6289.91 |  0.92 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9001.62 |  8183.53 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5253.16 |  5248.44 |  1.00 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5422.85 |  5034.95 |  1.08 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5496.91 |  5419.47 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8248.41 |  7410.62 |  1.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9000.79 |  7630.56 |  1.18 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5107.29 |  5213.44 |  0.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6794.97 |  6403.91 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15662.47 | 15863.14 |  0.99 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10829.23 | 10829.66 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6650.42 |  6727.56 |  0.99 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7264.79 |  7801.28 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7259.13 |  7859.28 |  0.92 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9619.54 |  9739.72 |  0.99 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6248.38 |  5724.34 |  1.09 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11480.14 | 12595.45 |  0.91 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8625.32 |  8945.61 |  0.96 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7673.82 |  7836.24 |  0.98 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch(total: 40000, unique: 1600, cacheSize: 3200)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  9419954.55 |  9555305.00 |  0.99 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7940086.21 |  8205914.81 |  0.97 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13933350.00 | 14199946.67 |  0.98 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 24049788.89 | 22026866.67 |  1.09 |          +0 | several?   | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10554400.00 | 10707336.11 |  0.99 |          +0 | multimodal | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11913880.00 | 10756977.78 |  1.11 |          +0 |            | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11044340.00 | 10966009.09 |  1.01 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 21010030.00 | 17446950.00 |  1.20 |          +0 | several?   | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18103233.33 | 15316500.00 |  1.18 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8448290.61 |  7955750.67 |  1.06 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13522791.97 | 13712404.77 |  0.99 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 25207559.22 | 25059056.75 |  1.01 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16790424.54 | 17180355.09 |  0.98 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10683820.00 | 11206411.76 |  0.95 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10470830.43 | 11105929.55 |  0.94 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11057195.00 | 11359570.59 |  0.97 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16424191.67 | 15217127.27 |  1.08 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 21058890.00 | 23555920.00 |  0.89 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20567677.78 | 20778066.67 |  0.99 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19223408.83 | 19753944.79 |  0.97 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15287855.87 | 15790282.38 |  0.97 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch(total: 40000, unique: 1600, cacheSize: 15)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  98166400.00 | 101047600.00 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  68908775.00 |  70771050.00 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 103325150.00 | 111592450.00 |  0.93 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 157195350.00 | 158691600.00 |  0.99 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  94423950.00 |  91595700.00 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  93331050.00 |  85875875.00 |  1.09 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  94928600.00 |  97977200.00 |  0.97 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 155025450.00 | 145592600.00 |  1.06 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 162455850.00 | 134859000.00 |  1.20 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  96406867.50 |  96255674.25 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 112173786.50 | 116143142.00 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 262319692.00 | 268151195.00 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 191931465.50 | 204275983.00 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 109471950.00 | 108387900.00 |  1.01 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 117967650.00 | 130667300.00 |  0.90 |          +0 | several? | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 120844400.00 | 128317450.00 |  0.94 |          +0 | several? | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 165145300.00 | 165879700.00 |  1.00 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 189475500.00 | 187212150.00 |  1.01 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 208418700.00 | 226850100.00 |  0.92 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 147733394.00 | 159204842.50 |  0.93 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 132706172.00 | 135249648.00 |  0.98 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Email_IsMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 172.63 | 180.41 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 123.96 | 134.62 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 234.48 | 228.38 |  1.03 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 340.90 | 327.78 |  1.04 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 194.97 | 202.60 |  0.96 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 219.61 | 196.03 |  1.12 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 214.82 | 205.71 |  1.04 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 288.95 | 273.06 |  1.06 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 343.92 | 283.02 |  1.22 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 143.50 | 145.08 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 239.63 | 252.79 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 542.71 | 557.45 |  0.97 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 332.50 | 346.70 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 208.61 | 224.67 |  0.93 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 220.72 | 235.57 |  0.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 219.31 | 236.00 |  0.93 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 342.91 | 326.70 |  1.05 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 246.11 | 262.79 |  0.94 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 404.55 | 408.27 |  0.99 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 305.81 | 318.65 |  0.96 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 273.51 | 295.69 |  0.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 1, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 162.57 | 147.12 |  1.11 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 107.57 | 111.01 |  0.97 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 191.71 | 186.64 |  1.03 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 368.53 | 274.70 |  1.34 |          +0 | several?   | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 169.95 | 158.41 |  1.07 |          +0 | bimodal    | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 202.36 | 194.36 |  1.04 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 172.43 | 171.68 |  1.00 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 242.04 | 234.01 |  1.03 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 235.78 | 232.17 |  1.02 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 109.29 | 104.77 |  1.04 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 189.27 | 180.46 |  1.05 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 452.98 | 481.40 |  0.94 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 325.91 | 314.93 |  1.03 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 199.82 | 184.09 |  1.09 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 192.06 | 181.04 |  1.06 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 197.37 | 182.09 |  1.08 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 275.08 | 249.56 |  1.10 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 195.20 | 205.31 |  0.95 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 361.19 | 348.92 |  1.04 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 238.46 | 225.48 |  1.06 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 221.26 | 205.75 |  1.08 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: ".*", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 1991170.54 | 2061775.00 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1297799.28 | 1293408.85 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2183541.02 | 2303426.79 |  0.95 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4711815.63 | 4137170.31 |  1.14 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1909664.58 | 2015274.22 |  0.95 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1855931.60 | 1904971.88 |  0.97 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2037357.14 | 2063760.55 |  0.99 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2839934.90 | 2767951.88 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4461521.09 | 2639788.02 |  1.69 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2042218.01 | 2095360.22 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2486809.32 | 2526417.61 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5368626.42 | 5234186.88 |  1.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3593132.85 | 3597674.84 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2376550.45 | 2316606.25 |  1.03 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2900361.46 | 2856473.44 |  1.02 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2904062.50 | 2855119.79 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3774775.63 | 3646323.44 |  1.04 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2169551.79 | 2202887.95 |  0.98 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4684054.17 | 4611362.50 |  1.02 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3213182.31 | 3280731.13 |  0.98 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2907107.20 | 2966972.41 |  0.98 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Ctor(Options: None)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  5988.96 |  5785.70 |  1.04 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  3833.50 |  3738.75 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6173.86 |  6021.09 |  1.03 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9040.59 |  8038.84 |  1.12 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5338.26 |  5185.41 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5471.08 |  4861.65 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5443.73 |  5387.60 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8794.85 |  7192.13 |  1.22 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8996.72 |  7534.39 |  1.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5071.80 |  5050.20 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6524.60 |  6262.20 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15382.49 | 15313.55 |  1.00 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10689.68 | 10735.66 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6544.66 |  6671.43 |  0.98 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7275.93 |  7499.01 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7206.29 |  7735.41 |  0.93 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  9421.45 |  9677.22 |  0.97 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  6162.78 |  6050.08 |  1.02 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11604.30 | 10666.05 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8600.22 |  8766.26 |  0.98 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7616.37 |  7632.90 |  1.00 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Ctor(Options: Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 21962.32 | 22068.14 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15165.82 | 14666.77 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 25708.87 | 24573.14 |  1.05 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 42481.24 | 34816.34 |  1.22 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 22088.68 | 21049.94 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 22903.40 | 20143.86 |  1.14 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 23321.01 | 22367.86 |  1.04 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 32352.55 | 30159.36 |  1.07 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37421.99 | 30511.81 |  1.23 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 18516.91 | 19220.29 |  0.96 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 27780.81 | 26664.12 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 63178.52 | 63774.19 |  0.99 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43558.84 | 44197.14 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26686.82 | 26675.89 |  1.00 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 27876.05 | 29342.63 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 28680.76 | 29089.14 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 36376.93 | 36690.76 |  0.99 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26444.66 | 23770.17 |  1.11 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 47061.66 | 51150.25 |  0.92 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 37093.76 | 36624.45 |  1.01 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 33495.70 | 32542.20 |  1.03 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 9, Options: Compiled)

| Result |   Base |  Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| -----:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  33.47 | 45.51 |  0.74 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  25.47 | 25.43 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47.69 | 43.18 |  1.10 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  87.18 | 68.93 |  1.26 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.49 | 42.26 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47.72 | 45.94 |  1.04 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.92 | 43.27 |  0.99 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60.15 | 57.63 |  1.04 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  51.40 | 58.25 |  0.88 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  26.65 | 27.66 |  0.96 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.98 | 43.83 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 120.75 | 94.45 |  1.28 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66.70 | 67.13 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  40.97 | 40.09 |  1.02 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.07 | 39.56 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  40.94 | 40.79 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71.97 | 69.77 |  1.03 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50.62 | 49.50 |  1.02 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  94.36 | 90.35 |  1.04 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  59.47 | 55.26 |  1.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54.06 | 51.38 |  1.05 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?m)^Sherlock Holmes|Sherlock Holmes$", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  39949.36 |  38619.32 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  32579.27 |  31067.26 |  1.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62090.33 |  64182.36 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 166360.95 | 119758.41 |  1.39 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  51569.80 |  50649.98 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54047.97 |  52912.45 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  56260.75 |  58482.77 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  74292.49 |  77015.23 |  0.96 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100164.32 |  71416.79 |  1.40 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  34065.24 |  33206.50 |  1.03 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58951.90 |  59322.96 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 145288.45 | 143469.33 |  1.01 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 102387.60 | 101873.26 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54151.90 |  56886.41 |  0.95 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  67997.63 |  70210.62 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55687.09 |  57952.25 |  0.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 102193.79 |  99985.93 |  1.02 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  61957.24 |  61390.66 |  1.01 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 290758.41 | 272844.88 |  1.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76294.79 |  78066.69 |  0.98 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  70297.34 |  71225.17 |  0.99 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Ctor(Pattern: "[\w\.+-]+@[\w\.-]+\.[\w\.-]+", Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 2180.87 | 2199.07 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1462.61 | 1505.12 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2245.97 | 2131.71 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4941.16 | 2957.80 |  1.67 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1886.60 | 1856.08 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1785.45 | 1758.36 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1906.89 | 1879.56 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2677.36 | 2548.87 |  1.05 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3032.92 | 2425.61 |  1.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1988.97 | 2022.84 |  0.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2406.29 | 2291.74 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5726.34 | 5626.60 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4020.72 | 4051.85 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2262.39 | 2208.34 |  1.02 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2566.12 | 2713.09 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2616.60 | 2692.18 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3351.42 | 3199.05 |  1.05 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2283.33 | 2303.84 |  0.99 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4302.18 | 4029.05 |  1.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3248.50 | 3152.73 |  1.03 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2751.36 | 2749.76 |  1.00 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?s).*", Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 138.98 | 135.05 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  85.67 |  91.34 |  0.94 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 156.89 | 149.70 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 486.59 | 304.52 |  1.60 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 138.20 | 137.87 |  1.00 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 134.86 | 130.38 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142.37 | 141.06 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 192.52 | 196.72 |  0.98 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 280.58 | 181.00 |  1.55 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142.93 | 151.57 |  0.94 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 175.41 | 179.58 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 365.18 | 366.21 |  1.00 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 255.80 | 264.27 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 160.43 | 157.59 |  1.02 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 198.26 | 199.57 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 198.36 | 200.34 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 268.44 | 255.56 |  1.05 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 152.54 | 163.86 |  0.93 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 327.52 | 321.75 |  1.02 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 232.76 | 240.25 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 205.26 | 212.34 |  0.97 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch_Multithreading(total: 400000, unique: 1, cacheSize: 15)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  23097083.33 |  23243605.00 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Slower |   9283855.56 |  13474961.90 |  0.69 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  33787212.50 |  34018762.50 |  0.99 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  79012800.00 | 119324575.00 |  0.66 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42840975.00 |  40213975.00 |  1.07 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  38434658.33 |  34470608.33 |  1.11 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  41614758.33 |  38712100.00 |  1.07 |          +0 | several? | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66548250.00 |  64172650.00 |  1.04 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  75312275.00 |  63121612.50 |  1.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  14691418.32 |   9674986.58 |  1.52 |          +0 | bimodal  | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  40907780.75 |  35618023.13 |  1.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 102073795.88 |  93805047.00 |  1.09 |          +0 | several? | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57052434.75 |  52757461.00 |  1.08 |          +0 | several? | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  41733583.33 |  36689300.00 |  1.14 |          +0 | bimodal  | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  40270062.50 |  38686883.33 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  40031841.67 |  39890600.00 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  69576175.00 |  64799900.00 |  1.07 |          +0 | bimodal  | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48104225.00 |  48226387.50 |  1.00 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  64513050.00 |  62834200.00 |  1.03 |          +0 | several? | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57006319.88 |  61516042.50 |  0.93 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47803235.50 |  53254126.00 |  0.90 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Street", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  47523.65 |  41875.41 |  1.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  37713.66 |  34590.27 |  1.09 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  69627.33 |  65498.09 |  1.06 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143646.65 |  90827.92 |  1.58 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57965.06 |  51461.44 |  1.13 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  59483.52 |  52824.24 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  64868.04 |  58459.81 |  1.11 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  92678.03 |  84739.67 |  1.09 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  82687.55 |  71970.47 |  1.15 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42374.67 |  41346.57 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  70588.70 |  66210.15 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 163455.98 | 155608.78 |  1.05 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116764.07 | 109355.56 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63299.44 |  58166.49 |  1.09 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  80541.59 |  75776.00 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66790.17 |  61439.29 |  1.09 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116946.11 | 108079.41 |  1.08 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71738.07 |  64342.15 |  1.11 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 306717.40 | 292798.68 |  1.05 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  91893.65 |  86896.93 |  1.06 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  83015.08 |  77443.17 |  1.07 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsNotMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 176.53 | 189.51 |  0.93 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 120.26 | 117.50 |  1.02 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 210.30 | 205.79 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 295.29 | 407.47 |  0.72 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 175.54 | 171.96 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 203.31 | 193.46 |  1.05 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 190.25 | 194.03 |  0.98 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 252.68 | 256.14 |  0.99 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 289.40 | 258.22 |  1.12 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 155.25 | 160.78 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 230.18 | 213.57 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 512.58 | 462.56 |  1.11 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 320.12 | 306.75 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 221.01 | 207.11 |  1.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 255.11 | 242.33 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 268.90 | 256.20 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 347.28 | 310.44 |  1.12 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 222.28 | 212.74 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 371.31 | 351.17 |  1.06 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 281.55 | 271.31 |  1.04 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 247.80 | 237.33 |  1.04 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "[^\n]*", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 1949960.42 | 1944157.64 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1290912.50 | 1305120.83 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2062630.47 | 2076189.06 |  0.99 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4304556.25 | 3023222.50 |  1.42 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1936659.82 | 1901447.22 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1925163.89 | 1839290.63 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2055865.18 | 1985046.43 |  1.04 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3113473.75 | 3087365.63 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2704875.00 | 3081952.50 |  0.88 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1986883.06 | 2068893.23 |  0.96 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2492338.29 | 2500645.19 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5445542.48 | 5287076.00 |  1.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5171951.80 | 3680738.94 |  1.41 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2385548.66 | 2402897.32 |  0.99 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2870843.23 | 2878907.29 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2919745.63 | 2904829.17 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3771483.33 | 3664557.03 |  1.03 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2096342.86 | 2154620.09 |  0.97 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4734489.58 | 4516258.33 |  1.05 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3212659.28 | 3501458.34 |  0.92 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2811572.75 | 3017495.14 |  0.93 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "aei", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  667765.49 |  695434.94 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  541795.04 |  541008.41 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  846725.66 |  801143.91 |  1.06 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1167558.93 | 1072065.21 |  1.09 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  774169.64 |  755105.94 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  718328.27 |  736438.78 |  0.98 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  792352.50 |  822416.78 |  0.96 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1111914.58 | 1150278.57 |  0.97 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  982607.81 | 1004282.29 |  0.98 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  546031.53 |  558295.10 |  0.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  790534.03 |  821782.70 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1392026.71 | 1562304.44 |  0.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  994840.17 | 1043584.79 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  775312.80 |  823248.19 |  0.94 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  775529.46 |  817226.15 |  0.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  773854.17 |  830266.78 |  0.93 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1163168.30 |  999664.79 |  1.16 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Slower |  748504.17 |  856542.36 |  0.87 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1123384.38 |  856710.03 |  1.31 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1009647.26 | 1045095.88 |  0.97 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  911139.05 |  949488.76 |  0.96 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\p{Lu}", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 2231686.25 | 2292794.79 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1779193.06 | 1670192.01 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3085698.96 | 2968925.00 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 4408039.58 | 5261318.75 |  0.84 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2586296.25 | 2476697.40 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2562791.96 | 2527321.43 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2760592.71 | 2739110.00 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4127987.50 | 3855544.53 |  1.07 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3573010.94 | 3379209.38 |  1.06 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2154143.97 | 2177079.92 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3286834.13 | 3162929.46 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 6341739.27 | 6169016.79 |  1.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4780182.83 | 4741928.88 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2865755.00 | 2844662.50 |  1.01 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3150271.25 | 3168811.25 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3160627.50 | 3176296.25 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4295664.58 | 3955610.16 |  1.09 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3102436.25 | 3146178.75 |  0.99 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 5992120.83 | 5563283.33 |  1.08 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4838308.20 | 4259028.95 |  1.14 |          +0 | several? | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3770880.95 | 3717514.91 |  1.01 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Email_IsNotMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 259.12 | 282.80 |  0.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 180.11 | 173.62 |  1.04 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 330.91 | 342.72 |  0.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 484.46 | 462.82 |  1.05 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 287.78 | 283.96 |  1.01 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 330.84 | 277.66 |  1.19 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 303.97 | 290.78 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 407.77 | 395.94 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 453.51 | 395.45 |  1.15 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 213.03 | 195.41 |  1.09 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 340.22 | 353.03 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 874.02 | 665.92 |  1.31 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 609.96 | 468.71 |  1.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 324.16 | 338.14 |  0.96 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 343.24 | 325.82 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 346.23 | 330.21 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 477.43 | 430.28 |  1.11 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 344.09 | 363.23 |  0.95 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 546.52 | 537.35 |  1.02 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 427.25 | 452.18 |  0.94 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 401.13 | 408.27 |  0.98 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 11, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  96.66 | 100.79 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65.74 |  67.47 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 114.73 | 111.94 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 224.76 | 228.64 |  0.98 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 101.30 |  97.24 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 117.43 | 117.19 |  1.00 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 107.83 | 104.94 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 161.77 | 144.88 |  1.12 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 131.50 | 141.34 |  0.93 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  68.78 |  62.40 |  1.10 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 115.30 | 107.70 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 217.83 | 219.40 |  0.99 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 166.17 | 151.90 |  1.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 102.85 |  88.53 |  1.16 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  94.88 |  86.07 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100.63 |  86.43 |  1.16 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 163.82 | 145.54 |  1.13 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 109.89 | 112.47 |  0.98 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 238.07 | 224.30 |  1.06 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 147.15 | 138.77 |  1.06 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 130.99 | 125.79 |  1.04 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 11, Options: Compiled)

| Result |   Base |  Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| -----:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  36.60 | 42.52 |  0.86 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  26.89 | 26.76 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.36 | 46.29 |  1.00 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 110.34 | 87.21 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.66 | 44.83 |  0.95 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.08 | 49.90 |  0.90 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  44.53 | 45.95 |  0.97 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.67 | 61.25 |  1.04 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  56.74 | 61.95 |  0.92 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  27.90 | 28.77 |  0.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.07 | 45.30 |  1.02 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 102.76 | 98.38 |  1.04 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66.78 | 66.44 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.45 | 41.82 |  1.02 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.31 | 41.48 |  1.02 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42.16 | 41.68 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  75.24 | 67.53 |  1.11 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  57.70 | 47.16 |  1.22 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  98.91 | 92.16 |  1.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  59.14 | 57.51 |  1.03 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54.67 | 52.07 |  1.05 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?s).*", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1555285.00 | 1245470.67 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1213246.88 | 1100948.13 |  1.10 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1730316.25 | 1657307.14 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4814321.88 | 3083459.38 |  1.56 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1611235.00 | 1579432.03 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2001406.25 | 2004073.44 |  1.00 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2047531.25 | 2204006.25 |  0.93 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2931441.15 | 2936028.13 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3756520.83 | 2740615.63 |  1.37 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1104202.50 | 1131008.82 |  0.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1894192.73 | 1771199.32 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3598070.74 | 3624302.69 |  0.99 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2977219.66 | 2845439.15 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1740429.69 | 1586370.63 |  1.10 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1727796.88 | 1586826.88 |  1.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1734015.63 | 1586433.59 |  1.09 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2681518.75 | 2797638.75 |  0.96 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1713294.10 | 1903406.25 |  0.90 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 8102662.50 | 7196507.81 |  1.13 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2432304.99 | 2292303.10 |  1.06 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2174282.99 | 2119896.92 |  1.03 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice.Count(Options: Compiled)

| Result  |          Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------- | -------------:| -------------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster  | 4374268250.00 | 3507368100.00 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 3755052500.00 | 2785715700.00 |  1.35 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 5048249100.00 | 3944815200.00 |  1.28 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same    | 6831904400.00 | 6490856700.00 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4754168500.00 | 3689859500.00 |  1.29 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4774626000.00 | 3599239100.00 |  1.33 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 5099682300.00 | 3884012000.00 |  1.31 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 7229562700.00 | 4930193900.00 |  1.47 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 6608875150.00 | 5003343750.00 |  1.32 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 3600322186.00 | 2834485547.00 |  1.27 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 4729855932.00 | 3940479692.00 |  1.20 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 7722134623.50 | 6928967392.00 |  1.11 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 6015451303.00 | 4954309420.00 |  1.21 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4768638300.00 | 3956267250.00 |  1.21 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 4774839050.00 | 3848399050.00 |  1.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4753515200.00 | 3944029950.00 |  1.21 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 7039405500.00 | 4896214700.00 |  1.44 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same    | 4561542900.00 | 4290017900.00 |  1.06 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 7148284800.00 | 4952133250.00 |  1.44 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 6080712237.00 | 5032351657.00 |  1.21 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 5482966252.50 | 4589394584.00 |  1.19 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\w+\s+Holmes", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 12179518.75 | 10138325.00 |  1.20 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8563709.38 |  7527052.08 |  1.14 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13705671.88 | 12497673.33 |  1.10 |          +0 | bimodal    | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19963880.00 | 19947660.00 |  1.00 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12307040.00 | 11108679.69 |  1.11 |          +0 | several?   | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13890153.13 | 12972686.67 |  1.07 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13240447.06 | 11846629.69 |  1.12 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20134086.36 | 17202263.64 |  1.17 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16140723.33 | 14939191.67 |  1.08 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8386426.47 |  8025050.52 |  1.05 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13423112.83 | 11971126.93 |  1.12 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26557578.88 | 26839979.00 |  0.99 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19441815.45 | 19633041.72 |  0.99 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11763685.94 | 11076357.81 |  1.06 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12152096.88 | 11105898.44 |  1.09 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12611470.31 | 11159059.38 |  1.13 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19012736.36 | 15772080.00 |  1.21 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13135860.94 | 13851570.00 |  0.95 |          +0 | bimodal    | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 30162207.14 | 27659214.29 |  1.09 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16434283.57 | 15780461.06 |  1.04 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15108841.40 | 13790431.04 |  1.10 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch(total: 400000, unique: 1, cacheSize: 15)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  41419475.00 |  38498875.00 |  1.08 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  28906962.50 |  25640035.71 |  1.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47724687.50 |  46737100.00 |  1.02 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  73708462.50 |  68187400.00 |  1.08 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  43187050.00 |  41310700.00 |  1.05 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47333050.00 |  42550625.00 |  1.11 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  43818362.50 |  42453575.00 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65593837.50 |  58691775.00 |  1.12 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  75458625.00 |  57768912.50 |  1.31 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  31643201.29 |  27003209.33 |  1.17 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48936863.25 |  45953597.50 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 101511903.50 | 102328545.50 |  0.99 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76138993.00 |  71801838.00 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  47202512.50 |  41336787.50 |  1.14 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  42624925.00 |  39114300.00 |  1.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  43735825.00 |  40287950.00 |  1.09 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  72643825.00 |  60964575.00 |  1.19 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55062875.00 |  50115812.50 |  1.10 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  88632462.50 |  81042250.00 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  61799907.00 |  57995438.25 |  1.07 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55593438.75 |  53437077.50 |  1.04 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch_Multithreading(total: 40000, unique: 1600, cacheSize: 800)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  66138875.00 |  63084050.00 |  1.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  26302214.29 |  26931287.50 |  0.98 |          +0 | bimodal  | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48805200.00 |  46200912.50 |  1.06 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 113233600.00 |  96710400.00 |  1.17 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55030525.00 |  49298350.00 |  1.12 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  52361050.00 |  53169362.50 |  0.98 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  50077487.50 |  42860550.00 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  99629650.00 |  75172600.00 |  1.33 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118292800.00 | 157655887.50 |  0.75 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  34187276.50 |  30221535.29 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  70615419.00 |  58116485.50 |  1.22 |          +0 | bimodal  | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116599878.00 | 107566277.00 |  1.08 |          +0 | several? | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  91386862.50 |  74293065.50 |  1.23 |          +0 | several? | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  52943575.00 |  46316650.00 |  1.14 |          +0 | bimodal  | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53431175.00 |  50073800.00 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53013300.00 |  49714100.00 |  1.07 |          +0 | several? | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  74655087.50 |  66583900.00 |  1.12 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 156920000.00 | 151836500.00 |  1.03 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  96212250.00 |  80581825.00 |  1.19 |          +0 | bimodal  | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118708827.50 | 133246306.00 |  0.89 |          +0 | several? | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  85652083.00 |  88307137.50 |  0.97 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch(total: 400000, unique: 7, cacheSize: 15)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  53097225.00 |  49585975.00 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  35014400.00 |  34243212.50 |  1.02 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60297725.00 |  57583525.00 |  1.05 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  87852350.00 |  88295050.00 |  0.99 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  54545975.00 |  52822525.00 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  61052300.00 |  55618362.50 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55322800.00 |  53470250.00 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  81259375.00 |  74881600.00 |  1.09 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  87201000.00 |  72205600.00 |  1.21 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  40475106.50 |  35946892.00 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62973127.00 |  58132355.25 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 125013616.00 | 124783078.00 |  1.00 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  93858759.00 |  88079886.88 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  59053475.00 |  53156412.50 |  1.11 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  60425062.50 |  53800675.00 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  60245825.00 |  53628775.00 |  1.12 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  86993300.00 |  77785487.50 |  1.12 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75031025.00 |  75758737.50 |  0.99 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 130939300.00 | 121542600.00 |  1.08 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  79840038.00 |  74198150.63 |  1.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  72721141.00 |  66512305.25 |  1.09 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\w+\s+Holmes\s+\w+", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 11694606.25 | 11045671.88 |  1.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8460256.25 |  7265135.42 |  1.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13670059.38 | 12302293.33 |  1.11 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19453722.73 | 19465590.00 |  1.00 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12079053.13 | 10839333.33 |  1.11 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13715293.75 | 13669400.00 |  1.00 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13030868.75 | 11741212.50 |  1.11 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20352666.67 | 17287086.36 |  1.18 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16280903.85 | 15160938.46 |  1.07 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8404244.70 |  7791987.53 |  1.08 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12995598.42 | 12083431.47 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 26529065.88 | 27090711.71 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19652664.27 | 19941361.00 |  0.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12221278.13 | 11127028.13 |  1.10 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12440623.44 | 11148371.88 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 11761554.69 | 10962060.00 |  1.07 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19156295.45 | 15773160.00 |  1.21 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13163479.69 | 13616573.33 |  0.97 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30253335.71 | 27022914.29 |  1.12 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16424319.29 | 15419713.42 |  1.07 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15311124.73 | 13969067.79 |  1.10 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 6, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  42.47 |  37.16 |  1.14 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  29.93 |  27.12 |  1.10 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53.42 |  52.41 |  1.02 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  82.40 |  72.58 |  1.14 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48.09 |  43.66 |  1.10 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55.77 |  51.22 |  1.09 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50.87 |  47.39 |  1.07 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  75.75 |  66.80 |  1.13 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.16 |  66.52 |  0.95 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  29.88 |  27.83 |  1.07 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  55.82 |  48.41 |  1.15 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 113.21 | 108.03 |  1.05 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76.14 |  72.11 |  1.06 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.24 |  43.52 |  1.06 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.47 |  43.43 |  1.07 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.56 |  43.26 |  1.08 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  84.80 |  72.28 |  1.17 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60.39 |  53.86 |  1.12 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 113.60 |  99.74 |  1.14 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  65.94 |  60.36 |  1.09 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  61.22 |  55.94 |  1.09 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice.Count(Options: None)

| Result  |          Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------- | -------------:| -------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Unknown | 5248929200.00 | 3532296800.00 |  1.49 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 3266983300.00 | 2881254300.00 |  1.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 5517037400.00 | 4056277550.00 |  1.36 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 7743408050.00 | 5355405950.00 |  1.45 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4733738250.00 | 3743840100.00 |  1.26 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4344074200.00 | 3635006200.00 |  1.20 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 4687150550.00 | 3912502500.00 |  1.20 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 6607610900.00 | 5584181000.00 |  1.18 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 5978341300.00 | 4959888400.00 |  1.21 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 3121241673.00 | 2847462936.00 |  1.10 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 5289730018.00 | 3971707876.00 |  1.33 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 7943449271.00 | 6962540385.00 |  1.14 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 6729772726.00 | 4985000874.00 |  1.35 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 4722564800.00 | 3972782550.00 |  1.19 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 4727858100.00 | 3811619450.00 |  1.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 4725540600.00 | 3964349450.00 |  1.19 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 7986074000.00 | 4907535200.00 |  1.63 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 5020706200.00 | 4376254900.00 |  1.15 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 9105084000.00 | 4675142850.00 |  1.95 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 7190321930.00 | 5046567347.00 |  1.42 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 6134313342.00 | 4651274337.00 |  1.32 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Slower |  52.58 |  58.65 |  0.90 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  38.74 |  35.23 |  1.10 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  69.91 |  62.70 |  1.11 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 101.79 | 116.66 |  0.87 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60.82 |  54.53 |  1.12 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  69.58 |  63.14 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  64.26 |  59.86 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  91.42 |  82.28 |  1.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96.55 |  81.20 |  1.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.10 |  42.56 |  1.06 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  73.36 |  68.39 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 148.82 | 142.33 |  1.05 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 107.66 | 103.94 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  70.12 |  63.37 |  1.11 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  69.62 |  63.31 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  71.83 |  63.40 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 101.22 |  93.86 |  1.08 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76.36 |  71.34 |  1.07 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 135.72 | 116.89 |  1.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  95.91 |  87.21 |  1.10 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  86.69 |  76.34 |  1.14 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 13, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  44.98 |  43.16 |  1.04 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  30.37 |  32.31 |  0.94 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50.46 |  52.33 |  0.96 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  93.62 |  89.62 |  1.04 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49.00 |  45.31 |  1.08 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  51.32 |  53.68 |  0.96 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50.42 |  49.24 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  73.36 |  66.51 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.21 |  62.50 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  32.05 |  31.50 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53.76 |  49.57 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 115.13 | 107.93 |  1.07 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  80.27 |  74.96 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48.61 |  45.58 |  1.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50.28 |  45.58 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49.20 |  45.59 |  1.08 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  86.49 |  74.26 |  1.16 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  66.41 |  55.01 |  1.21 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114.04 |  96.84 |  1.18 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  68.08 |  63.18 |  1.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62.83 |  58.00 |  1.08 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesBoundary(Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  50160.06 |  48341.56 |  1.04 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  35210.07 |  32854.81 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62502.37 |  56801.11 |  1.10 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 118608.93 |  76733.13 |  1.55 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  57745.49 |  50904.58 |  1.13 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63245.99 |  57152.28 |  1.11 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58903.44 |  58226.40 |  1.01 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  81162.88 |  80457.82 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  89161.57 |  76044.52 |  1.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  38762.84 |  37114.51 |  1.04 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  66032.18 |  61039.44 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138896.45 | 123963.91 |  1.12 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  93409.12 |  81331.42 |  1.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  61373.40 |  55142.30 |  1.11 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  65574.38 |  55552.69 |  1.18 |          +0 | bimodal  | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  63408.58 |  56376.47 |  1.12 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90704.70 |  73713.83 |  1.23 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63317.10 |  58386.29 |  1.08 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 108302.43 | 100919.69 |  1.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  83280.71 |  74892.66 |  1.11 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76038.33 |  71068.14 |  1.07 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch_Multithreading(total: 40000, unique: 1600, cacheSize: 3200)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  7186714.29 |  7976727.59 |  0.90 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  3096991.88 |  3435970.63 |  0.90 |          +0 | several? | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5506363.04 |  5624777.50 |  0.98 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 11613722.22 | 17737740.91 |  0.65 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5255825.56 |  4478998.21 |  1.17 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6203743.02 |  4228376.85 |  1.47 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  4870833.70 |  4908492.00 |  0.99 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11154943.48 |  6944152.00 |  1.61 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12632536.11 |  6816852.78 |  1.85 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3630494.79 |  3113626.39 |  1.17 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8218546.19 |  6106485.02 |  1.35 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 13347677.29 | 13572984.71 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8087496.50 |  6534002.03 |  1.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5172138.00 |  4299317.24 |  1.20 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5374237.21 |  4283245.69 |  1.25 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5373329.07 |  4356879.79 |  1.23 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  5910688.10 |  5835876.47 |  1.01 |          +0 | bimodal  | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 14271877.78 | 13745708.82 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7477350.00 |  7788914.29 |  0.96 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  8475676.92 |  9428477.16 |  0.90 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7932325.35 |  8111415.43 |  0.98 |          +0 | several? | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch(total: 40000, unique: 7, cacheSize: 0)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  51257612.50 |  46218475.00 |  1.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  33754362.50 |  33004425.00 |  1.02 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  49624525.00 |  43838500.00 |  1.13 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  70856175.00 |  62203125.00 |  1.14 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  44658350.00 |  38739700.00 |  1.15 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  43530962.50 |  37749700.00 |  1.15 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  43504325.00 |  40367150.00 |  1.08 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  69380237.50 |  60614762.50 |  1.14 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  76050150.00 |  57413787.50 |  1.32 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50919959.50 |  48033983.75 |  1.06 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53052327.00 |  50900400.50 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 125122779.50 | 116264236.00 |  1.08 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  89986441.50 |  89085856.00 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49090912.50 |  44847650.00 |  1.09 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58568625.00 |  55060225.00 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  58813475.00 |  56439500.00 |  1.04 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  78978750.00 |  73427850.00 |  1.08 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  48861500.00 |  43323025.00 |  1.13 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  93157350.00 |  93180700.00 |  1.00 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  72504208.00 |  71291657.63 |  1.02 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  71329155.25 |  61373303.50 |  1.16 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 13, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 107.33 | 110.14 |  0.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76.93 |  74.37 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 136.87 | 127.25 |  1.08 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 244.77 | 198.44 |  1.23 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118.66 | 109.02 |  1.09 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 138.41 | 134.01 |  1.03 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 129.72 | 123.52 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 186.12 | 171.23 |  1.09 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 154.63 | 164.26 |  0.94 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  78.28 |  71.89 |  1.09 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 132.93 | 120.52 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 276.95 | 244.53 |  1.13 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 218.27 | 197.45 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 117.59 | 104.70 |  1.12 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 111.36 | 103.12 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 116.58 | 100.54 |  1.16 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 196.48 | 164.72 |  1.19 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 131.48 | 126.09 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 275.10 | 256.60 |  1.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 172.97 | 153.81 |  1.12 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 152.08 | 142.67 |  1.07 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 12, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  51.14 |  49.60 |  1.03 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  30.72 |  31.88 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53.01 |  52.46 |  1.01 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 118.99 |  96.95 |  1.23 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47.65 |  45.31 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  52.33 |  51.51 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50.55 |  49.61 |  1.02 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  72.67 |  66.36 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.39 |  66.86 |  0.95 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  31.78 |  31.75 |  1.00 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  57.33 |  49.24 |  1.16 |          +0 | several? | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 115.12 | 106.53 |  1.08 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  78.17 |  74.50 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48.46 |  45.64 |  1.06 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48.45 |  49.97 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  48.25 |  46.07 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  86.26 |  74.37 |  1.16 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  66.28 |  55.52 |  1.19 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 113.16 |  99.09 |  1.14 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  67.92 |  63.15 |  1.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62.56 |  58.81 |  1.06 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 7, Options: Compiled)

| Result |   Base |  Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| -----:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  39.77 | 37.12 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  28.66 | 27.40 |  1.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  53.42 | 51.82 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77.36 | 71.15 |  1.09 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  46.48 | 43.02 |  1.08 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55.98 | 51.41 |  1.09 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49.82 | 46.68 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71.92 | 64.84 |  1.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62.82 | 63.13 |  1.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  28.55 | 27.32 |  1.04 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  55.54 | 46.71 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 109.52 | 97.49 |  1.12 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  71.95 | 68.76 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.39 | 42.53 |  1.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.11 | 42.49 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  44.69 | 42.46 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  82.39 | 72.40 |  1.14 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  58.92 | 52.56 |  1.12 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 113.35 | 99.28 |  1.14 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.42 | 59.46 |  1.07 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  59.66 | 55.39 |  1.08 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 12, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 106.80 | 113.12 |  0.94 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77.11 |  71.53 |  1.08 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 136.97 | 128.30 |  1.07 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 252.57 | 251.32 |  1.00 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 117.15 | 104.30 |  1.12 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 133.51 | 129.78 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 129.24 | 121.78 |  1.06 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 185.27 | 167.18 |  1.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 157.37 | 164.36 |  0.96 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  78.64 |  71.98 |  1.09 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 133.34 | 120.22 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 275.52 | 243.95 |  1.13 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 219.38 | 197.75 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 117.98 | 100.07 |  1.18 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 111.71 |  99.23 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 116.28 | 103.47 |  1.12 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 196.89 | 164.00 |  1.20 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 132.46 | 125.89 |  1.05 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 265.10 | 256.63 |  1.03 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 172.67 | 154.39 |  1.12 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 152.18 | 140.17 |  1.09 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 8, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  40.36 |  37.87 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  28.87 |  27.23 |  1.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  51.98 |  52.01 |  1.00 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  78.39 |  71.14 |  1.10 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  47.24 |  44.14 |  1.07 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55.08 |  49.87 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  49.68 |  47.06 |  1.06 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  73.42 |  65.19 |  1.13 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  60.38 |  63.59 |  0.95 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  28.71 |  27.49 |  1.04 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  54.73 |  46.61 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 109.47 | 100.85 |  1.09 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  72.28 |  70.37 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.00 |  42.80 |  1.05 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  45.10 |  42.82 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  44.90 |  42.59 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  82.08 |  73.20 |  1.12 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  55.98 |  53.11 |  1.05 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114.55 | 100.49 |  1.14 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  63.75 |  59.33 |  1.07 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  63.78 |  54.89 |  1.16 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Email_IsNotMatch(Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  519.23 |  519.25 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  367.11 |  323.07 |  1.14 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  659.94 |  610.37 |  1.08 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1274.96 | 1203.32 |  1.06 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  597.40 |  530.37 |  1.13 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  726.88 |  645.46 |  1.13 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  617.08 |  589.51 |  1.05 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  902.73 |  818.33 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  948.58 |  800.84 |  1.18 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  380.64 |  333.59 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  639.85 |  595.00 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1739.06 | 1630.68 |  1.07 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1221.87 | 1084.38 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  689.54 |  596.88 |  1.16 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  688.76 |  594.78 |  1.16 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  680.13 |  601.06 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  967.39 |  729.56 |  1.33 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  606.27 |  602.70 |  1.01 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1306.11 | 1155.81 |  1.13 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  826.62 |  774.42 |  1.07 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  746.00 |  697.08 |  1.07 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 3, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 126.45 | 117.15 |  1.08 |          +0 | bimodal  | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90.86 |  79.95 |  1.14 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 163.13 | 157.41 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 226.47 | 294.32 |  0.77 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 134.08 | 129.25 |  1.04 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164.13 | 132.40 |  1.24 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 153.96 | 138.31 |  1.11 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 206.53 | 188.15 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 194.36 | 187.32 |  1.04 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  98.76 |  93.12 |  1.06 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 164.99 | 157.36 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 346.31 | 329.02 |  1.05 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 232.01 | 222.33 |  1.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 140.97 | 140.42 |  1.00 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 141.41 | 135.12 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 138.90 | 137.81 |  1.01 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 249.87 | 198.27 |  1.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 191.93 | 171.28 |  1.12 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 327.64 | 264.15 |  1.24 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 214.28 | 204.14 |  1.05 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 205.64 | 181.33 |  1.13 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsNotMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 108.70 | 101.36 |  1.07 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76.41 |  70.31 |  1.09 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 132.02 | 116.39 |  1.13 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 184.31 | 227.25 |  0.81 |          +0 | multimodal | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118.06 | 107.68 |  1.10 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 136.54 | 121.78 |  1.12 |          +0 |            | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 123.21 | 111.22 |  1.11 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 178.92 | 149.46 |  1.20 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 186.03 | 151.34 |  1.23 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  90.39 |  83.13 |  1.09 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 144.23 | 125.46 |  1.15 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 311.42 | 272.37 |  1.14 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 208.50 | 193.81 |  1.08 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 145.03 | 130.13 |  1.11 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143.66 | 122.87 |  1.17 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143.98 | 121.78 |  1.18 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 189.31 | 171.37 |  1.10 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 141.66 | 124.96 |  1.13 |          +0 | bimodal    | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 244.69 | 203.85 |  1.20 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 200.69 | 161.50 |  1.24 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 160.77 | 145.41 |  1.11 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 5, Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  322.38 |  306.02 |  1.05 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  238.86 |  225.59 |  1.06 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  409.90 |  362.79 |  1.13 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  576.61 |  782.19 |  0.74 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  363.49 |  310.95 |  1.17 |          +0 | several?   | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  439.59 |  423.78 |  1.04 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  378.10 |  341.50 |  1.11 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  526.74 |  478.78 |  1.10 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  460.30 |  469.59 |  0.98 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  241.45 |  212.69 |  1.14 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  425.16 |  366.29 |  1.16 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1111.47 | 1062.24 |  1.05 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  719.11 |  752.50 |  0.96 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  434.38 |  384.54 |  1.13 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  429.48 |  380.48 |  1.13 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  427.14 |  385.93 |  1.11 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  596.84 |  487.63 |  1.22 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  395.57 |  382.04 |  1.04 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  806.50 |  729.58 |  1.11 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  533.85 |  466.95 |  1.14 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  483.57 |  424.87 |  1.14 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "the\s+\w+", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1595870.63 | 1363796.35 |  1.17 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1189355.05 |  997418.55 |  1.19 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1801637.15 | 1545437.50 |  1.17 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2548845.83 | 2138200.39 |  1.19 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1672396.56 | 1394311.98 |  1.20 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1601244.38 | 1395921.25 |  1.15 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1753474.31 | 1499889.77 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2571501.04 | 2170596.88 |  1.18 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2243441.07 | 1961316.07 |  1.14 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1365439.52 | 1206920.96 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1815369.67 | 1654623.53 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3030157.61 | 2894982.66 |  1.05 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2459809.05 | 2193876.71 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1750234.03 | 1562709.03 |  1.12 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1861651.39 | 1673442.50 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1865620.83 | 1701699.69 |  1.10 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2552859.38 | 2088318.30 |  1.22 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1721572.57 | 1667533.13 |  1.03 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2657484.90 | 2134396.88 |  1.25 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2374208.96 | 2278494.97 |  1.04 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2116591.40 | 1964626.86 |  1.08 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  67.71 |  70.21 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  47.80 |  40.38 |  1.18 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  83.34 |  74.90 |  1.11 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 117.10 | 103.56 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  72.69 |  62.80 |  1.16 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  77.57 |  72.72 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  76.84 |  68.66 |  1.12 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 101.86 |  93.95 |  1.08 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 116.16 |  92.69 |  1.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57.87 |  56.93 |  1.02 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  91.46 |  80.29 |  1.14 |          +0 | bimodal  | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 189.07 | 164.38 |  1.15 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 131.71 | 119.44 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  84.50 |  76.60 |  1.10 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96.38 |  75.89 |  1.27 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96.63 |  76.00 |  1.27 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 133.05 | 114.71 |  1.16 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  97.21 |  79.19 |  1.23 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 162.94 | 138.28 |  1.18 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116.54 | 108.09 |  1.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 104.12 |  96.40 |  1.08 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 4, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 101.32 | 100.12 |  1.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  79.38 |  67.73 |  1.17 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 143.38 | 136.51 |  1.05 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 194.21 | 250.65 |  0.77 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116.44 | 108.58 |  1.07 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 139.46 | 117.27 |  1.19 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 130.37 | 115.07 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 180.49 | 161.17 |  1.12 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 161.38 | 160.19 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  87.31 |  75.90 |  1.15 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 153.02 | 134.88 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 301.20 | 270.95 |  1.11 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 204.05 | 188.12 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 122.64 | 112.46 |  1.09 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 119.98 | 111.08 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121.19 | 112.42 |  1.08 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 212.52 | 169.02 |  1.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 170.79 | 144.70 |  1.18 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 275.38 | 224.35 |  1.23 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 190.39 | 171.02 |  1.11 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 184.91 | 155.48 |  1.19 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 5, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 100.51 | 105.06 |  0.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  80.10 |  68.72 |  1.17 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 144.35 | 140.80 |  1.03 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 197.62 | 255.56 |  0.77 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 118.88 | 108.35 |  1.10 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143.70 | 113.74 |  1.26 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 133.13 | 117.30 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 181.91 | 161.24 |  1.13 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 162.49 | 160.56 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  87.01 |  76.84 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 167.15 | 137.81 |  1.21 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 303.42 | 277.20 |  1.09 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 209.79 | 193.10 |  1.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 123.48 | 117.56 |  1.05 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121.12 | 114.17 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 121.82 | 116.95 |  1.04 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 216.39 | 171.58 |  1.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 174.16 | 147.75 |  1.18 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 276.55 | 232.64 |  1.19 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 192.52 | 172.33 |  1.12 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 171.73 | 157.21 |  1.09 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 4, Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  317.16 |  289.48 |  1.10 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  233.51 |  207.63 |  1.12 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  406.31 |  364.75 |  1.11 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  605.59 |  733.15 |  0.83 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  359.07 |  309.09 |  1.16 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  468.21 |  406.66 |  1.15 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  383.66 |  336.31 |  1.14 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  524.73 |  483.29 |  1.09 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  471.31 |  458.40 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  240.39 |  210.22 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  415.59 |  356.71 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1071.76 | 1072.37 |  1.00 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  765.13 |  719.81 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  434.90 |  370.60 |  1.17 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  416.89 |  365.72 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  428.00 |  363.66 |  1.18 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  592.35 |  478.08 |  1.24 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  403.30 |  366.53 |  1.10 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  791.04 |  725.41 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  511.09 |  450.92 |  1.13 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  471.17 |  409.04 |  1.15 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 3, Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  390.66 |  339.47 |  1.15 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  309.07 |  242.83 |  1.27 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  492.08 |  416.76 |  1.18 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower |  684.78 |  887.50 |  0.77 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  425.09 |  363.27 |  1.17 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  535.66 |  467.85 |  1.14 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  456.21 |  403.72 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   |  629.70 |  574.55 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  558.58 |  546.66 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  301.97 |  256.34 |  1.18 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  499.87 |  427.71 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1211.94 | 1215.10 |  1.00 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  879.47 |  867.17 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  493.28 |  431.47 |  1.14 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  485.35 |  433.14 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  493.58 |  432.12 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  715.34 |  583.00 |  1.23 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  468.59 |  449.07 |  1.04 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  986.56 |  909.19 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  625.60 |  534.01 |  1.17 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  567.12 |  487.58 |  1.16 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "the", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1591012.50 | 1302237.50 |  1.22 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1224155.77 |  981726.17 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1823064.24 | 1489360.94 |  1.22 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2588598.96 | 2075796.88 |  1.25 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1689732.81 | 1363570.45 |  1.24 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1607493.13 | 1383433.33 |  1.16 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1742809.03 | 1443461.93 |  1.21 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2592529.17 | 2119492.19 |  1.22 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2243497.32 | 1899446.48 |  1.18 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1394849.98 | 1255213.26 |  1.11 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1822102.05 | 1601165.33 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3114641.00 | 3015846.50 |  1.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2522969.74 | 2157339.51 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1774837.50 | 1515570.00 |  1.17 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1908252.78 | 1662673.75 |  1.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1907475.78 | 1673817.36 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2641299.48 | 2126977.23 |  1.24 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1690719.44 | 1624923.44 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2762754.17 | 2136906.25 |  1.29 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2441537.32 | 2233495.42 |  1.09 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2160348.21 | 1946240.86 |  1.11 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice.Count(Options: IgnoreCase)

| Result  |           Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------- | --------------:| -------------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Unknown |  7850767900.00 | 2279571350.00 |  3.44 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  4430873800.00 | 1803437500.00 |  2.46 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  7638910350.00 | 2822939150.00 |  2.71 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster  | 10738799350.00 | 3676098250.00 |  2.92 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  6329911500.00 | 2434068350.00 |  2.60 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  5928170850.00 | 2484552400.00 |  2.39 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  6260073200.00 | 2635498050.00 |  2.38 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  9009017400.00 | 3953246500.00 |  2.28 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  8037827900.00 | 3441913200.00 |  2.34 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  4328976464.50 | 1880993270.50 |  2.30 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  7502203566.00 | 2750046081.00 |  2.73 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 13315130139.00 | 5571023287.00 |  2.39 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 10665372261.00 | 4012470644.00 |  2.66 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  6495788600.00 | 2594912050.00 |  2.50 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6544247200.00 | 2799520400.00 |  2.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6527664100.00 | 2607614500.00 |  2.50 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 12034313700.00 | 5236916800.00 |  2.30 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  7364918200.00 | 3196565200.00 |  2.30 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 12526954600.00 | 7290686000.00 |  1.72 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 10212401382.50 | 3527950196.00 |  2.89 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  8752895958.00 | 3213273606.00 |  2.72 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsMatch(Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 170.51 | 153.96 |  1.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 118.37 |  99.51 |  1.19 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 216.97 | 178.06 |  1.22 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 405.84 | 353.72 |  1.15 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 185.80 | 154.05 |  1.21 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 217.97 | 190.90 |  1.14 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 189.69 | 171.22 |  1.11 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 287.69 | 226.80 |  1.27 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 294.08 | 231.67 |  1.27 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 134.27 | 104.27 |  1.29 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 213.64 | 179.77 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 403.93 | 387.29 |  1.04 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 292.00 | 302.96 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 182.77 | 158.33 |  1.15 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 186.67 | 167.94 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 183.15 | 158.56 |  1.16 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 292.24 | 232.11 |  1.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 202.68 | 194.84 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 401.34 | 367.39 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 269.80 | 227.24 |  1.19 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 244.83 | 203.26 |  1.20 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Email_IsMatch(Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  354.89 |  306.23 |  1.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  248.71 |  232.21 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  451.20 |  369.32 |  1.22 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  871.39 |  812.70 |  1.07 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  383.85 |  333.37 |  1.15 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  477.69 |  445.07 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  412.88 |  375.03 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  611.90 |  516.91 |  1.18 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  629.10 |  503.97 |  1.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  261.36 |  228.24 |  1.15 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  451.07 |  391.96 |  1.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1122.19 | 1153.21 |  0.97 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  784.42 |  784.48 |  1.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  452.69 |  391.77 |  1.16 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  461.32 |  393.32 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  453.88 |  396.67 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  638.29 |  530.70 |  1.20 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  440.49 |  403.67 |  1.09 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  879.10 |  808.53 |  1.09 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  562.58 |  496.48 |  1.13 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  518.34 |  443.18 |  1.17 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 25702050.00 | 22525877.78 |  1.14 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 19898038.89 | 17919533.33 |  1.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32752175.00 | 27536350.00 |  1.19 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 73964800.00 | 43765575.00 |  1.69 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 29603991.67 | 25087287.50 |  1.18 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 30854283.33 | 27351271.43 |  1.13 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31760666.67 | 26696671.43 |  1.19 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 43691150.00 | 40672825.00 |  1.07 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 47154775.00 | 36765025.00 |  1.28 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 20383261.38 | 18287316.42 |  1.11 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33329601.75 | 28797886.86 |  1.16 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 65154972.00 | 64013204.25 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 48772187.00 | 50790452.75 |  0.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 31683250.00 | 28071662.50 |  1.13 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 29301212.50 | 28739200.00 |  1.02 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 29783537.50 | 28458018.75 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 43159600.00 | 34083200.00 |  1.27 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 32338425.00 | 30990935.71 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 63342950.00 | 53052912.50 |  1.19 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 42901707.63 | 36548697.00 |  1.17 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 38211559.25 | 33222190.00 |  1.15 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 6, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 137.40 | 112.19 |  1.22 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  88.60 |  80.40 |  1.10 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 157.17 | 138.02 |  1.14 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 220.75 | 261.31 |  0.84 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138.27 | 118.10 |  1.17 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 172.29 | 147.21 |  1.17 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 142.52 | 129.07 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 219.37 | 175.19 |  1.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 178.15 | 175.34 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90.10 |  80.64 |  1.12 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 152.23 | 135.93 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 347.04 | 293.02 |  1.18 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 239.11 | 215.71 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 126.59 | 110.68 |  1.14 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 126.32 | 110.16 |  1.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 126.46 | 111.23 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 221.11 | 180.28 |  1.23 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 149.02 | 144.37 |  1.03 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 295.58 | 267.53 |  1.10 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 195.43 | 172.19 |  1.13 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 177.90 | 155.43 |  1.14 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 8, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 136.07 | 122.97 |  1.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90.38 |  77.96 |  1.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 150.57 | 136.88 |  1.10 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 216.37 | 206.57 |  1.05 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 128.35 | 117.84 |  1.09 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 171.66 | 147.34 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 137.97 | 125.42 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 205.64 | 174.28 |  1.18 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 171.50 | 169.95 |  1.01 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  94.05 |  78.93 |  1.19 |          +0 | bimodal  | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 147.09 | 131.11 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 341.87 | 283.16 |  1.21 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 237.35 | 208.76 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 131.63 | 107.83 |  1.22 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 130.07 | 109.33 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 130.19 | 109.18 |  1.19 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 218.98 | 177.67 |  1.23 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 146.88 | 141.01 |  1.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 292.49 | 264.36 |  1.11 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 190.31 | 168.21 |  1.13 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 175.32 | 151.20 |  1.16 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch_Multithreading(total: 40000, unique: 1600, cacheSize: 15)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  68299637.50 |  52509500.00 |  1.30 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  27017160.00 |  23314242.86 |  1.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  49129475.00 |  40658275.00 |  1.21 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 144218300.00 | 131539700.00 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  43918287.50 |  37511725.00 |  1.17 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  40031187.50 |  31894750.00 |  1.26 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  46338300.00 |  36144225.00 |  1.28 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 104192800.00 |  67108275.00 |  1.55 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 183712600.00 |  65954437.50 |  2.79 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  36455413.75 |  30273632.08 |  1.20 |          +0 | bimodal  | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  62251563.25 |  46077445.50 |  1.35 |          +0 | several? | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 124085832.00 | 102428454.00 |  1.21 |          +0 | several? | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 109691160.00 |  77672675.50 |  1.41 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  52389675.00 |  42164750.00 |  1.24 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57050250.00 |  50630600.00 |  1.13 |          +0 | several? | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  58232950.00 |  48118525.00 |  1.21 |          +0 | several? | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100519800.00 |  61946475.00 |  1.62 |          +0 | several? | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 116551800.00 |  67015400.00 |  1.74 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  97853050.00 |  80176700.00 |  1.22 |          +0 | several? | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 123767034.00 | 153667607.00 |  0.81 |          +0 | bimodal  | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  92535592.00 |  90459070.75 |  1.02 |          +0 | bimodal  | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Email_IsMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   | 106.55 | 100.49 |  1.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  81.58 |  73.08 |  1.12 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 152.54 | 153.04 |  1.00 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 213.44 | 286.37 |  0.75 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 128.21 | 117.60 |  1.09 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 155.50 | 122.84 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 149.35 | 127.28 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 212.50 | 169.34 |  1.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 225.25 | 174.39 |  1.29 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  95.27 |  78.31 |  1.22 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 166.43 | 151.88 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 340.72 | 297.03 |  1.15 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 227.65 | 203.63 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 137.05 | 124.66 |  1.10 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138.74 | 121.60 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 139.22 | 122.20 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 238.80 | 190.03 |  1.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 182.30 | 160.70 |  1.13 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 300.29 | 258.89 |  1.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 207.86 | 204.30 |  1.02 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 202.88 | 175.08 |  1.16 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "\p{Sm}", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 27649400.00 | 22541491.67 |  1.23 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 21076433.33 | 19693757.14 |  1.07 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37742275.00 | 29833128.57 |  1.27 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 66437975.00 | 40320025.00 |  1.65 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33094950.00 | 27045544.44 |  1.22 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33581900.00 | 26017785.71 |  1.29 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36304475.00 | 32005683.33 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 51027250.00 | 45344750.00 |  1.13 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 52334750.00 | 43200575.00 |  1.21 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 22326986.09 | 20233014.27 |  1.10 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 39813987.25 | 35711718.44 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 79162787.50 | 68439236.25 |  1.16 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 61640676.38 | 59945912.75 |  1.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 36195150.00 | 34058044.44 |  1.06 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 35908250.00 | 34024750.00 |  1.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 36069275.00 | 34102840.00 |  1.06 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 47500925.00 | 38477714.29 |  1.23 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 39856675.00 | 38839300.00 |  1.03 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 81504525.00 | 63652400.00 |  1.28 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 52665262.50 | 45108536.86 |  1.17 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45764945.63 | 40819425.50 |  1.12 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "aqj", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  929858.64 |  694209.78 |  1.34 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  541417.46 |  542427.80 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  966656.62 |  755559.38 |  1.28 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1383299.74 | 1058088.75 |  1.31 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   |  819050.00 |  757646.43 |  1.08 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  760813.10 |  737891.05 |  1.03 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   |  865130.26 |  810853.13 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1170015.85 | 1142650.89 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1025490.18 | 1001879.88 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  543213.31 |  556108.27 |  0.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  936960.18 |  820642.61 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1351781.68 | 1450775.96 |  0.93 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1181029.45 | 1045584.65 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  824329.93 |  827188.49 |  1.00 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  823135.86 |  816534.38 |  1.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  823378.45 |  828081.25 |  0.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1504132.95 |  999893.96 |  1.50 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  925277.08 |  864909.03 |  1.07 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1660584.38 |  881234.72 |  1.88 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1287407.01 | 1046499.72 |  1.23 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1081993.83 |  948533.26 |  1.14 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Tom.{10,25}river|river.{10,25}Tom", Options: None)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  65901325.00 |  66052000.00 |  1.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  50679525.00 |  51137625.00 |  0.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  85340900.00 |  71515275.00 |  1.19 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 126706800.00 | 172309700.00 |  0.74 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  76556725.00 |  60403600.00 |  1.27 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  82717525.00 |  68466550.00 |  1.21 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  81975350.00 |  64666175.00 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 121797100.00 |  95091550.00 |  1.28 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 120095200.00 |  80023300.00 |  1.50 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  53132967.25 |  44102969.25 |  1.20 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  85101831.75 |  66171014.75 |  1.29 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 186420061.00 | 178242532.00 |  1.05 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 137974779.00 | 128270089.00 |  1.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75306775.00 |  70092687.50 |  1.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75137837.50 |  71343900.00 |  1.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  75300362.50 |  71492350.00 |  1.05 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 115359600.00 |  95399275.00 |  1.21 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  82578600.00 |  79428175.00 |  1.04 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 168814500.00 | 130994000.00 |  1.29 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 111160034.50 |  81646835.25 |  1.36 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  98274972.75 |  71672110.00 |  1.37 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sher[a-z]+|Hol[a-z]+", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Same   |  5816270.83 |  5519646.88 |  1.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4413503.13 |  3660961.25 |  1.21 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7306195.83 |  6157323.44 |  1.19 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 10280637.50 | 12459133.33 |  0.83 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6388533.33 |  5193107.29 |  1.23 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7279727.08 |  6428761.46 |  1.13 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6715293.75 |  5729754.17 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9311492.31 |  7819253.13 |  1.19 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10351637.50 |  6921654.17 |  1.50 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4619736.96 |  3777811.79 |  1.22 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7569044.89 |  5743400.14 |  1.32 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 16735294.91 | 15685577.23 |  1.07 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12035648.57 | 12909186.98 |  0.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7125710.42 |  6223177.08 |  1.15 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7075333.33 |  6629262.50 |  1.07 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7100122.92 |  6252612.50 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10180581.25 |  8580339.06 |  1.19 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8159515.63 |  6742570.83 |  1.21 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 12862995.83 | 11609468.75 |  1.11 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9684340.31 |  7180820.26 |  1.35 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8701424.47 |  6417975.65 |  1.36 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 7, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 136.74 | 118.24 |  1.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  88.11 |  77.97 |  1.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 152.11 | 134.94 |  1.13 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 214.76 | 200.37 |  1.07 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 130.87 | 116.71 |  1.12 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 171.82 | 146.73 |  1.17 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 141.27 | 125.83 |  1.12 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 207.16 | 172.99 |  1.20 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 172.49 | 169.70 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  91.44 |  79.88 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 148.24 | 130.90 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 348.70 | 317.57 |  1.10 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 262.54 | 236.13 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 140.47 | 107.55 |  1.31 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 139.27 | 107.76 |  1.29 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 139.35 | 109.15 |  1.28 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 220.66 | 178.89 |  1.23 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 149.51 | 141.03 |  1.06 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 295.84 | 265.40 |  1.11 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 192.62 | 168.89 |  1.14 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 176.88 | 150.90 |  1.17 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 9, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 134.67 | 113.50 |  1.19 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96.18 |  76.92 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 161.46 | 134.01 |  1.20 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 233.22 | 218.34 |  1.07 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 137.32 | 118.78 |  1.16 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 171.80 | 155.62 |  1.10 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 146.76 | 128.83 |  1.14 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 217.19 | 175.78 |  1.24 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 178.10 | 173.72 |  1.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96.16 |  80.33 |  1.20 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 159.42 | 130.40 |  1.22 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 378.40 | 278.87 |  1.36 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 251.68 | 191.12 |  1.32 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 139.25 | 112.20 |  1.24 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 142.79 | 109.44 |  1.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 140.15 | 113.56 |  1.23 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 238.43 | 178.76 |  1.33 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 158.68 | 139.03 |  1.14 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 314.13 | 282.60 |  1.11 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 201.99 | 170.65 |  1.18 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 185.61 | 154.10 |  1.20 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Holmes", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  940234.93 |  552645.47 |  1.70 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  504469.25 |  411267.63 |  1.23 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  940268.57 |  718773.01 |  1.31 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 1328208.59 | 1995775.78 |  0.67 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  776473.44 |  630730.25 |  1.23 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  757328.31 |  658353.39 |  1.15 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  825893.42 |  707754.55 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1101214.38 |  929705.90 |  1.18 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1238545.45 |  896065.26 |  1.38 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  551946.56 |  451641.27 |  1.22 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  927326.08 |  692899.09 |  1.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1612978.56 | 1413067.27 |  1.14 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1320304.65 | 1025800.46 |  1.29 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  829751.97 |  648216.50 |  1.28 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  823070.72 |  745852.68 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  828135.86 |  661030.99 |  1.25 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1484502.56 | 1297066.41 |  1.14 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  882333.68 |  821832.50 |  1.07 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1538131.25 | 1391376.82 |  1.11 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1252103.68 |  894431.99 |  1.40 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1080003.18 |  814318.47 |  1.33 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Uri_IsMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 125.52 | 108.20 |  1.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  82.23 |  73.79 |  1.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 157.82 | 135.50 |  1.16 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 220.11 | 267.17 |  0.82 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 132.60 | 110.61 |  1.20 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 149.20 | 124.27 |  1.20 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 145.16 | 120.97 |  1.20 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 200.59 | 162.44 |  1.23 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 214.07 | 164.47 |  1.30 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 100.47 |  91.45 |  1.10 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 166.90 | 146.84 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 365.62 | 292.33 |  1.25 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 228.61 | 208.13 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 154.82 | 132.91 |  1.16 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 163.19 | 139.64 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164.72 | 144.38 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 231.77 | 196.12 |  1.18 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 163.51 | 148.39 |  1.10 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 277.36 | 238.83 |  1.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 213.66 | 185.04 |  1.15 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 191.98 | 170.10 |  1.13 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesWord(Options: None)

| Result |    Base |     Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| --------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 3862.45 |  2857.48 |  1.35 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2267.12 |  2006.21 |  1.13 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4286.95 |  3431.86 |  1.25 |          +0 | multimodal | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 6161.99 |  4247.54 |  1.45 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3546.19 |  2490.73 |  1.42 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3467.35 |  2600.36 |  1.33 |          +0 |            | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3644.00 |  2814.34 |  1.29 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5221.51 |  3884.48 |  1.34 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5376.37 |  3808.26 |  1.41 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2667.27 |  2192.77 |  1.22 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4250.07 |  3164.38 |  1.34 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 7569.43 | 10750.32 |  0.70 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5493.28 |  4506.01 |  1.22 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4065.65 |  4326.52 |  0.94 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4221.79 |  4317.15 |  0.98 |          +0 | several?   | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4223.95 |  4500.37 |  0.94 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 6574.35 |  4657.34 |  1.41 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3973.50 |  4030.03 |  0.99 |          +0 | several?   | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 7374.90 |  5193.03 |  1.42 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5653.67 |  4390.98 |  1.29 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4891.46 |  4009.70 |  1.22 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "the", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2056791.02 | 1571096.25 |  1.31 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1290020.05 | 1159167.71 |  1.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2183722.32 | 1812542.97 |  1.20 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3223743.75 | 2541049.11 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1913159.38 | 1636786.11 |  1.17 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1840960.42 | 1594558.68 |  1.15 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2001621.09 | 1703789.38 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2969579.17 | 2530580.73 |  1.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2638623.44 | 2137870.70 |  1.23 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1540866.08 | 1387220.23 |  1.11 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2210829.92 | 1911476.56 |  1.16 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 3689860.58 | 3628321.45 |  1.02 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2982452.31 | 2514942.52 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1980319.92 | 1767380.47 |  1.12 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2156856.25 | 1927539.84 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2139783.48 | 1921246.48 |  1.11 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3228667.50 | 2457168.23 |  1.31 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2100992.97 | 1900162.50 |  1.11 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3680717.19 | 2870861.25 |  1.28 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2962381.53 | 2629140.91 |  1.13 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2592355.87 | 2293025.87 |  1.13 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.IP_IsMatch(Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  686.77 |  585.53 |  1.17 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  468.74 |  374.85 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  793.75 |  642.68 |  1.24 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1879.02 | 1451.18 |  1.29 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  717.26 |  560.41 |  1.28 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  943.59 |  692.97 |  1.36 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  796.02 |  615.56 |  1.29 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1166.38 |  847.15 |  1.38 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1186.07 |  827.17 |  1.43 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  463.58 |  372.05 |  1.25 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  757.24 |  603.35 |  1.26 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1701.52 | 1705.27 |  1.00 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1094.24 | 1112.74 |  0.98 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  726.32 |  642.61 |  1.13 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  712.08 |  646.10 |  1.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  746.22 |  642.11 |  1.16 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1185.10 |  876.95 |  1.35 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  744.63 |  683.53 |  1.09 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1596.58 | 1373.17 |  1.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  991.04 |  783.22 |  1.27 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  898.70 |  699.13 |  1.29 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 10, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 126.92 | 112.15 |  1.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  94.85 |  74.48 |  1.27 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 157.79 | 132.17 |  1.19 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 307.44 | 285.91 |  1.08 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 136.04 | 118.86 |  1.14 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   | 159.08 | 149.76 |  1.06 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 143.51 | 130.50 |  1.10 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 212.79 | 178.85 |  1.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 177.32 | 173.48 |  1.02 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  91.99 |  79.87 |  1.15 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 156.99 | 131.37 |  1.20 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 367.87 | 322.22 |  1.14 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 246.68 | 191.90 |  1.29 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 137.26 | 116.81 |  1.18 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 134.40 | 112.91 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138.16 | 119.13 |  1.16 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 236.22 | 178.45 |  1.32 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 156.41 | 144.10 |  1.09 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 315.37 | 281.92 |  1.12 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 198.80 | 169.11 |  1.18 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 183.10 | 153.30 |  1.19 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  6925847.92 |  5226975.00 |  1.33 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5122092.71 |  3576500.00 |  1.43 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7364860.42 |  5830992.71 |  1.26 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15981292.86 |  9502175.00 |  1.68 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7149429.17 |  5599787.50 |  1.28 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7880989.06 |  6435963.54 |  1.22 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7300075.00 |  6226575.00 |  1.17 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10389079.17 |  9411244.44 |  1.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10919020.00 |  8545784.38 |  1.28 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5545448.65 |  3739449.55 |  1.48 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7092214.88 |  5963778.79 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16082642.03 | 13698070.00 |  1.17 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 10054805.33 |  9099194.15 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7403945.83 |  6316689.58 |  1.17 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7143931.25 |  6329477.08 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7154868.75 |  6307959.38 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12933580.56 |  9765256.00 |  1.32 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  7119213.54 |  6457422.92 |  1.10 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12676694.74 | 10541004.35 |  1.20 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9012303.95 |  7746696.84 |  1.16 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8315971.13 |  7029532.74 |  1.18 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "the\s+\w+", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2308912.50 | 1740532.64 |  1.33 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1511685.00 | 1290075.48 |  1.17 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2577278.13 | 2109391.96 |  1.22 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3695543.75 | 2907940.00 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2254226.79 | 1859250.00 |  1.21 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2216725.00 | 1882808.59 |  1.18 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2344305.36 | 1974129.69 |  1.19 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3591677.50 | 2961188.54 |  1.21 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3037939.38 | 2555918.75 |  1.19 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1750212.40 | 1525575.41 |  1.15 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2574813.68 | 2167181.82 |  1.19 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 4314432.98 | 3889071.41 |  1.11 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3739346.99 | 2920518.69 |  1.28 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2344786.61 | 2024466.07 |  1.16 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2469939.29 | 2112191.07 |  1.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2443043.75 | 2134845.54 |  1.14 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3631136.72 | 2704760.00 |  1.34 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 2394991.07 | 2213705.36 |  1.08 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4657264.06 | 3476682.81 |  1.34 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3406072.21 | 2900292.03 |  1.17 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2988860.86 | 2541132.43 |  1.18 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.IP_IsNotMatch(Options: None)

| Result |    Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  685.17 |  585.70 |  1.17 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  466.16 |  373.37 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  793.74 |  652.62 |  1.22 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1655.31 | 1272.36 |  1.30 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  728.45 |  569.71 |  1.28 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  914.52 |  713.05 |  1.28 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  803.64 |  610.17 |  1.32 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1176.72 |  852.63 |  1.38 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1180.68 |  830.59 |  1.42 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  463.06 |  372.01 |  1.24 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  770.60 |  601.47 |  1.28 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1705.09 | 1734.64 |  0.98 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1084.23 | 1113.60 |  0.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Same   |  725.07 |  653.07 |  1.11 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  706.24 |  645.97 |  1.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  750.77 |  666.33 |  1.13 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1241.46 |  875.71 |  1.42 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  782.49 |  633.07 |  1.24 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1591.71 | 1372.52 |  1.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  993.89 |  781.71 |  1.27 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  898.43 |  699.25 |  1.28 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesSet(Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 167296.26 | 138158.61 |  1.21 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 105665.16 |  82145.63 |  1.29 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 183676.16 | 150420.06 |  1.22 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 261406.41 | 230137.21 |  1.14 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 168418.56 | 136334.38 |  1.24 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 210132.61 | 155019.76 |  1.36 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 182626.98 | 148007.25 |  1.23 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 271148.22 | 200898.70 |  1.35 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 298684.16 | 202356.53 |  1.48 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 110084.94 |  87885.62 |  1.25 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 180769.55 | 158447.71 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 370865.92 | 328329.74 |  1.13 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 277133.12 | 244375.43 |  1.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164797.37 | 134982.21 |  1.22 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164547.88 | 134557.34 |  1.22 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164304.76 | 136165.63 |  1.21 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 264518.75 | 201510.26 |  1.31 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 186334.41 | 178043.25 |  1.05 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 382260.94 | 310414.58 |  1.23 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 242950.45 | 205929.57 |  1.18 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 219658.66 | 183160.62 |  1.20 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "aqj", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  933726.65 |  700455.97 |  1.33 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  750648.51 |  543170.91 |  1.38 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1035642.19 |  801490.47 |  1.29 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1409217.05 | 1069882.29 |  1.32 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  982783.98 |  756142.34 |  1.30 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  913815.44 |  742508.33 |  1.23 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1000131.25 |  825248.52 |  1.21 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1410611.08 | 1143983.48 |  1.23 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1239547.92 | 1008809.58 |  1.23 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  748187.14 |  557815.55 |  1.34 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1003806.63 |  820850.35 |  1.22 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 1465411.70 | 1557619.60 |  0.94 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1364539.03 | 1045846.75 |  1.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  997507.03 |  822935.20 |  1.21 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  995804.49 |  817741.88 |  1.22 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  994501.95 |  823807.40 |  1.21 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1445322.73 |  999525.63 |  1.45 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   |  915096.32 |  898877.78 |  1.02 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1362404.17 |  856622.04 |  1.59 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1273487.68 | 1045558.89 |  1.22 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1160277.53 |  948698.18 |  1.22 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 2, Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  87.64 |  73.85 |  1.19 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Same   |  57.13 |  52.95 |  1.08 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103.68 |  89.12 |  1.16 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 149.85 | 123.46 |  1.21 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  89.82 |  75.46 |  1.19 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  99.98 |  80.95 |  1.23 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  98.09 |  80.94 |  1.21 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 137.37 | 108.94 |  1.26 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 125.58 | 108.71 |  1.16 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Same   |  62.42 |  58.60 |  1.07 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 108.55 |  92.09 |  1.18 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 231.92 | 196.32 |  1.18 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 153.99 | 135.31 |  1.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103.27 |  79.31 |  1.30 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  97.44 |  76.58 |  1.27 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96.69 |  79.17 |  1.22 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 149.82 | 122.39 |  1.22 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 116.68 |  98.88 |  1.18 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 199.63 | 150.91 |  1.32 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 137.74 | 117.13 |  1.18 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 124.03 | 106.70 |  1.16 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\b\w+n\b", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 12813115.38 | 11360659.09 |  1.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9518028.13 |  7641458.33 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 15149222.73 | 13486244.74 |  1.12 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 22440637.50 | 26849825.00 |  0.84 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14036075.00 | 11980955.00 |  1.17 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16364106.67 | 13911917.65 |  1.18 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15752168.75 | 12677865.00 |  1.24 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23858043.75 | 19708250.00 |  1.21 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21638070.00 | 15972366.67 |  1.35 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10669602.48 |  8612418.28 |  1.24 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16859540.20 | 13152143.42 |  1.28 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32776710.38 | 27888270.00 |  1.18 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23179871.11 | 18635101.00 |  1.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15861808.33 | 12828115.79 |  1.24 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16122853.33 | 13339672.22 |  1.21 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16261118.18 | 13121973.68 |  1.24 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22929475.00 | 17123642.86 |  1.34 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17162000.00 | 13869270.59 |  1.24 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28005078.57 | 22394781.82 |  1.25 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21566772.56 | 17274407.86 |  1.25 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19532164.70 | 15467725.38 |  1.26 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.IP_IsMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 160.97 | 126.89 |  1.27 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114.13 |  88.95 |  1.28 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 186.34 | 151.97 |  1.23 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 261.47 | 291.07 |  0.90 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164.89 | 138.84 |  1.19 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 251.15 | 168.52 |  1.49 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 187.10 | 153.19 |  1.22 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 290.43 | 213.28 |  1.36 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 290.80 | 207.43 |  1.40 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114.66 |  97.14 |  1.18 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 173.16 | 155.73 |  1.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 452.06 | 329.44 |  1.37 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 281.39 | 233.56 |  1.20 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 186.64 | 144.48 |  1.29 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 180.05 | 145.20 |  1.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 185.61 | 144.72 |  1.28 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 296.36 | 200.10 |  1.48 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 213.00 | 178.71 |  1.19 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 340.68 | 265.03 |  1.29 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 252.52 | 198.06 |  1.27 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 205.24 | 181.26 |  1.13 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_BoostDocs_Simple.IsMatch(Id: 2, Options: None)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 284.57 | 228.47 |  1.25 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 191.97 | 149.13 |  1.29 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 359.10 | 270.38 |  1.33 |          +0 | bimodal    | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 513.65 | 406.62 |  1.26 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 310.09 | 234.85 |  1.32 |          +0 | multimodal | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 392.33 | 276.77 |  1.42 |          +0 | several?   | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 317.26 | 253.94 |  1.25 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 434.94 | 354.55 |  1.23 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 391.00 | 340.96 |  1.15 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 191.59 | 164.20 |  1.17 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 332.91 | 271.89 |  1.22 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 724.05 | 627.31 |  1.15 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 525.05 | 457.12 |  1.15 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 304.97 | 239.17 |  1.28 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 307.54 | 241.98 |  1.27 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 308.97 | 241.74 |  1.28 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 467.69 | 365.84 |  1.28 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 337.76 | 303.16 |  1.11 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 661.73 | 527.93 |  1.25 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 413.55 | 353.62 |  1.17 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 370.66 | 311.90 |  1.19 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.IP_IsNotMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 160.85 | 124.17 |  1.30 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114.21 |  88.72 |  1.29 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 190.74 | 164.41 |  1.16 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 264.22 | 290.31 |  0.91 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 168.83 | 138.14 |  1.22 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 233.32 | 166.71 |  1.40 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 186.46 | 152.66 |  1.22 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 284.62 | 211.98 |  1.34 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 292.59 | 217.81 |  1.34 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114.83 |  97.21 |  1.18 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 173.32 | 154.64 |  1.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 456.89 | 330.17 |  1.38 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 280.83 | 227.06 |  1.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 188.32 | 145.12 |  1.30 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 182.63 | 146.29 |  1.25 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 188.19 | 145.11 |  1.30 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 295.04 | 199.87 |  1.48 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 194.96 | 169.56 |  1.15 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 340.09 | 277.37 |  1.23 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 243.54 | 200.59 |  1.21 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 204.97 | 181.00 |  1.13 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Date_IsNotMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 179.27 | 160.03 |  1.12 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 118.29 |  94.39 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 195.17 | 155.30 |  1.26 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 260.41 | 227.05 |  1.15 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 164.84 | 134.15 |  1.23 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 186.29 | 163.34 |  1.14 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 173.45 | 145.45 |  1.19 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 239.23 | 200.24 |  1.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 268.54 | 193.70 |  1.39 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 165.29 | 123.32 |  1.34 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 215.63 | 177.87 |  1.21 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 557.14 | 393.76 |  1.41 |          +0 | several? | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 349.18 | 256.84 |  1.36 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 215.27 | 162.21 |  1.33 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 270.98 | 205.04 |  1.32 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 257.35 | 197.21 |  1.30 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 335.43 | 255.68 |  1.31 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 190.34 | 164.93 |  1.15 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 379.53 | 278.57 |  1.36 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 273.92 | 211.94 |  1.29 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 237.41 | 198.95 |  1.19 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "\s[a-zA-Z]{0,12}ing\s", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  6070263.54 |  5034592.19 |  1.21 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4733187.50 |  3484271.25 |  1.36 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7811510.61 |  6157895.83 |  1.27 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11619550.00 |  8523414.29 |  1.36 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6921775.00 |  5393102.08 |  1.28 |          +0 | several?   | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8096526.56 |  6165496.88 |  1.31 |          +0 |            | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7863715.63 |  6008697.92 |  1.31 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12128455.56 |  9023568.75 |  1.34 |          +0 | multimodal | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9738359.38 |  7727670.31 |  1.26 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5033158.67 |  3877139.92 |  1.30 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8049930.16 |  6358862.61 |  1.27 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16411667.97 | 12168991.65 |  1.35 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10639969.03 |  8315815.22 |  1.28 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8098776.56 |  6436931.25 |  1.26 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8161971.88 |  6453003.13 |  1.26 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8148832.81 |  6573091.67 |  1.24 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10639831.25 |  7654896.88 |  1.39 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9101150.00 |  7161330.21 |  1.27 |          +0 | several?   | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12647923.68 |  8798034.38 |  1.44 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10301782.64 |  8138388.02 |  1.27 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9250954.22 |  7294410.47 |  1.27 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Cache.IsMatch_Multithreading(total: 40000, unique: 7, cacheSize: 0)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 46926825.00 | 17505860.00 |  2.68 |          +0 | multimodal | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14802613.33 |  9554784.62 |  1.55 |          +0 | several?   | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 24608166.67 | 14997350.00 |  1.64 |          +0 | multimodal | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 70871300.00 | 54944225.00 |  1.29 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25645175.00 | 15948870.00 |  1.61 |          +0 | bimodal    | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20482135.00 | 12876037.50 |  1.59 |          +0 |            | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 24511320.00 | 15233870.00 |  1.61 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 51446800.00 | 26090133.33 |  1.97 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 85319850.00 | 26425766.67 |  3.23 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21783124.94 | 13878154.27 |  1.57 |          +0 | several?   | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36648740.40 | 21018229.19 |  1.74 |          +0 | several?   | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 65622978.63 | 43538724.75 |  1.51 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 59975829.75 | 35297948.88 |  1.70 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33160471.43 | 18612466.67 |  1.78 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 34252391.67 | 21347362.50 |  1.60 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33575000.00 | 21284425.00 |  1.58 |          +0 | several?   | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 64766325.00 | 27567100.00 |  2.35 |          +0 | bimodal    | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26012133.33 | 14694279.17 |  1.77 |          +0 | several?   | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 56031987.50 | 33200950.00 |  1.69 |          +0 | bimodal    | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Same   | 61069558.38 | 55471425.00 |  1.10 |          +0 | several?   | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Same   | 47260690.38 | 41147730.75 |  1.15 |          +0 | several?   | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Ctor(Pattern: "[\w\.+-]+@[\w\.-]+\.[\w\.-]+", Options: Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 26173.98 | 18985.26 |  1.38 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17284.72 | 13792.90 |  1.25 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30781.02 | 21828.85 |  1.41 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 50478.14 | 30081.46 |  1.68 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26312.23 | 18760.71 |  1.40 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28360.90 | 20838.29 |  1.36 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30549.04 | 22650.05 |  1.35 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41411.67 | 31553.96 |  1.31 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45286.94 | 29591.62 |  1.53 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21003.81 | 16432.41 |  1.28 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31616.84 | 23184.04 |  1.36 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 71784.01 | 54503.04 |  1.32 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 52252.82 | 37448.17 |  1.40 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31101.82 | 22006.40 |  1.41 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32112.84 | 23811.98 |  1.35 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31674.07 | 23881.04 |  1.33 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 42920.92 | 30622.58 |  1.40 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30530.41 | 22702.17 |  1.34 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 59031.66 | 42203.58 |  1.40 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41844.50 | 31860.98 |  1.31 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37461.70 | 28154.72 |  1.33 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "aei", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1097660.42 |  689496.20 |  1.59 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  644684.00 |  542747.20 |  1.19 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1141934.15 |  758071.41 |  1.51 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1618683.44 | 1058411.88 |  1.53 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  996805.08 |  758086.90 |  1.31 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  923748.90 |  734208.52 |  1.26 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1039711.88 |  808423.44 |  1.29 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1424992.33 | 1138704.24 |  1.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1269048.70 | 1041877.54 |  1.22 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  649047.65 |  559531.06 |  1.16 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1110287.10 |  816560.99 |  1.36 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1616269.51 | 1451278.09 |  1.11 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1401742.33 | 1046250.22 |  1.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1001960.16 |  827644.41 |  1.21 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1001944.14 |  818154.28 |  1.22 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1002709.57 |  829899.67 |  1.21 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1693855.00 | 1001071.88 |  1.69 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1049410.83 |  910015.97 |  1.15 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1895506.94 |  881323.26 |  2.15 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1508787.87 | 1045508.22 |  1.44 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1280151.94 |  949052.35 |  1.35 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Ctor(Pattern: "[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?", Options: Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 33984.76 | 22064.97 |  1.54 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23982.12 | 15833.05 |  1.51 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 38577.03 | 26019.41 |  1.48 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 58649.46 | 79296.98 |  0.74 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 34556.42 | 22293.94 |  1.55 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 35471.41 | 22107.38 |  1.60 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 39740.98 | 24145.00 |  1.65 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 52963.81 | 32288.14 |  1.64 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 58378.76 | 30413.77 |  1.92 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27232.28 | 19439.03 |  1.40 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 42276.78 | 27302.16 |  1.55 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 97711.80 | 66304.59 |  1.47 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 69566.26 | 44829.07 |  1.55 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 40255.95 | 26907.81 |  1.50 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41676.85 | 28754.88 |  1.45 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 42194.99 | 29411.07 |  1.43 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 55541.92 | 35488.12 |  1.57 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 43379.74 | 27124.87 |  1.60 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 71609.92 | 48036.71 |  1.49 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 57568.62 | 39118.70 |  1.47 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 50992.54 | 37380.78 |  1.36 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)the", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2713698.96 | 1545038.84 |  1.76 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1646928.75 | 1119358.26 |  1.47 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2938970.00 | 1996612.50 |  1.47 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 8122198.44 | 2716340.63 |  2.99 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2456150.52 | 1656310.00 |  1.48 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2405891.15 | 1702142.86 |  1.41 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2532338.54 | 1833664.58 |  1.38 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3458568.75 | 2480376.88 |  1.39 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3873271.88 | 2327676.34 |  1.66 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1995122.25 | 1472524.84 |  1.35 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2947191.75 | 1966406.31 |  1.50 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5337508.83 | 3960669.18 |  1.35 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4086313.38 | 2956574.05 |  1.38 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2626692.71 | 1835128.57 |  1.43 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2783855.00 | 2084961.46 |  1.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2764633.75 | 2045285.55 |  1.35 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4327658.59 | 2999283.33 |  1.44 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2861647.92 | 2040922.66 |  1.40 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4617235.42 | 3552276.88 |  1.30 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3971390.20 | 2618512.25 |  1.52 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3420427.92 | 2340503.29 |  1.46 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Email_IsNotMatch(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 171.17 | 133.72 |  1.28 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 134.46 |  90.55 |  1.48 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 218.95 | 177.09 |  1.24 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 333.73 | 343.61 |  0.97 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 195.56 | 150.08 |  1.30 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 260.39 | 150.84 |  1.73 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 223.75 | 155.01 |  1.44 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 331.29 | 207.93 |  1.59 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 340.36 | 209.83 |  1.62 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 151.06 | 100.53 |  1.50 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 250.64 | 185.81 |  1.35 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 687.86 | 364.06 |  1.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 481.28 | 251.46 |  1.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 254.43 | 149.78 |  1.70 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 254.12 | 149.33 |  1.70 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 256.29 | 152.29 |  1.68 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 350.27 | 226.90 |  1.54 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 285.17 | 181.40 |  1.57 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 444.29 | 297.40 |  1.49 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 317.40 | 239.45 |  1.33 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 283.06 | 214.23 |  1.32 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock|Holmes|Watson|Irene|Adler|John|Baker", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 3483310.94 | 2296776.79 |  1.52 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2691175.00 | 1861049.65 |  1.45 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3918675.78 | 2832327.08 |  1.38 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 7539241.94 | 3865071.09 |  1.95 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3536950.78 | 2455276.79 |  1.44 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3808928.13 | 2786012.50 |  1.37 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4153648.44 | 2969115.63 |  1.40 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5919453.13 | 4000056.25 |  1.48 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5949961.46 | 3766689.06 |  1.58 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2944685.53 | 1981650.77 |  1.49 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4327442.11 | 3007210.98 |  1.44 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 8125871.31 | 5338133.26 |  1.52 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5860137.78 | 3982273.98 |  1.47 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3965647.66 | 2720405.21 |  1.46 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3959871.88 | 2731973.44 |  1.45 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3988598.44 | 2757305.21 |  1.45 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5478054.35 | 3674468.75 |  1.49 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4351835.94 | 2799182.29 |  1.55 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 7398302.94 | 4480012.50 |  1.65 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5451700.64 | 3844727.14 |  1.42 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4989908.13 | 3495310.39 |  1.43 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchWord(Options: Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 151.92 | 104.92 |  1.45 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 124.03 |  73.56 |  1.69 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 212.77 | 125.19 |  1.70 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 379.04 | 175.53 |  2.16 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 167.43 | 115.27 |  1.45 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 166.39 | 104.16 |  1.60 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 180.44 | 117.52 |  1.54 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 248.89 | 158.79 |  1.57 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 280.41 | 161.50 |  1.74 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143.13 |  99.11 |  1.44 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 204.33 | 138.15 |  1.48 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 561.80 | 344.31 |  1.63 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 291.51 | 204.09 |  1.43 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 212.43 | 133.95 |  1.59 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 236.44 | 154.23 |  1.53 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 217.45 | 157.28 |  1.38 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 312.74 | 216.34 |  1.45 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 214.27 | 133.76 |  1.60 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 383.87 | 258.30 |  1.49 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 264.56 | 184.72 |  1.43 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 238.91 | 171.70 |  1.39 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Holmes.{0,25}Watson|Watson.{0,25}Holmes", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 106463.19 |  66421.85 |  1.60 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  78934.63 |  49433.10 |  1.60 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143278.75 |  95189.29 |  1.51 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 251001.59 | 131972.91 |  1.90 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 128331.71 |  82128.56 |  1.56 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 130934.99 |  89072.52 |  1.47 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138882.19 |  90089.61 |  1.54 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 187146.25 | 124973.66 |  1.50 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 181378.82 | 116888.37 |  1.55 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  84398.88 |  51910.66 |  1.63 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 158395.56 |  96773.53 |  1.64 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 314542.93 | 225893.23 |  1.39 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 238389.49 | 160929.18 |  1.48 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143262.50 |  88235.33 |  1.62 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 155861.50 | 108166.31 |  1.44 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 142094.09 |  88471.26 |  1.61 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 317435.75 | 237344.18 |  1.34 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 169055.31 |  97792.20 |  1.73 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 594786.78 | 522608.96 |  1.14 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 203149.29 | 126532.04 |  1.61 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 186151.03 | 115603.32 |  1.61 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesBoundary(Options: IgnoreCase, Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  97532.62 |  56982.43 |  1.71 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  64138.54 |  41161.50 |  1.56 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 104827.35 |  65578.10 |  1.60 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 152126.03 | 123132.25 |  1.24 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  94476.47 |  58348.47 |  1.62 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 109539.38 |  64667.63 |  1.69 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  97931.68 |  64696.10 |  1.51 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 135144.60 |  89060.65 |  1.52 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 125824.46 |  88921.88 |  1.42 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  92311.74 |  49676.25 |  1.86 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 113345.52 |  70190.39 |  1.61 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 273734.54 | 169941.16 |  1.61 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 162918.35 | 101647.43 |  1.60 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 104597.76 |  65972.02 |  1.59 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 129219.81 |  74574.64 |  1.73 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 128621.54 |  73400.53 |  1.75 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 187066.11 | 101409.11 |  1.84 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 104915.50 |  70110.92 |  1.50 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 191431.02 | 112063.96 |  1.71 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 140396.42 |  88779.65 |  1.58 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 125915.26 |  83926.22 |  1.50 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Tom.{10,25}river|river.{10,25}Tom", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 11225693.75 |  6173490.63 |  1.82 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8964284.38 |  4944269.53 |  1.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12962468.42 |  7518697.92 |  1.72 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17601338.46 | 13469590.63 |  1.31 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11989748.44 |  7180487.50 |  1.67 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12114971.88 |  7173086.46 |  1.69 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13192222.22 |  7769137.50 |  1.70 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19187666.67 | 12105619.05 |  1.59 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18964254.17 | 10961006.82 |  1.73 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9135252.09 |  5485529.13 |  1.67 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13198904.47 |  7711906.27 |  1.71 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27231684.61 | 15474976.81 |  1.76 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17403115.11 | 10518223.33 |  1.65 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12453734.21 |  7676765.63 |  1.62 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12856589.47 |  7493454.17 |  1.72 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11963052.38 |  7546800.00 |  1.59 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23862960.00 | 14006819.44 |  1.70 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14827967.65 |  8003975.00 |  1.85 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25382310.00 | 18483376.92 |  1.37 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16492448.20 |  9901471.86 |  1.67 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15104730.13 |  8959182.98 |  1.69 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Holmes", Options: Compiled)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  752519.35 | 395743.44 |  1.90 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  559314.22 | 316669.77 |  1.77 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  822521.55 | 459825.09 |  1.79 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1141818.75 | 884139.58 |  1.29 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  780025.60 | 427577.87 |  1.82 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  806844.06 | 413542.43 |  1.95 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  890012.50 | 457774.26 |  1.94 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1186747.32 | 602793.27 |  1.97 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1299262.50 | 564345.14 |  2.30 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  600488.83 | 337523.24 |  1.78 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  826883.61 | 464162.01 |  1.78 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1445680.59 | 937495.42 |  1.54 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1122640.13 | 641252.61 |  1.75 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  799626.25 | 447407.68 |  1.79 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  807575.16 | 486521.97 |  1.66 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  809068.75 | 456077.39 |  1.77 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1143097.77 | 935799.26 |  1.22 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  838699.67 | 538998.49 |  1.56 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1329748.96 | 898810.29 |  1.48 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1075843.30 | 585163.26 |  1.84 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  969971.36 | 543565.22 |  1.78 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesSet(Options: IgnoreCase, Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  96329.71 |  57563.55 |  1.67 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  72435.56 |  41762.27 |  1.73 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114912.17 |  68607.18 |  1.67 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 156500.91 | 135532.17 |  1.15 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100747.14 |  59948.69 |  1.68 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 112717.17 |  65981.15 |  1.71 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103611.59 |  65203.97 |  1.59 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138583.06 |  88780.45 |  1.56 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 135369.78 |  90521.12 |  1.50 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  95571.17 |  54316.70 |  1.76 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 123845.88 |  75720.28 |  1.64 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 341842.35 | 188784.21 |  1.81 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 176950.77 | 102727.04 |  1.72 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 119464.49 |  69805.58 |  1.71 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 148424.17 |  77111.90 |  1.92 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 147853.39 |  77349.28 |  1.91 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 215322.17 | 113547.95 |  1.90 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 114028.92 |  69215.92 |  1.65 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 230054.15 | 133425.24 |  1.72 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 152430.29 |  94427.15 |  1.61 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 140650.01 |  88323.57 |  1.59 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Backtracking(Options: IgnoreCase, Compiled)

| Result |    Base |   Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| ------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  458.39 | 291.27 |  1.57 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  354.87 | 200.87 |  1.77 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  564.17 | 378.65 |  1.49 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  876.51 | 515.00 |  1.70 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  495.42 | 311.65 |  1.59 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  603.40 | 321.54 |  1.88 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  540.12 | 354.45 |  1.52 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  751.74 | 477.21 |  1.58 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  851.90 | 479.67 |  1.78 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  419.83 | 265.92 |  1.58 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  685.93 | 404.01 |  1.70 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1530.71 | 854.40 |  1.79 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  956.45 | 561.19 |  1.70 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  627.09 | 366.02 |  1.71 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  661.71 | 398.78 |  1.66 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  666.38 | 394.66 |  1.69 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  886.79 | 488.82 |  1.81 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  670.54 | 402.98 |  1.66 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  965.09 | 589.89 |  1.64 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  976.74 | 518.84 |  1.88 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  846.84 | 523.00 |  1.62 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_SliceSlice.Count(Options: IgnoreCase, Compiled)

| Result  |           Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------- | --------------:| -------------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Unknown |  5698128250.00 | 1604494150.00 |  3.55 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  4839674100.00 | 1352804500.00 |  3.58 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6567536400.00 | 1892690800.00 |  3.47 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  8940671800.00 | 2534582750.00 |  3.53 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  6165198800.00 | 1749747650.00 |  3.52 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6498148200.00 | 1690214350.00 |  3.84 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  6471907950.00 | 1813286900.00 |  3.57 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  9830944300.00 | 2369739150.00 |  4.15 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  8793824900.00 | 2409128300.00 |  3.65 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  4909630773.00 | 1471600430.00 |  3.34 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  6410014621.50 | 1920105038.00 |  3.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 11498959421.50 | 4075262774.50 |  2.82 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  8804752072.00 | 2777545926.00 |  3.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6304356500.00 | 1837394100.00 |  3.43 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6337479000.00 | 1995429650.00 |  3.18 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6325843500.00 | 1881915500.00 |  3.36 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  9235727400.00 | 4121133150.00 |  2.24 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  6849087600.00 | 2083397800.00 |  3.29 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Unknown | 10341503800.00 | 5752379000.00 |  1.80 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster  |  8217324904.50 | 2459737245.00 |  3.34 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Unknown |  7409924794.00 | 2242048345.00 |  3.30 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock|Holmes|Watson", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2312978.75 | 1355755.73 |  1.71 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1783356.25 | 1015139.26 |  1.76 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2510390.63 | 1667341.25 |  1.51 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4780445.83 | 2233680.80 |  2.14 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2426048.96 | 1563746.88 |  1.55 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2240966.96 | 1875269.79 |  1.20 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2489470.00 | 1980715.63 |  1.26 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3308330.47 | 2676773.96 |  1.24 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4035756.25 | 2503614.06 |  1.61 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1970772.61 | 1052354.61 |  1.87 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3079661.90 | 1623348.61 |  1.90 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 6170024.77 | 3035159.67 |  2.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4498868.33 | 2293497.13 |  1.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2876213.54 | 1556304.06 |  1.85 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2860947.92 | 1534719.89 |  1.86 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2880366.15 | 1517749.72 |  1.90 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3383928.75 | 2307005.36 |  1.47 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3026147.50 | 1476072.73 |  2.05 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4844166.67 | 2913831.77 |  1.66 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4024409.26 | 2191460.07 |  1.84 |          +0 | bimodal  | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3688409.64 | 1875694.84 |  1.97 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.IP_IsMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 300.38 | 152.78 |  1.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 193.86 | 103.57 |  1.87 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 323.37 | 187.38 |  1.73 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 447.48 | 344.05 |  1.30 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 293.41 | 160.98 |  1.82 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 332.18 | 183.55 |  1.81 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 291.39 | 173.60 |  1.68 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 398.66 | 230.90 |  1.73 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 454.93 | 234.48 |  1.94 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 243.42 | 134.29 |  1.81 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 342.76 | 197.59 |  1.73 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 872.22 | 416.36 |  2.09 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 552.36 | 274.88 |  2.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 334.03 | 178.15 |  1.87 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 373.61 | 206.19 |  1.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 393.39 | 205.78 |  1.91 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 533.69 | 265.22 |  2.01 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 352.87 | 195.31 |  1.81 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 546.76 | 322.93 |  1.69 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 425.62 | 244.07 |  1.74 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 380.93 | 216.70 |  1.76 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.IP_IsNotMatch(Options: IgnoreCase, Compiled)

| Result |   Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 298.71 | 152.21 |  1.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 194.20 | 109.53 |  1.77 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 324.95 | 180.03 |  1.80 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 448.75 | 352.25 |  1.27 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 287.59 | 162.22 |  1.77 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 333.61 | 185.41 |  1.80 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 289.56 | 174.01 |  1.66 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 423.84 | 233.05 |  1.82 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 448.30 | 232.39 |  1.93 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 241.72 | 133.97 |  1.80 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 341.99 | 200.29 |  1.71 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 860.10 | 422.88 |  2.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 563.74 | 273.94 |  2.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 329.53 | 179.63 |  1.83 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 383.65 | 205.87 |  1.86 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 390.51 | 207.69 |  1.88 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 532.60 | 271.63 |  1.96 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 353.01 | 195.05 |  1.81 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 551.59 | 320.22 |  1.72 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 444.02 | 241.67 |  1.84 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 384.80 | 219.50 |  1.75 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "[a-zA-Z]+ing", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 26088914.29 | 15570846.15 |  1.68 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20028481.82 | 10493512.50 |  1.91 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 34340091.67 | 18784559.09 |  1.83 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 63860125.00 | 28669443.75 |  2.23 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31004585.71 | 16376081.25 |  1.89 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33259233.33 | 19027676.92 |  1.75 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31626321.43 | 17343154.17 |  1.82 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 47569150.00 | 25535906.25 |  1.86 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 43581050.00 | 22447150.00 |  1.94 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19577709.91 | 11429215.22 |  1.71 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32094407.14 | 17731125.32 |  1.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 69464576.88 | 39131628.42 |  1.78 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 50296852.00 | 28272788.00 |  1.78 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30422231.25 | 16137058.33 |  1.89 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30685512.50 | 16032908.33 |  1.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30645700.00 | 16269050.00 |  1.88 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 47212825.00 | 23658006.25 |  2.00 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30692291.67 | 18681654.55 |  1.64 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 66735750.00 | 35506241.67 |  1.88 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41946015.63 | 22353909.72 |  1.88 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37281542.83 | 19982384.60 |  1.87 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "(?i)Tom|Sawyer|Huckleberry|Finn", Options: Compiled)

| Result |         Base |         Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ------------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  87844500.00 |  47548250.00 |  1.85 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  67002325.00 |  35964385.71 |  1.86 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103136900.00 |  57799350.00 |  1.78 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 143154200.00 |  79398850.00 |  1.80 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  89574900.00 |  51805150.00 |  1.73 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  94839950.00 |  57651600.00 |  1.65 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103496550.00 |  61470675.00 |  1.68 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 159912600.00 |  84440700.00 |  1.89 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 145845700.00 |  78605675.00 |  1.86 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  70028488.63 |  37937829.17 |  1.85 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 110162960.50 |  56663333.75 |  1.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 207686688.50 | 108834558.00 |  1.91 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 149866925.50 |  79368574.50 |  1.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 101101300.00 |  51758187.50 |  1.95 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 102647700.00 |  53883362.50 |  1.90 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 104190850.00 |  53274812.50 |  1.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 141396500.00 |  81408050.00 |  1.74 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 115250150.00 |  54382850.00 |  2.12 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 166315900.00 |  96638825.00 |  1.72 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138116072.00 |  71682005.88 |  1.93 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 125757682.00 |  64419015.38 |  1.95 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesWord(Options: IgnoreCase, Compiled)

| Result |     Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| -------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  3008.33 | 1333.21 |  2.26 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  2029.19 |  986.42 |  2.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3174.85 | 1565.58 |  2.03 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4504.03 | 2913.58 |  1.55 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3096.34 | 1473.27 |  2.10 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3246.48 | 1365.98 |  2.38 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3250.48 | 1529.61 |  2.13 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4477.68 | 2064.02 |  2.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4252.70 | 2070.76 |  2.05 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  2397.37 | 1289.26 |  1.86 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3743.55 | 1834.15 |  2.04 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10733.41 | 5936.96 |  1.81 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5257.45 | 2611.22 |  2.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4180.42 | 2157.50 |  1.94 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4444.58 | 2007.72 |  2.21 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4529.56 | 2364.90 |  1.92 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6152.84 | 3144.47 |  1.96 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3550.87 | 1782.22 |  1.99 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6963.37 | 4351.02 |  1.60 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4607.50 | 2362.88 |  1.95 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4081.43 | 2168.50 |  1.88 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)the", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2182421.35 |  996195.31 |  2.19 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1558724.06 |  741427.84 |  2.10 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2409175.00 | 1119347.60 |  2.15 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 6285665.63 | 1615275.63 |  3.89 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2234505.47 | 1013611.46 |  2.20 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2213518.75 |  994011.72 |  2.23 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2518359.90 | 1103568.75 |  2.28 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3402022.50 | 1474855.40 |  2.31 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4048320.31 | 1441671.02 |  2.81 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1907635.45 | 1004920.02 |  1.90 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2440249.39 | 1241227.82 |  1.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4406632.83 | 2426584.63 |  1.82 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3355510.24 | 1775007.02 |  1.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2329866.67 | 1177037.50 |  1.98 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2527077.08 | 1392121.02 |  1.82 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2577696.43 | 1354263.80 |  1.90 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3560015.00 | 2049028.91 |  1.74 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2624354.17 | 1206727.16 |  2.17 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3976757.81 | 2180845.83 |  1.82 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3221284.04 | 1691251.08 |  1.90 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2873189.26 | 1539386.59 |  1.87 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "[a-zA-Z]+ing", Options: Compiled)

| Result |        Base |       Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ----------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  8129112.50 | 4175450.00 |  1.95 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6504210.42 | 2991046.88 |  2.17 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9621731.25 | 5191213.28 |  1.85 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15998188.46 | 6910008.33 |  2.32 |          +0 | several?   | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9367975.00 | 4483887.50 |  2.09 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10628996.88 | 4752769.53 |  2.24 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10181809.38 | 4767613.28 |  2.14 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15292906.67 | 6842238.54 |  2.24 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17901678.13 | 5895400.00 |  3.04 |          +0 | bimodal    | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6401563.42 | 3578614.55 |  1.79 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10047830.60 | 4920063.84 |  2.04 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23887151.75 | 9247089.19 |  2.58 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13962523.75 | 7570657.18 |  1.84 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10176893.75 | 4876131.25 |  2.09 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10578425.00 | 4898264.06 |  2.16 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10300243.75 | 4935803.13 |  2.09 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15943963.33 | 6523737.50 |  2.44 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12225203.13 | 6087470.83 |  2.01 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20715222.73 | 7592156.25 |  2.73 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12568701.28 | 6395293.53 |  1.97 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11395458.48 | 5753375.35 |  1.98 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesWords(Options: Compiled)

| Result |     Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| -------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  5246.53 | 2183.09 |  2.40 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3587.84 | 1479.55 |  2.42 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6344.47 | 2983.86 |  2.13 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 12057.25 | 3714.13 |  3.25 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5650.84 | 2353.64 |  2.40 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5644.60 | 2225.04 |  2.54 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6208.98 | 2455.12 |  2.53 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8399.09 | 3291.62 |  2.55 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9419.67 | 3364.15 |  2.80 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4025.13 | 2034.67 |  1.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6779.70 | 3021.68 |  2.24 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16429.62 | 8698.94 |  1.89 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8931.13 | 4194.49 |  2.13 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6644.91 | 3386.66 |  1.96 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7211.60 | 3926.28 |  1.84 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6966.14 | 3781.08 |  1.84 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11880.05 | 5125.27 |  2.32 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7262.61 | 2826.42 |  2.57 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11187.06 | 6536.04 |  1.71 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8667.00 | 3936.06 |  2.20 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7910.66 | 3636.99 |  2.18 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.SplitWords(Options: Compiled)

| Result |     Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  5054.17 | 1993.64 |  2.54 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3696.36 | 1451.64 |  2.55 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6312.74 | 2576.46 |  2.45 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11800.19 | 3680.74 |  3.21 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5524.44 | 2159.17 |  2.56 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5659.13 | 1992.77 |  2.84 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6054.13 | 2234.03 |  2.71 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8147.24 | 3011.14 |  2.71 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9331.21 | 3112.76 |  3.00 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3882.10 | 1766.69 |  2.20 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6524.68 | 2760.56 |  2.36 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16335.31 | 8543.90 |  1.91 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8647.48 | 4219.84 |  2.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6662.13 | 3211.65 |  2.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6944.21 | 3414.13 |  2.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6512.90 | 3359.16 |  1.94 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11401.41 | 4328.92 |  2.63 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7387.41 | 2850.22 |  2.59 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11362.99 | 6487.87 |  1.75 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8668.76 | 3898.87 |  2.22 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7819.92 | 3525.89 |  2.22 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.ReplaceWords(Options: Compiled)

| Result |     Base |    Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| -------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  4935.13 | 2018.31 |  2.45 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3804.34 | 1500.58 |  2.54 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6804.94 | 2876.34 |  2.37 |          +0 | bimodal    | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11902.56 | 3669.52 |  3.24 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5517.14 | 2191.43 |  2.52 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5713.82 | 2074.56 |  2.75 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6078.02 | 2305.20 |  2.64 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8219.25 | 3110.91 |  2.64 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9199.78 | 3213.11 |  2.86 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3841.58 | 1690.61 |  2.27 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6692.43 | 2797.79 |  2.39 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16233.48 | 8637.21 |  1.88 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8851.56 | 4147.19 |  2.13 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6439.77 | 3123.06 |  2.06 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6460.11 | 3328.56 |  1.94 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6419.24 | 3242.55 |  1.98 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11553.85 | 4452.13 |  2.60 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7885.87 | 2863.16 |  2.75 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11501.34 | 6754.99 |  1.70 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8574.12 | 3747.76 |  2.29 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7699.55 | 3441.53 |  2.24 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: ".{0,2}(Tom|Sawyer|Huckleberry|Finn)", Options: Compiled)

| Result |          Base |          Diff | Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------------:| -------------:| -----:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1088827800.00 |  370520050.00 |  2.94 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  834331950.00 |  296062600.00 |  2.82 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1147118150.00 |  525668300.00 |  2.18 |          +0 | bimodal    | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1601392450.00 |  984856500.00 |  1.63 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1011087550.00 |  453059500.00 |  2.23 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1346187800.00 |  559058650.00 |  2.41 |          +0 | multimodal | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1146165900.00 |  510853950.00 |  2.24 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1727335600.00 |  727848800.00 |  2.37 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1709324200.00 |  703746050.00 |  2.43 |          +0 | several?   | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  869834936.00 |  328090193.00 |  2.65 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1148238387.00 |  549984440.00 |  2.09 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2801500463.50 | 1046112205.00 |  2.68 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2227600007.00 |  754706917.00 |  2.95 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1007657250.00 |  484194100.00 |  2.08 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  993503550.00 |  488254400.00 |  2.03 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1007016000.00 |  490070500.00 |  2.05 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2060790000.00 |  705486100.00 |  2.92 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1213391650.00 |  536282800.00 |  2.26 |          +0 | bimodal    | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1858050100.00 |  774421450.00 |  2.40 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1415828149.00 |  688357845.50 |  2.06 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1325122792.00 |  626795014.50 |  2.11 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: ".{2,4}(Tom|Sawyer|Huckleberry|Finn)", Options: Compiled)

| Result |          Base |          Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------------:| -------------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1048741800.00 |  380549500.00 |  2.76 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  831643700.00 |  305483400.00 |  2.72 |          +0 | several? | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1157892350.00 |  571224800.00 |  2.03 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1564121850.00 |  848800200.00 |  1.84 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1004801400.00 |  457556100.00 |  2.20 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1247124700.00 |  541831300.00 |  2.30 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1052623300.00 |  506899500.00 |  2.08 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1580614300.00 |  731720400.00 |  2.16 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1578069300.00 |  635027150.00 |  2.49 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  872396232.00 |  325978643.00 |  2.68 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1224765235.00 |  548925444.00 |  2.23 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2899932376.00 | 1094232082.00 |  2.65 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2035652851.50 |  778634513.00 |  2.61 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1242189400.00 |  494034400.00 |  2.51 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1238164000.00 |  493958300.00 |  2.51 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1241751500.00 |  491980200.00 |  2.52 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1858553700.00 |  706665000.00 |  2.63 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1630548400.00 |  580908800.00 |  2.81 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1897864300.00 |  811127550.00 |  2.34 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1606726518.00 |  697622000.00 |  2.30 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1418036712.00 |  638603411.00 |  2.22 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock Holmes", Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 477365.25 | 116269.82 |  4.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 252006.85 |  79689.67 |  3.16 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 481041.31 | 158650.00 |  3.03 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 674397.14 | 215936.82 |  3.12 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 395045.16 | 138902.63 |  2.84 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 375755.36 | 145339.24 |  2.59 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 419155.26 | 156669.96 |  2.68 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 562310.71 | 206238.24 |  2.73 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 712139.81 | 191324.04 |  3.72 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 268734.54 |  86388.88 |  3.11 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 474984.72 | 149677.28 |  3.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 819176.22 | 338311.87 |  2.42 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 675215.25 | 243500.15 |  2.77 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 417261.68 | 142051.59 |  2.94 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 414595.56 | 166825.92 |  2.49 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 415517.02 | 143872.39 |  2.89 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 749324.85 | 339378.94 |  2.21 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 465621.88 | 166320.61 |  2.80 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Same   | 776404.02 | 795456.62 |  0.98 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 637408.71 | 192314.73 |  3.31 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 549448.95 | 177429.16 |  3.10 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sher[a-z]+|Hol[a-z]+", Options: Compiled)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2006419.79 |  721487.22 |  2.78 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1497042.61 |  577499.42 |  2.59 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2200420.54 |  873025.17 |  2.52 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3196033.59 | 1569209.72 |  2.04 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2032142.71 |  786351.88 |  2.58 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1967103.13 |  764395.24 |  2.57 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2137564.84 |  876173.61 |  2.44 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2860400.00 | 1162383.26 |  2.46 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3482397.66 | 1058646.43 |  3.29 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1901800.44 |  620541.72 |  3.06 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2843361.78 |  887650.78 |  3.20 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5334717.57 | 2117174.07 |  2.52 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4172584.84 | 1486168.34 |  2.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2485391.96 |  834338.82 |  2.98 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2523127.68 | 1078125.42 |  2.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2526073.75 |  854787.50 |  2.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2981068.23 | 2090442.97 |  1.43 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2876559.38 | 1091239.58 |  2.64 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4008800.00 | 2130053.13 |  1.88 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3563084.66 | 1123589.70 |  3.17 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3239127.77 | 1032582.50 |  3.14 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Tom|Sawyer|Huckleberry|Finn", Options: None)

| Result |         Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  36106025.00 | 15383734.38 |  2.35 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  27679633.33 | 10411914.58 |  2.66 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  48374950.00 | 18311608.33 |  2.64 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  68642475.00 | 37102716.67 |  1.85 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  43150125.00 | 15855603.85 |  2.72 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  43203037.50 | 17214587.50 |  2.51 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  46253150.00 | 16846007.69 |  2.75 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  66077300.00 | 25557994.44 |  2.59 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  67616425.00 | 22696305.56 |  2.98 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  28936063.06 | 10862898.03 |  2.66 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  50014052.25 | 16833596.38 |  2.97 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103705583.75 | 41447016.50 |  2.50 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  79597808.38 | 30820815.29 |  2.58 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  44981900.00 | 16119691.67 |  2.79 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  46578250.00 | 17510012.50 |  2.66 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  45584525.00 | 15994908.33 |  2.85 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  63308050.00 | 28859771.43 |  2.19 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  49703825.00 | 18038395.83 |  2.76 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100621950.00 | 51016050.00 |  1.97 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  66161209.75 | 21173708.56 |  3.12 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  57355538.13 | 19280740.18 |  2.97 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchWord(Options: IgnoreCase, Compiled)

| Result |    Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| ------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  330.62 | 132.18 |  2.50 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  240.03 |  86.30 |  2.78 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  407.05 | 162.46 |  2.51 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  761.57 | 290.74 |  2.62 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  347.98 | 135.82 |  2.56 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  370.61 | 135.60 |  2.73 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  397.08 | 152.40 |  2.61 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  531.02 | 201.41 |  2.64 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  493.64 | 203.31 |  2.43 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  322.51 | 119.96 |  2.69 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  449.13 | 183.73 |  2.44 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1318.12 | 407.66 |  3.23 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  666.14 | 250.73 |  2.66 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  506.74 | 158.12 |  3.20 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  513.57 | 189.24 |  2.71 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  518.49 | 175.26 |  2.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  591.80 | 257.68 |  2.30 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  428.89 | 173.73 |  2.47 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  925.17 | 341.73 |  2.71 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  612.94 | 219.78 |  2.79 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  560.68 | 204.47 |  2.74 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock Holmes", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 311535.75 |  75211.96 |  4.14 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 257538.93 |  55196.82 |  4.67 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 348952.66 | 110369.86 |  3.16 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 516636.04 | 149185.74 |  3.46 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 338917.82 |  98359.55 |  3.45 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 346110.97 | 104821.08 |  3.30 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 384289.64 | 115439.06 |  3.33 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 509401.66 | 153975.31 |  3.31 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 563960.37 | 143960.06 |  3.92 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 280958.04 |  59772.13 |  4.70 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 357124.83 | 105647.11 |  3.38 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 632265.51 | 248415.23 |  2.55 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 493466.06 | 178339.49 |  2.77 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 346360.60 |  96527.35 |  3.59 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 342841.58 | 116973.37 |  2.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 343917.66 | 100361.50 |  3.43 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 526815.00 | 279047.27 |  1.89 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 345265.91 | 109489.77 |  3.15 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Slower | 569780.58 | 708146.59 |  0.80 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 462836.86 | 137512.50 |  3.37 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 421527.57 | 127086.46 |  3.32 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "(?i)Twain", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 29595350.00 |  6569703.13 |  4.50 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15723216.67 |  4996314.06 |  3.15 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 29121562.50 |  8435978.13 |  3.45 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41778250.00 | 11443150.00 |  3.65 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 24385244.44 |  7526106.25 |  3.24 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23798772.22 |  7580189.58 |  3.14 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26289237.50 |  8591404.69 |  3.06 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37880975.00 | 12651587.50 |  2.99 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 35128033.33 | 12463375.00 |  2.82 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16515530.18 |  5272309.11 |  3.13 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28914545.86 |  8130879.70 |  3.56 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49344826.75 | 15724447.91 |  3.14 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41682442.00 | 11653355.57 |  3.58 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25238187.50 |  7854196.88 |  3.21 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25380425.00 |  7988303.13 |  3.18 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25439437.50 |  7845543.75 |  3.24 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45937175.00 | 14678945.45 |  3.13 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27246756.25 |  9306812.50 |  2.93 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 48136112.50 | 22328556.25 |  2.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 38647884.17 | 10390928.63 |  3.72 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32967388.00 |  9327777.02 |  3.53 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.Backtracking(Options: Compiled)

| Result |    Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  335.76 | 129.53 |  2.59 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  259.02 |  82.58 |  3.14 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  465.68 | 160.30 |  2.91 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  662.62 | 217.76 |  3.04 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  376.15 | 125.59 |  3.00 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  497.11 | 128.42 |  3.87 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  465.50 | 138.47 |  3.36 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  699.72 | 182.22 |  3.84 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  749.28 | 191.28 |  3.92 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  320.17 | 126.45 |  2.53 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  539.44 | 174.15 |  3.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1481.07 | 326.32 |  4.54 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  757.26 | 243.77 |  3.11 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  476.62 | 147.70 |  3.23 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  500.36 | 174.18 |  2.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  500.34 | 173.34 |  2.89 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  760.97 | 236.45 |  3.22 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  570.33 | 149.88 |  3.81 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  827.44 | 269.14 |  3.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  707.20 | 218.52 |  3.24 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  626.09 | 205.30 |  3.05 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock", Options: None)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  630033.88 | 116595.66 |  5.40 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  324288.71 |  81092.24 |  4.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  621293.75 | 156316.69 |  3.97 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  874367.88 | 213174.83 |  4.10 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  491971.29 | 140206.53 |  3.51 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  464249.54 | 145837.38 |  3.18 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  528558.67 | 157153.90 |  3.36 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  730959.78 | 205162.06 |  3.56 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  762248.30 | 205121.96 |  3.72 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  334620.73 |  86584.97 |  3.86 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  604671.97 | 148905.19 |  4.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1030895.80 | 331427.91 |  3.11 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  858970.67 | 240670.75 |  3.57 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  506386.25 | 140395.42 |  3.61 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  505514.42 | 160917.01 |  3.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  507341.83 | 143290.14 |  3.54 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1005741.80 | 339371.81 |  2.96 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  612897.75 | 167105.19 |  3.67 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1032324.41 | 793763.60 |  1.30 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  822749.97 | 191280.08 |  4.30 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  696211.09 | 177725.72 |  3.92 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "(?i)Twain", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 20756955.00 |  4439456.25 |  4.68 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17151269.23 |  3698025.00 |  4.64 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 24254177.78 |  5873960.42 |  4.13 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33524466.67 |  7859753.13 |  4.27 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22762390.00 |  5255236.46 |  4.33 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23291583.33 |  5383997.92 |  4.33 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25482312.50 |  5841006.25 |  4.36 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37212666.67 |  9655745.31 |  3.85 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33843750.00 |  8674296.88 |  3.90 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17456046.17 |  4146700.55 |  4.21 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23483844.67 |  5857800.94 |  4.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41202652.63 | 11805889.73 |  3.49 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32298841.25 |  8296986.81 |  3.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22550111.11 |  5592337.50 |  4.03 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22652038.89 |  5873433.33 |  3.86 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22423711.11 |  5600761.46 |  4.00 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 33606250.00 | 11119534.38 |  3.02 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23992750.00 |  6256713.54 |  3.83 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36270150.00 | 16279486.67 |  2.23 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 29892367.83 |  7488892.00 |  3.99 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26835417.44 |  6648313.32 |  4.04 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes|Watson", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1266665.63 |  359366.76 |  3.52 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  977110.94 |  258315.63 |  3.78 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1690983.13 |  453580.98 |  3.73 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2396229.91 |  890370.70 |  2.69 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1499299.43 |  385853.98 |  3.89 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1520223.66 |  414280.21 |  3.67 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1598071.88 |  396418.75 |  4.03 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2169521.09 |  601387.96 |  3.61 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2005148.75 |  489450.69 |  4.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1129245.79 |  295783.31 |  3.82 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2141048.55 |  415039.72 |  5.16 |          +0 | several? | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3578145.84 | 1043007.24 |  3.43 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2740253.28 |  766506.54 |  3.57 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1690591.07 |  424976.15 |  3.98 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1617216.56 |  457742.10 |  3.53 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1612595.63 |  434290.63 |  3.71 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2203408.75 |  725091.05 |  3.04 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1747129.86 |  410748.82 |  4.25 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3510925.00 | 1312649.43 |  2.67 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2347136.01 |  561666.62 |  4.18 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2035650.10 |  489989.11 |  4.15 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Holmes.{0,25}Watson|Watson.{0,25}Holmes", Options: None)

| Result |       Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1281270.67 |  403264.43 |  3.18 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  988861.72 |  282988.73 |  3.49 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1729163.13 |  459499.81 |  3.76 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3165517.19 |  675627.97 |  4.69 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1524843.18 |  404481.62 |  3.77 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1554775.85 |  433449.43 |  3.59 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1652434.69 |  409467.79 |  4.04 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2222894.53 |  586294.08 |  3.79 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2586796.09 |  520922.20 |  4.97 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1072302.63 |  286627.21 |  3.74 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1787938.44 |  431535.57 |  4.14 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3575608.40 | 1050802.02 |  3.40 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2707917.17 |  753481.36 |  3.59 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1632458.93 |  422539.27 |  3.86 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1601863.13 |  441176.56 |  3.63 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1621331.88 |  410177.93 |  3.95 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2238004.17 |  712737.23 |  3.14 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1775596.88 |  468093.48 |  3.79 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3577973.44 | 1130776.20 |  3.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2361777.69 |  551032.32 |  4.29 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2059418.92 |  499281.11 |  4.12 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Tom|Sawyer|Huckleberry|Finn", Options: Compiled)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 16973353.33 |  3987570.31 |  4.26 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14208600.00 |  3231996.25 |  4.40 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22845590.91 |  4459564.06 |  5.12 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31275325.00 |  8387635.71 |  3.73 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20696779.17 |  3851085.94 |  5.37 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19670358.33 |  4159271.88 |  4.73 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21547616.67 |  4441850.78 |  4.85 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30968293.75 |  7077752.78 |  4.38 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31718921.43 |  6312085.42 |  5.03 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14455773.63 |  3522660.84 |  4.10 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22638895.73 |  4613727.71 |  4.91 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 40892498.00 | 11140516.00 |  3.67 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30475284.81 |  7867743.98 |  3.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21314133.33 |  4106335.16 |  5.19 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21152483.33 |  4768043.75 |  4.44 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21272445.83 |  4055469.53 |  5.25 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 39707616.67 |  9428956.25 |  4.21 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18641457.14 |  5126159.38 |  3.64 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 56902662.50 | 25604535.00 |  2.22 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28262431.56 |  5673659.42 |  4.98 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25864848.00 |  5030865.77 |  5.14 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock Holmes", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 246677.42 |  38388.72 |  6.43 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 203083.59 |  31704.73 |  6.41 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 288729.27 |  59803.80 |  4.83 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 406965.46 |  80906.68 |  5.03 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 285507.78 |  46660.62 |  6.12 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 278487.50 |  46556.24 |  5.98 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 309767.22 |  52997.09 |  5.84 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 412149.51 |  73895.18 |  5.58 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 384224.52 |  64101.73 |  5.99 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 206448.47 |  34739.37 |  5.94 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 286416.61 |  56611.50 |  5.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 474964.24 | 140911.04 |  3.37 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 358328.32 |  98661.27 |  3.63 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 285086.93 |  52177.70 |  5.46 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 284139.55 |  66129.24 |  4.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 283835.94 |  54169.32 |  5.24 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 419082.89 |  99926.84 |  4.19 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 256985.61 |  57903.90 |  4.44 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 405499.84 | 282690.63 |  1.43 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 359356.48 |  77651.63 |  4.63 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 331818.90 |  69366.71 |  4.78 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.MatchesWords(Options: IgnoreCase, Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 13320.04 |  2715.04 |  4.91 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8220.04 |  1856.87 |  4.43 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16560.26 |  3605.34 |  4.59 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23910.19 |  6096.54 |  3.92 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14614.29 |  2938.34 |  4.97 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14766.29 |  2934.49 |  5.03 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15211.49 |  3148.33 |  4.83 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20376.55 |  4392.03 |  4.64 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19157.80 |  4447.53 |  4.31 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10890.33 |  2485.97 |  4.38 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19232.11 |  3582.26 |  5.37 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45507.64 | 10547.07 |  4.31 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27403.48 |  5522.65 |  4.96 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19120.15 |  3986.70 |  4.80 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19474.63 |  4767.60 |  4.08 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19521.32 |  4501.12 |  4.34 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22738.05 |  6159.26 |  3.69 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19850.10 |  3645.44 |  5.45 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31976.46 |  9205.22 |  3.47 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 24117.53 |  4735.37 |  5.09 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22085.24 |  4354.66 |  5.07 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "([A-Za-z]awyer|[A-Za-z]inn)\s", Options: Compiled)

| Result |         Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  63469675.00 | 12024196.88 |  5.28 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  49626925.00 |  9545193.75 |  5.20 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  76991525.00 | 14647488.24 |  5.26 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 104593600.00 | 25362400.00 |  4.12 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  69473600.00 | 13275868.42 |  5.23 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  64843700.00 | 12859778.95 |  5.04 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  70804225.00 | 14495723.53 |  4.88 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  99188100.00 | 20737087.50 |  4.78 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90066712.50 | 19377776.92 |  4.65 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  50101007.25 | 10066227.09 |  4.98 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  76223983.63 | 14790499.21 |  5.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 136079133.50 | 31694922.25 |  4.29 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96145762.50 | 22339529.45 |  4.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  69157125.00 | 14003361.11 |  4.94 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  69342262.50 | 17119253.33 |  4.05 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  69058050.00 | 14099908.33 |  4.90 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  98802125.00 | 33763228.57 |  2.93 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  70407625.00 | 15207806.25 |  4.63 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 119954600.00 | 28840650.00 |  4.16 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  96848148.88 | 18398209.31 |  5.26 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  87771786.50 | 16943880.47 |  5.18 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock Holmes", Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 314987.31 |  41981.64 |  7.50 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 187579.80 |  34876.49 |  5.38 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 340090.00 |  66459.17 |  5.12 |          +0 | bimodal  | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 481559.00 |  90613.00 |  5.31 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 297831.85 |  51341.75 |  5.80 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 277954.28 |  51198.97 |  5.43 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 315325.88 |  57646.53 |  5.47 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 412889.31 |  81198.71 |  5.08 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 386889.84 |  70022.26 |  5.53 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 192813.38 |  37880.96 |  5.09 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 337357.30 |  62624.50 |  5.39 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 514427.53 | 147867.38 |  3.48 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 431388.76 | 105285.57 |  4.10 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 305186.27 |  57328.79 |  5.32 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 304968.26 |  70025.62 |  4.36 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 304702.40 |  59199.06 |  5.15 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 494301.95 | 105194.81 |  4.70 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 307527.04 |  61213.49 |  5.02 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 557765.41 | 293693.69 |  1.90 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 447971.98 |  84861.10 |  5.28 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 390089.10 |  75128.19 |  5.19 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "(?i)Sherlock", Options: Compiled)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  513971.88 |  77559.41 |  6.63 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  410693.11 |  58203.54 |  7.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  560100.23 | 111265.34 |  5.03 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  799006.41 | 152425.09 |  5.24 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  547763.69 |  99727.39 |  5.49 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  574395.54 | 106841.35 |  5.38 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  628174.75 | 115093.43 |  5.46 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  791744.53 | 155704.46 |  5.08 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1057850.89 | 145961.82 |  7.25 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  428660.61 |  60447.78 |  7.09 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  581984.81 | 106699.90 |  5.45 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  988395.33 | 261326.44 |  3.78 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  783010.08 | 179902.06 |  4.35 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  558066.18 |  97879.65 |  5.70 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  556915.40 | 119794.37 |  4.65 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  559135.27 | 100353.90 |  5.57 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  804795.00 | 281557.48 |  2.86 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  582081.02 | 112612.81 |  5.17 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  914966.04 | 713231.53 |  1.28 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  750172.52 | 138840.70 |  5.40 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  674430.88 | 129531.33 |  5.21 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.ReplaceWords(Options: IgnoreCase, Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 13646.25 |  2576.47 |  5.30 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8295.79 |  1876.98 |  4.42 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16623.34 |  3191.22 |  5.21 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30988.79 |  5326.23 |  5.82 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14690.67 |  2773.45 |  5.30 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14769.47 |  2764.72 |  5.34 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15227.85 |  3046.50 |  5.00 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20585.54 |  4262.52 |  4.83 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19715.16 |  4268.43 |  4.62 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10543.73 |  2188.41 |  4.82 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19811.72 |  3427.10 |  5.78 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 40649.93 | 10699.56 |  3.80 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27566.13 |  5420.90 |  5.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18715.77 |  3770.54 |  4.96 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19102.19 |  4225.57 |  4.52 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18812.87 |  3932.72 |  4.78 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22317.12 |  5658.85 |  3.94 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18837.84 |  4001.59 |  4.71 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32040.89 |  9258.05 |  3.46 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23971.58 |  4528.89 |  5.29 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22165.29 |  4232.00 |  5.24 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.SplitWords(Options: IgnoreCase, Compiled)

| Result |     Base |     Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| --------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 13373.92 |  2535.40 |  5.27 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8278.42 |  1812.29 |  4.57 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18096.85 |  3248.95 |  5.57 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31759.74 |  4613.40 |  6.88 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 14725.92 |  2716.67 |  5.42 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 15483.37 |  2696.05 |  5.74 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 16540.65 |  3058.65 |  5.41 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22369.23 |  4100.75 |  5.45 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21575.64 |  4173.85 |  5.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10615.70 |  2201.97 |  4.82 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19728.76 |  3438.17 |  5.74 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 40408.23 | 10578.94 |  3.82 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27200.23 |  5515.09 |  4.93 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19178.15 |  3819.46 |  5.02 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19203.20 |  4360.13 |  4.40 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19405.79 |  3988.36 |  4.87 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22585.43 |  5415.27 |  4.17 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19620.16 |  3614.32 |  5.43 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31867.12 |  9222.68 |  3.46 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25297.09 |  4658.29 |  5.43 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22796.73 |  4312.77 |  5.29 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Holmes", Options: None)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  647313.59 |  92633.95 |  6.99 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  387506.64 |  69796.94 |  5.55 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  680801.22 | 124888.94 |  5.45 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1210944.58 | 247113.80 |  4.90 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  590926.16 | 103798.99 |  5.69 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  561507.33 | 102338.53 |  5.49 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  618979.09 | 110658.09 |  5.59 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  821051.15 | 148369.40 |  5.53 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1028248.13 | 141269.80 |  7.28 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  408846.96 |  81090.01 |  5.04 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  667535.79 | 124538.59 |  5.36 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1029888.48 | 262802.45 |  3.92 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  857624.10 | 190072.26 |  4.51 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  602994.23 | 112666.34 |  5.35 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  610075.24 | 135435.67 |  4.50 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  615375.00 | 123396.31 |  4.99 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1012205.08 | 192402.13 |  5.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  633070.00 | 123894.49 |  5.11 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1142884.15 | 396253.82 |  2.88 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  904058.10 | 169786.12 |  5.32 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  773314.11 | 153068.42 |  5.05 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sher[a-z]+|Hol[a-z]+", Options: None)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1205103.13 | 266452.44 |  4.52 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  921328.49 | 190617.15 |  4.83 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1618203.13 | 327196.19 |  4.95 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2932948.44 | 454338.57 |  6.46 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1413166.76 | 266626.19 |  5.30 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1416025.00 | 279728.24 |  5.06 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1511658.24 | 277114.51 |  5.45 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2051097.66 | 430304.56 |  4.77 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1983375.00 | 356765.41 |  5.56 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1016773.30 | 200748.93 |  5.06 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1692374.61 | 305986.04 |  5.53 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3347147.00 | 710549.60 |  4.71 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2571557.26 | 533176.89 |  4.82 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1552332.67 | 287322.16 |  5.40 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1540835.80 | 329642.73 |  4.67 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1536371.02 | 304673.44 |  5.04 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2074706.25 | 528836.68 |  3.92 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1616056.25 | 320560.34 |  5.04 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3377485.94 | 919652.50 |  3.67 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2235177.08 | 405419.08 |  5.51 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1952474.51 | 359668.18 |  5.43 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.OneNodeBacktracking(Options: None)

| Result |     Base |    Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | --------:| -------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  4154.76 |  899.01 |  4.62 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3124.30 |  659.51 |  4.74 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5234.66 | 1084.53 |  4.83 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10122.24 | 2352.32 |  4.30 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4760.06 |  945.79 |  5.03 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6545.20 | 1200.61 |  5.45 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5381.01 | 1050.22 |  5.12 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8062.35 | 1449.48 |  5.56 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8626.24 | 1413.74 |  6.10 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3272.32 |  659.04 |  4.97 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4980.87 | 1022.54 |  4.87 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11510.24 | 2349.13 |  4.90 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7824.36 | 1599.61 |  4.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4653.45 |  915.39 |  5.08 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4702.47 |  917.76 |  5.12 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4610.72 |  916.74 |  5.03 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7759.30 | 1444.92 |  5.37 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4996.33 | 1085.05 |  4.60 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 10016.14 | 1950.50 |  5.14 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6559.77 | 1337.68 |  4.90 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5799.63 | 1192.80 |  4.86 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock|Holmes", Options: None)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1182414.90 | 247686.41 |  4.77 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  909459.03 | 177440.38 |  5.13 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1587036.25 | 303278.42 |  5.23 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2226552.68 | 577178.01 |  3.86 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1388400.00 | 254901.86 |  5.45 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1381097.40 | 258148.33 |  5.35 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1495464.77 | 260846.00 |  5.73 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2038025.00 | 394030.00 |  5.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1863532.42 | 330848.47 |  5.63 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1008016.22 | 194471.72 |  5.18 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1663216.29 | 279348.44 |  5.95 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3309421.64 | 695090.44 |  4.76 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2532313.58 | 551156.98 |  4.59 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1513230.68 | 270376.91 |  5.60 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1517757.39 | 310374.75 |  4.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1508746.59 | 287194.66 |  5.25 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2037503.75 | 509219.05 |  4.00 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1652285.00 | 288746.42 |  5.72 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3334062.50 | 877160.42 |  3.80 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2197681.19 | 386567.31 |  5.69 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1919005.52 | 337892.74 |  5.68 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Holmes", Options: Compiled)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  573126.04 |  76449.70 |  7.50 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  459101.93 |  55130.13 |  8.33 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  681855.16 |  98208.57 |  6.94 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1080067.41 | 200499.44 |  5.39 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  628905.88 |  84601.39 |  7.43 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  642387.13 |  83831.45 |  7.66 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  711527.27 |  92723.69 |  7.67 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  951542.28 | 125662.91 |  7.57 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1294461.08 | 120210.57 | 10.77 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  475597.93 |  72554.10 |  6.56 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  636490.74 | 105058.16 |  6.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1048613.35 | 228107.64 |  4.60 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  810995.19 | 166289.28 |  4.88 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  641161.25 |  95664.56 |  6.70 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  648739.50 | 116667.09 |  5.56 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  644678.75 | 104120.33 |  6.19 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  940762.32 | 168856.65 |  5.57 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  612982.45 | 100500.59 |  6.10 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  955849.61 | 355800.46 |  2.69 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  814579.62 | 143311.84 |  5.68 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  739567.24 | 128041.91 |  5.78 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock\s+Holmes", Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 433630.00 |  45990.24 |  9.43 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 255254.99 |  36875.87 |  6.92 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 452139.98 |  65473.79 |  6.91 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 647325.50 |  94980.82 |  6.82 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 384119.28 |  54872.89 |  7.00 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 362179.07 |  57198.98 |  6.33 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 412049.49 |  59335.27 |  6.94 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 529061.67 |  85832.00 |  6.16 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 496568.53 |  74258.64 |  6.69 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 259144.75 |  40207.72 |  6.45 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 439979.95 |  66880.78 |  6.58 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 675974.55 | 161013.18 |  4.20 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 562718.10 | 113925.91 |  4.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 391768.75 |  60081.93 |  6.52 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 390346.56 |  75800.97 |  5.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 389091.77 |  61816.88 |  6.29 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 682050.41 | 110214.79 |  6.19 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 407269.07 |  69547.41 |  5.86 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 768892.56 | 300424.51 |  2.56 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 597234.01 |  89105.92 |  6.70 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 509398.54 |  79644.91 |  6.40 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "The", Options: Compiled)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  684211.22 |  96929.19 |  7.06 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  542503.88 |  68710.70 |  7.90 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  851883.55 | 120469.56 |  7.07 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1518698.01 | 175671.07 |  8.65 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  817318.91 | 108069.23 |  7.56 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  766290.94 | 101213.58 |  7.57 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  842776.64 | 108251.00 |  7.79 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1218364.66 | 166392.01 |  7.32 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1054580.58 | 140905.72 |  7.48 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  567925.62 |  93970.96 |  6.04 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  823744.45 | 124459.51 |  6.62 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1498234.20 | 273734.31 |  5.47 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1031325.73 | 196571.68 |  5.25 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  809809.84 | 116123.71 |  6.97 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  815321.71 | 143769.31 |  5.67 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  815711.18 | 129491.74 |  6.30 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1175380.77 | 201130.69 |  5.84 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  741899.38 | 118774.90 |  6.25 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1177434.62 | 401396.88 |  2.93 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1091549.42 | 185201.45 |  5.89 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  982211.39 | 158957.22 |  6.18 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Huck[a-zA-Z]+|Saw[a-zA-Z]+", Options: None)

| Result |        Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 30438325.00 |  5819000.00 |  5.23 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23192972.73 |  3619511.46 |  6.41 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 41129725.00 |  6867925.00 |  5.99 |          +0 | several? | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 57787425.00 | 14365553.85 |  4.02 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36283500.00 |  5654966.67 |  6.42 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36958150.00 |  6635539.06 |  5.57 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 39472500.00 |  5995885.42 |  6.58 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 56739775.00 | 10167192.00 |  5.58 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 58787012.50 |  8880928.13 |  6.62 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 25575302.05 |  3780522.26 |  6.77 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 43495015.00 |  6456684.28 |  6.74 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 86455703.75 | 17452480.54 |  4.95 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 67117394.25 | 12072475.97 |  5.56 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 38963600.00 |  6136239.58 |  6.35 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 38956662.50 |  6717568.75 |  5.80 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 39084887.50 |  6265093.75 |  6.24 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 52784950.00 | 12384906.67 |  4.26 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 43313900.00 |  6732640.63 |  6.43 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 87400850.00 | 21668630.00 |  4.03 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 58899675.50 |  7724501.50 |  7.63 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49754273.50 |  6932401.00 |  7.18 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock", Options: None)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 428938.54 |  42910.10 | 10.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 252561.31 |  34715.79 |  7.28 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 448068.21 |  64594.99 |  6.94 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 640129.89 |  89078.05 |  7.19 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 382407.14 |  51284.73 |  7.46 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 357389.49 |  51863.07 |  6.89 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 400222.28 |  56013.19 |  7.15 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 526207.71 |  81309.04 |  6.47 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 502908.85 |  70455.71 |  7.14 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 257595.47 |  37649.92 |  6.84 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 434791.80 |  63150.23 |  6.89 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 669475.42 | 147925.43 |  4.53 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 554100.62 | 106362.58 |  5.21 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 387378.93 |  55845.76 |  6.94 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 387974.53 |  73244.40 |  5.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 386114.79 |  59171.65 |  6.53 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 676699.18 | 105952.30 |  6.39 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 402992.31 |  65192.37 |  6.18 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 759223.07 | 293635.32 |  2.59 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 593059.26 |  85368.61 |  6.95 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 505240.86 |  74807.51 |  6.75 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Twain", Options: Compiled)

| Result |        Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 16216083.33 | 2504074.48 |  6.48 |          +0 | several? | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13369696.88 | 1517393.47 |  8.81 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18450792.31 | 3003254.17 |  6.14 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26546466.67 | 5095319.79 |  5.21 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18179475.00 | 2438396.43 |  7.46 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18344815.38 | 2498910.71 |  7.34 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19951266.67 | 2672164.06 |  7.47 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28645325.00 | 4624550.00 |  6.19 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28979375.00 | 4302871.09 |  6.73 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13628114.34 | 1606809.56 |  8.48 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17984062.57 | 2898322.43 |  6.20 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31481662.63 | 5303658.00 |  5.94 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22896815.86 | 4122476.98 |  5.55 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18562976.92 | 2481873.21 |  7.48 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18468930.77 | 2710451.04 |  6.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18037007.14 | 2489759.38 |  7.24 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27029788.89 | 3313116.25 |  8.16 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17257414.29 | 3034389.58 |  5.69 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26325720.00 | 7816057.81 |  3.37 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 22818087.55 | 3316395.15 |  6.88 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20683808.38 | 3013999.82 |  6.86 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock\s+Holmes", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 410896.28 |  39352.60 | 10.44 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 326548.24 |  31237.37 | 10.45 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 478947.63 |  61520.79 |  7.79 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 653427.47 |  83629.42 |  7.81 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 447428.30 |  47636.95 |  9.39 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 461533.46 |  47530.67 |  9.71 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 510542.64 |  54090.13 |  9.44 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 673139.40 |  76695.19 |  8.78 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 632995.31 |  65182.42 |  9.71 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 332090.79 |  35564.05 |  9.34 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 449482.16 |  58551.29 |  7.68 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 730343.78 | 140769.92 |  5.19 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 561290.96 | 100774.20 |  5.57 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 449102.68 |  53278.35 |  8.43 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 446129.34 |  68423.57 |  6.52 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 447297.23 |  58253.15 |  7.68 |          +0 | several? | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 653586.98 | 101404.40 |  6.45 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 427966.72 |  61842.83 |  6.92 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 645121.22 | 284484.55 |  2.27 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 572464.73 |  78986.85 |  7.25 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 519099.20 |  70240.87 |  7.39 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "Twain", Options: None)

| Result |        Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ----------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 20192829.17 | 2443290.10 |  8.26 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11822562.50 | 1562231.25 |  7.57 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20774125.00 | 3059681.25 |  6.79 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 29520975.00 | 5278506.25 |  5.59 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18342984.62 | 2458312.95 |  7.46 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 17510457.14 | 2536008.04 |  6.90 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19582933.33 | 2685821.88 |  7.29 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27392211.11 | 4656361.72 |  5.88 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 28081988.89 | 4277056.25 |  6.57 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11905134.38 | 1623286.46 |  7.33 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 20392131.42 | 2964642.27 |  6.88 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30738494.13 | 5481699.39 |  5.61 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 26233506.70 | 4164678.66 |  6.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18968975.00 | 2537250.00 |  7.48 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18619153.85 | 2754762.50 |  6.76 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 18533876.92 | 2542273.44 |  7.29 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32134787.50 | 3355954.38 |  9.58 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 19066365.38 | 3075236.25 |  6.20 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 35359771.43 | 7901881.25 |  4.47 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 27378649.22 | 3362074.79 |  8.14 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 23375003.36 | 3058901.49 |  7.64 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "Sherlock", Options: Compiled)

| Result |      Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ---------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 410207.60 |  37745.00 | 10.87 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 325407.78 |  31705.72 | 10.26 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 478417.99 |  58769.78 |  8.14 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 654811.85 |  80939.51 |  8.09 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 444544.27 |  47128.58 |  9.43 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 459093.84 |  46671.05 |  9.84 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 507661.49 |  51994.56 |  9.76 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 675481.79 |  75369.30 |  8.96 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 642764.84 |  64959.09 |  9.89 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 331903.38 |  34863.99 |  9.52 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 448989.19 |  57783.05 |  7.77 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 731479.17 | 141780.51 |  5.16 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 560514.11 |  99873.68 |  5.61 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 447763.93 |  51795.72 |  8.64 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 446612.50 |  67329.47 |  6.63 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 445430.80 |  54959.94 |  8.10 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 654620.31 | 100711.05 |  6.50 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 427882.69 |  60502.63 |  7.07 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 642701.82 | 283716.29 |  2.27 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 571020.90 |  78453.38 |  7.28 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 518510.69 |  69208.93 |  7.49 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "The", Options: None)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| --------:| -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1349966.15 | 117627.16 | 11.48 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  814799.06 |  87248.96 |  9.34 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1402791.48 | 155089.81 |  9.05 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2526997.50 | 220220.29 | 11.47 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1248615.63 | 140591.13 |  8.88 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1183503.85 | 126262.88 |  9.37 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1304457.29 | 135822.31 |  9.60 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1838249.65 | 209973.37 |  8.75 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1617293.75 | 175197.01 |  9.23 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  842468.53 | 108389.97 |  7.77 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1387809.23 | 155286.23 |  8.94 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2084886.05 | 331030.46 |  6.30 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1781619.50 | 237453.61 |  7.50 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1279767.79 | 141125.45 |  9.07 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1282880.73 | 169945.58 |  7.55 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1289577.08 | 162366.72 |  7.94 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2031148.83 | 238669.79 |  8.51 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1348395.05 | 151284.83 |  8.91 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2339184.82 | 457227.08 |  5.12 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1862453.77 | 225664.78 |  8.25 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1612489.62 | 194008.00 |  8.31 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "zqj", Options: Compiled)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  760891.88 |  19167.06 | 39.70 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  619814.30 |  18046.99 | 34.34 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  871569.10 |  33731.61 | 25.84 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1265761.06 |  65399.35 | 19.35 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  864245.49 |  24100.60 | 35.86 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  806741.25 |  25187.77 | 32.03 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  883130.56 |  28660.04 | 30.81 |          +0 | several? | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1247374.52 |  37618.89 | 33.16 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1082345.63 |  32350.05 | 33.46 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  607609.57 |  19116.48 | 31.78 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  872085.34 |  33143.43 | 26.31 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1334849.97 |  92562.97 | 14.42 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1088379.85 |  67775.18 | 16.06 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  859442.43 |  25755.12 | 33.37 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  859222.37 |  41793.19 | 20.56 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  858018.59 |  26398.99 | 32.50 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1186625.89 |  66553.87 | 17.83 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  783983.55 |  33487.84 | 23.41 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1149526.34 | 254649.85 |  4.51 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1114411.52 |  42574.61 | 26.18 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1005280.74 |  39482.16 | 25.46 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "zqj", Options: None)

| Result |       Base |      Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ----------:| ---------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  913535.29 |  19047.67 | 47.96 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  533997.92 |  18126.17 | 29.46 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  948518.75 |  34302.74 | 27.65 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1353809.90 |  65870.16 | 20.55 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  801704.38 |  23945.16 | 33.48 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  745902.08 |  24282.14 | 30.72 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  845421.05 |  28693.87 | 29.46 |          +0 | several? | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1149585.04 |  37821.11 | 30.40 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1001379.58 |  31841.00 | 31.45 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  533899.19 |  19206.99 | 27.80 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  921810.57 |  33806.64 | 27.27 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1326313.21 |  92299.95 | 14.37 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1159754.76 |  68210.48 | 17.00 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  810573.13 |  25060.89 | 32.34 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  805621.56 |  41650.85 | 19.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  803693.42 |  26112.45 | 30.78 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1477527.27 |  66616.78 | 22.18 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  810289.38 |  34021.23 | 23.82 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1646372.81 | 254155.58 |  6.48 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1262605.72 |  42529.08 | 29.69 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1061653.82 |  39321.00 | 27.00 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?", Options: Compiled)

| Result |        Base |       Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 40563950.00 | 2086857.59 | 19.44 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31278842.86 | 1461076.14 | 21.41 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49084500.00 | 2430932.29 | 20.19 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 68903650.00 | 8737604.00 |  7.89 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 44049537.50 | 2295411.61 | 19.19 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49856562.50 | 2352455.80 | 21.19 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49120600.00 | 2438468.23 | 20.14 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 66970662.50 | 4157730.47 | 16.11 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 69818175.00 | 3683267.19 | 18.96 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 34050276.29 | 1740358.75 | 19.57 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 50483844.88 | 2636813.80 | 19.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 93952191.00 | 4923141.75 | 19.08 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 70524532.50 | 3749837.73 | 18.81 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 46662500.00 | 2501639.06 | 18.65 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 47054275.00 | 2673497.92 | 17.60 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 46596950.00 | 2622776.04 | 17.77 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 69143575.00 | 3451835.94 | 20.03 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 55379325.00 | 2579002.08 | 21.47 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 88202537.50 | 5487854.17 | 16.07 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 63162854.00 | 3492684.59 | 18.08 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 57945324.75 | 3161828.22 | 18.33 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.OneNodeBacktracking(Options: IgnoreCase, Compiled)

| Result |    Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 2316.07 | 239.54 |  9.67 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1732.00 | 171.34 | 10.11 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2822.46 | 270.90 | 10.42 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4027.16 | 365.21 | 11.03 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2404.79 | 222.84 | 10.79 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3117.73 | 242.54 | 12.85 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2863.20 | 239.59 | 11.95 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3959.77 | 322.50 | 12.28 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4390.75 | 321.32 | 13.66 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2092.07 | 196.71 | 10.64 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3046.24 | 295.73 | 10.30 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 7487.64 | 592.43 | 12.64 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4126.80 | 406.55 | 10.15 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2863.27 | 264.27 | 10.83 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3125.04 | 312.16 | 10.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3078.33 | 302.74 | 10.17 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4604.79 | 422.10 | 10.91 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3026.48 | 282.33 | 10.72 |          +0 | several? | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 4705.19 | 471.55 |  9.98 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3944.70 | 361.91 | 10.90 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3428.99 | 341.87 | 10.03 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?", Options: None)

| Result |         Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  92236800.00 |  3155440.63 | 29.23 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  62406912.50 |  2319531.25 | 26.90 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 103116300.00 |  4011330.47 | 25.71 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 146991850.00 | 14897310.00 |  9.87 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90802325.00 |  3637217.19 | 24.96 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 102317300.00 |  3928968.75 | 26.04 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  99307025.00 |  3909703.13 | 25.40 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 135424350.00 |  6119959.38 | 22.13 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 166362950.00 |  5671305.21 | 29.33 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  62976303.50 |  2555272.68 | 24.65 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100126217.75 |  4031865.11 | 24.83 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 189907702.00 |  7902242.98 | 24.03 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 146354277.00 |  6090059.15 | 24.03 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  91724650.00 |  3777617.97 | 24.28 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  90453700.00 |  3978868.75 | 22.73 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  92741050.00 |  3902205.47 | 23.77 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 138765800.00 |  5277178.13 | 26.30 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  99720500.00 |  4176532.81 | 23.88 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 214030550.00 |  9603771.88 | 22.29 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 128913494.50 |  5338445.68 | 24.15 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 119649637.50 |  4795619.40 | 24.95 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Common.OneNodeBacktracking(Options: Compiled)

| Result |    Base |   Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------:| ------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 1322.44 |  97.23 | 13.60 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1044.09 |  60.77 | 17.18 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1649.10 | 105.33 | 15.66 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2312.80 | 199.97 | 11.57 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1465.40 |  93.99 | 15.59 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1952.30 | 110.57 | 17.66 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1708.43 | 100.59 | 16.98 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2630.76 | 139.42 | 18.87 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2631.78 | 137.59 | 19.13 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1115.80 |  67.75 | 16.47 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1937.79 | 114.05 | 16.99 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 5069.77 | 227.30 | 22.30 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2692.11 | 153.05 | 17.59 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1926.62 |  95.90 | 20.09 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1906.59 |  98.28 | 19.40 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1917.51 |  93.51 | 20.51 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3057.27 | 154.14 | 19.83 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2040.64 | 120.62 | 16.92 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 3224.16 | 193.45 | 16.67 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2474.99 | 132.37 | 18.70 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 2189.26 | 119.98 | 18.25 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "[a-z]shing", Options: None)

| Result |          Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -------------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  504014900.00 |  8448193.75 | 59.66 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  403417900.00 |  6617176.04 | 60.97 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  650953400.00 | 10372715.63 | 62.76 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1200977850.00 | 19403450.00 | 61.90 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  585068800.00 |  9472481.25 | 61.77 |          +0 | several? | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  655207600.00 |  9951121.88 | 65.84 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  633411200.00 | 10568210.87 | 59.94 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  922484400.00 | 16422890.00 | 56.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  922967650.00 | 15089529.17 | 61.17 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  397694800.00 |  7045135.42 | 56.45 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  620707698.50 | 10161039.98 | 61.09 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1288519165.00 | 17991704.40 | 71.62 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  900027784.00 | 13399912.21 | 67.17 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  544335600.00 |  9824551.56 | 55.41 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  537172500.00 |  9538445.31 | 56.32 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  533604300.00 | 10047096.88 | 53.11 |          +0 | several? | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  905027600.00 | 12687245.00 | 71.33 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  587195350.00 | 11494943.75 | 51.08 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 1185772250.00 | 17566188.89 | 67.50 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  808940471.00 | 12945044.93 | 62.49 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  710897557.00 | 11649268.31 | 61.03 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Leipzig.Count(Pattern: "[a-z]shing", Options: Compiled)

| Result |         Base |        Diff | Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| -----------:| -----:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 137113350.00 |  6229813.54 | 22.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 105432650.00 |  5007842.19 | 21.05 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 157948700.00 |  7451422.92 | 21.20 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 295719050.00 | 10355093.18 | 28.56 |          +0 | bimodal  | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 146972700.00 |  7094706.25 | 20.72 |          +0 | bimodal  | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 174075750.00 |  7324872.92 | 23.77 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 153320800.00 |  7882134.38 | 19.45 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 234063400.00 | 12488410.00 | 18.74 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 220859000.00 | 11245568.75 | 19.64 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 109108530.50 |  5424230.92 | 20.12 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 157977358.00 |  7518436.76 | 21.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 309878892.50 | 13039470.32 | 23.76 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 222711340.50 |  9274346.88 | 24.01 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 147507800.00 |  7531554.17 | 19.59 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 145077275.00 |  7131815.63 | 20.34 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 147307075.00 |  7551826.04 | 19.51 |          +0 | several? | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 215632350.00 |  8489256.25 | 25.40 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 158103600.00 |  8311128.13 | 19.02 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 245444750.00 | 10943056.25 | 22.43 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 197828892.50 |  9712622.98 | 20.37 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 183004683.50 |  8624702.52 | 21.22 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "[\w\.+-]+@[\w\.-]+\.[\w\.-]+", Options: None)

| Result |         Base |       Diff |  Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | ------------:| ----------:| ------:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  82243750.00 |  343671.33 | 239.31 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  64309850.00 |  290998.26 | 221.00 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 100979375.00 |  617887.26 | 163.43 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 166491050.00 | 1149985.94 | 144.78 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  88590875.00 |  642049.25 | 137.98 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 101705800.00 |  636287.75 | 159.84 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  98115550.00 |  514962.71 | 190.53 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 137096050.00 | 1206964.29 | 113.59 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 160851100.00 | 1126206.25 | 142.83 |          +0 | bimodal  | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  61528347.25 |  294706.20 | 208.78 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  95574262.75 |  594590.92 | 160.74 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 183609541.00 | 1641761.78 | 111.84 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 137725125.00 | 1279005.76 | 107.68 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  88407650.00 |  620502.38 | 142.48 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  87224937.50 |  781326.49 | 111.64 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  86839487.50 |  629446.61 | 137.96 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 134331000.00 |  996783.54 | 134.76 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  92090100.00 |  625041.00 | 147.33 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 212425500.00 | 2914391.15 |  72.89 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 124175626.25 |  953453.69 | 130.24 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 110585730.50 |  874674.63 | 126.43 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_Mariomkas.Count(Pattern: "[\w\.+-]+@[\w\.-]+\.[\w\.-]+", Options: Compiled)

| Result |        Base |       Diff |  Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ----------:| ------:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 41378700.00 |  275841.83 | 150.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31370114.29 |  236155.87 | 132.84 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 50321900.00 |  544805.50 |  92.37 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 72797512.50 | 1024404.69 |  71.06 |          +0 | several? | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 44552287.50 |  573268.98 |  77.72 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 51150262.50 |  548568.97 |  93.24 |          +0 | several? | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 51072250.00 |  430221.63 | 118.71 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 68773550.00 | 1096901.67 |  62.70 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 89623400.00 | 1005891.02 |  89.10 |          +0 | several? | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 32185627.57 |  240536.27 | 133.81 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49763154.75 |  539422.10 |  92.25 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 91687438.13 | 1483042.73 |  61.82 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 69798054.13 | 1125477.41 |  62.02 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45881625.00 |  559178.57 |  82.05 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45555025.00 |  718209.80 |  63.43 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 45598437.50 |  561599.33 |  81.19 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 69118675.00 |  881193.92 |  78.44 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 52697500.00 |  537864.76 |  97.98 |          +0 |          | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 89073650.00 | 2731079.69 |  32.61 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 62088234.88 |  861164.04 |  72.10 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 57357096.00 |  781576.86 |  73.39 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "[a-q][^u-z]{13}x", Options: None)

| Result |        Base |      Diff |  Ratio | Alloc Delta | Modality   | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ---------:| ------:| -----------:| ---------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster | 27562816.67 |  63691.97 | 432.75 |          +0 |            | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21667980.00 |  49127.72 | 441.05 |          +0 |            | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37567500.00 |  93802.07 | 400.50 |          +0 |            | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 74515162.50 | 126749.28 | 587.89 |          +0 |            | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31217368.75 |  72372.85 | 431.34 |          +0 |            | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36008316.67 |  74062.24 | 486.19 |          +0 | bimodal    | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 37663083.33 |  81832.86 | 460.24 |          +0 |            | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster | 50252725.00 | 118747.06 | 423.19 |          +0 | multimodal | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 44542450.00 | 102326.12 | 435.30 |          +0 |            | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 21482823.00 |  56404.08 | 380.87 |          +0 |            | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 34106537.33 |  90383.81 | 377.35 |          +0 |            | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 70883610.75 | 198847.95 | 356.47 |          +0 |            | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49295040.00 | 144151.69 | 341.97 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster | 31505200.00 |  77013.19 | 409.09 |          +0 |            | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30729971.43 |  95769.06 | 320.88 |          +0 |            | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 30727135.71 |  82187.66 | 373.87 |          +0 |            | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster | 49570925.00 | 139128.96 | 356.29 |          +0 |            | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 36051450.00 |  92049.74 | 391.65 |          +0 |            | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 72666337.50 | 348414.66 | 208.56 |          +0 |            | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster | 46404047.75 | 121045.03 | 383.36 |          +0 |            | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster | 38771128.75 | 109931.04 | 352.69 |          +0 |            | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

## System.Text.RegularExpressions.Tests.Perf_Regex_Industry_RustLang_Sherlock.Count(Pattern: "[a-q][^u-z]{13}x", Options: Compiled)

| Result |        Base |      Diff |  Ratio | Alloc Delta | Modality | Operating System     | Bit   | Processor Name                                  | Base V        | Diff V     |
| ------ | -----------:| ---------:| ------:| -----------:| -------- | -------------------- | ----- | ----------------------------------------------- | ------------- | ----------- |
| Faster |  5664581.25 |  38371.65 | 147.62 |          +0 |          | Windows 11           | X64   | AMD Ryzen Threadripper PRO 3945WX 12-Cores      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  3988270.31 |  32421.78 | 123.01 |          +0 |          | Windows 11           | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5915716.67 |  59728.36 |  99.04 |          +0 |          | Windows 10           | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 11497911.90 |  81501.98 | 141.08 |          +0 |          | Windows 11           | X64   | Intel Core i5-4300U CPU 1.90GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  5940766.67 |  46298.16 | 128.32 |          +0 |          | Windows 10           | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6488737.50 |  46452.35 | 139.69 |          +0 |          | Windows 11           | X64   | Intel Core i7-8700 CPU 3.20GHz (Coffee Lake)    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6159272.92 |  51952.91 | 118.55 |          +0 |          | Windows 11           | X64   | Intel Core i9-9900T CPU 2.10GHz                 | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8984164.06 |  73868.50 | 121.62 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7490501.56 |  63760.50 | 117.48 |          +0 |          | Windows 11           | X64   | Unknown processor                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  4197498.57 |  37030.37 | 113.35 |          +0 |          | ubuntu 20.04         | X64   | AMD Ryzen 9 5900X                               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6648603.26 |  57460.53 | 115.71 |          +0 |          | ubuntu 18.04         | X64   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster | 13206713.94 | 143461.98 |  92.06 |          +0 |          | centos 7             | X64   | Intel Xeon CPU E5530 2.40GHz                    | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8556527.89 | 102237.78 |  83.69 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-2720QM CPU 2.20GHz (Sandy Bridge) | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6691169.79 |  51144.70 | 130.83 |          +0 |          | alpine 3.13          | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6677241.67 |  71217.44 |  93.76 |          +0 |          | ubuntu 18.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6659731.25 |  55836.51 | 119.27 |          +0 |          | ubuntu 20.04         | X64   | Intel Core i7-7700 CPU 3.60GHz (Kaby Lake)      | 6.0.121.56705 | 7.0.22.7608|
| Faster |  8319259.38 | 102498.61 |  81.16 |          +0 |          | Windows 10           | Arm64 | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  6442814.58 |  58408.13 | 110.31 |          +0 | bimodal  | Windows 10           | X86   | Intel Xeon CPU E5-1650 v4 3.60GHz               | 6.0.121.56705 | 7.0.22.7608|
| Faster |  9377390.63 | 288529.09 |  32.50 |          +0 |          | Windows 10           | Arm   | Microsoft SQ1 3.0 GHz                           | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7992834.52 |  78851.71 | 101.37 |          +0 |          | macOS Big Sur 11.6.3 | X64   | Intel Core i5-4278U CPU 2.60GHz (Haswell)       | 6.0.121.56705 | 7.0.22.7608|
| Faster |  7249112.38 |  69604.45 | 104.15 |          +0 |          | macOS Big Sur 11.4   | X64   | Intel Core i7-5557U CPU 3.10GHz (Broadwell)     | 6.0.121.56705 | 7.0.22.7608|

