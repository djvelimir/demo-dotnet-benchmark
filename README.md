# demo-dotnet-benchmark

Example of algorithm optimization form 286.531 ns to 2.212 ns.

| Method                                           |       Mean |     Error |    StdDev | Ratio | Rank |   Gen0 | Allocated | Alloc Ratio |
| ------------------------------------------------ | ---------: | --------: | --------: | ----: | ---: | -----: | --------: | ----------: |
| GetYearFromSpanWithFixedIndexAndBinaryOperations |   2.212 ns | 0.0093 ns | 0.0083 ns | 0.008 |    1 |      - |         - |          NA |
| GetYearFromSpanWithFixedIndex                    |   3.736 ns | 0.0481 ns | 0.0426 ns | 0.013 |    2 |      - |         - |          NA |
| GetYearFromSpanWithManualConversion              |   7.257 ns | 0.0263 ns | 0.0233 ns | 0.025 |    3 |      - |         - |          NA |
| GetYearFromSpan                                  |  16.644 ns | 0.0864 ns | 0.0766 ns | 0.058 |    4 |      - |         - |          NA |
| GetYearFromSubstring                             |  28.232 ns | 0.0629 ns | 0.0491 ns | 0.099 |    5 | 0.0153 |      32 B |          NA |
| GetYearFromSplit                                 |  90.503 ns | 0.4107 ns | 0.3641 ns | 0.316 |    6 | 0.0764 |     160 B |          NA |
| GetYearFromDateTime                              | 286.531 ns | 5.5299 ns | 9.6852 ns | 1.000 |    7 |      - |         - |          NA |
