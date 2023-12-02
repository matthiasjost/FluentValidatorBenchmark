# FluentValidatorBenchmark

// * Summary *

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22635.2776)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


| Method                 | NumCustomers | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0       | Gen1      | Gen2      | Allocated | Alloc Ratio |
|----------------------- |------------- |-----------:|----------:|----------:|------:|--------:|-----------:|----------:|----------:|----------:|------------:|
| ReuseValidatorScenario | 10000        |   7.669 ms | 0.1015 ms | 0.0950 ms |  1.00 |    0.00 |  1078.1250 |  265.6250 |  125.0000 |   6.59 MB |        1.00 |
| NewValidatorScenario   | 10000        | 200.707 ms | 3.6537 ms | 7.6266 ms | 26.94 |    1.17 | 17000.0000 | 6000.0000 | 2000.0000 | 101.06 MB |       15.33 |
