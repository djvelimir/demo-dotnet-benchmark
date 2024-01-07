using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace DemoDotnetBenchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmark
{
    private const string DateTime = "2019-12-13T16:33:06Z";
    private static readonly DateParser Parser = new DateParser();

    [Benchmark(Baseline = true)]
    public int GetYearFromDateTime()
    {
        return Parser.GetYearFromDateTime(DateTime);
    }

    [Benchmark]
    public int GetYearFromSplit()
    {
        return Parser.GetYearFromSplit(DateTime);
    }

    [Benchmark]
    public int GetYearFromSubstring()
    {
        return Parser.GetYearFromSubstring(DateTime);
    }

    [Benchmark]
    public int GetYearFromSpan()
    {
        return Parser.GetYearFromSpan(DateTime);
    }

    [Benchmark]
    public int GetYearFromSpanWithManualConversion()
    {
        return Parser.GetYearFromSpanWithManualConversion(DateTime);
    }

    [Benchmark]
    public int GetYearFromSpanWithFixedIndex()
    {
        return Parser.GetYearFromSpanWithFixedIndex(DateTime);
    }

    [Benchmark]
    public int GetYearFromSpanWithFixedIndexAndBinaryOperations()
    {
        return Parser.GetYearFromSpanWithFixedIndexAndBinaryOperations(DateTime);
    }
}