# demo-dotnet-benchmark

| Method                                           |        Mean |     Error |    StdDev |      Median | Ratio | Rank |   Gen0 | Allocated | Alloc Ratio |
| ------------------------------------------------ | ----------: | --------: | --------: | ----------: | ----: | ---: | -----: | --------: | ----------: |
| GetYearFromSpanWithFixedIndexAndBinaryOperations |   0.0004 ns | 0.0008 ns | 0.0007 ns |   0.0001 ns | 0.000 |    1 |      - |         - |          NA |
| GetYearFromSpanWithFixedIndex                    |   1.4564 ns | 0.0026 ns | 0.0020 ns |   1.4559 ns | 0.007 |    2 |      - |         - |          NA |
| GetYearFromSpanWithManualConversion              |   4.5723 ns | 0.0046 ns | 0.0038 ns |   4.5737 ns | 0.021 |    3 |      - |         - |          NA |
| GetYearFromSpan                                  |  18.7580 ns | 0.0393 ns | 0.0328 ns |  18.7461 ns | 0.085 |    4 |      - |         - |          NA |
| GetYearFromSubstring                             |  27.7071 ns | 0.0669 ns | 0.0593 ns |  27.7075 ns | 0.126 |    5 | 0.0153 |      32 B |          NA |
| GetYearFromSplit                                 |  85.3118 ns | 0.3543 ns | 0.2766 ns |  85.2788 ns | 0.389 |    6 | 0.0764 |     160 B |          NA |
| GetYearFromDateTime                              | 219.5645 ns | 0.3783 ns | 0.2953 ns | 219.4568 ns | 1.000 |    7 |      - |         - |          NA |
