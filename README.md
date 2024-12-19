# demo-dotnet-benchmark

| Method                                           |       Mean |     Error |    StdDev | Ratio | Rank |   Gen0 | Allocated | Alloc Ratio |
| ------------------------------------------------ | ---------: | --------: | --------: | ----: | ---: | -----: | --------: | ----------: |
| GetYearFromSpanWithFixedIndex                    |   2.511 ns | 0.0042 ns | 0.0038 ns | 0.010 |    1 |      - |         - |          NA |
| GetYearFromSpanWithFixedIndexAndBinaryOperations |   2.573 ns | 0.0059 ns | 0.0052 ns | 0.010 |    2 |      - |         - |          NA |
| GetYearFromSpanWithManualConversion              |   6.963 ns | 0.0078 ns | 0.0069 ns | 0.027 |    3 |      - |         - |          NA |
| GetYearFromSpan                                  |  15.333 ns | 0.1837 ns | 0.1628 ns | 0.060 |    4 |      - |         - |          NA |
| GetYearFromSubstring                             |  24.354 ns | 0.0670 ns | 0.0594 ns | 0.096 |    5 | 0.0153 |      32 B |          NA |
| GetYearFromSplit                                 |  97.069 ns | 0.3601 ns | 0.3007 ns | 0.381 |    6 | 0.0764 |     160 B |          NA |
| GetYearFromDateTime                              | 254.799 ns | 0.2873 ns | 0.2546 ns | 1.000 |    7 |      - |         - |          NA |
