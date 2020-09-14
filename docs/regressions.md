# Investigating regressions reported in the [dotnet/runtime](https://github.com/dotnet/runtime) repository

## Table of Contents

- [Introduction](#Introduction)
- [Repro](#Repro)

# Introduction

**This doc explains how to investigate regressions reported in the [dotnet/runtime](https://github.com/dotnet/runtime) repository and it's targetted at [dotnet/runtime](https://github.com/dotnet/runtime) repository contributors.**

Before you start any performance investigation, you need to open the issue, click on the link that leads to the full historical data, and evaluate the data.

For some reports, it will be obvious to you that there is a regression ([source](https://github.com/DrewScoggins/performance-2/issues/910)):

![Ovious regression](img/regressions_obvious.png)

For some, it'll be clear that the benchmark is simply multimodal (bimodal in the examples below [1](https://github.com/DrewScoggins/performance-2/issues/1683), [2](https://github.com/DrewScoggins/performance-2/issues/1379), [3](https://github.com/DrewScoggins/performance-2/issues/1378)) and there is no regression:

![Bimodal benchmark, no actual regression](img/regressions_bimodal.png)

![Bimodal benchmark, no actual regression](img/regressions_bimodal_2.png)

![Bimodal benchmark, no actual regression](img/regressions_bimodal_3.png)

For others, it might not be clear whether there is a regression or the benchmark is simply unstable as in the following [example](https://github.com/DrewScoggins/performance-2/issues/1253):

![Not sure](img/regressions_notsure.png)

If the historical data shows that there is no regression, you can just close the issue and explain it. The more mature the system becomes, the less frequent it should be.



