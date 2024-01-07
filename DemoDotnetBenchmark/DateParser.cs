namespace DemoDotnetBenchmark;

public class DateParser
{
    public int GetYearFromDateTime(string dateTimeString)
    {
        var dateTime = DateTime.Parse(dateTimeString);
        return dateTime.Year;
    }

    public int GetYearFromSplit(string dateTimeString)
    {
        var splitOnHypen = dateTimeString.Split('-');
        return int.Parse(splitOnHypen[0]);
    }

    public int GetYearFromSubstring(string dateTimeString)
    {
        var indexOfHypen = dateTimeString.IndexOf('-');
        return int.Parse(dateTimeString.Substring(0, indexOfHypen));
    }

    public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfHypen = dateTimeAsSpan.IndexOf('-');
        return int.Parse(dateTimeAsSpan.Slice(0, indexOfHypen));
    }

    public int GetYearFromSpanWithManualConversion(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfHypen = dateTimeAsSpan.IndexOf('-');
        var yearAsSpan = dateTimeAsSpan.Slice(0, indexOfHypen);

        var temp = 0;
        for (int i = 0; i < yearAsSpan.Length; i++)
        {
            temp = temp * 10 + (yearAsSpan[i] - '0');
        }

        return temp;
    }

    public int GetYearFromSpanWithFixedIndex(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfHypen = 4;
        var yearAsSpan = dateTimeAsSpan.Slice(0, indexOfHypen);

        var temp = 0;
        for (int i = 0; i < yearAsSpan.Length; i++)
        {
            temp = temp * 10 + (yearAsSpan[i] - '0');
        }

        return temp;
    }

    public int GetYearFromSpanWithFixedIndexAndBinaryOperations(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var temp = 0;
        temp = (temp << 3) + (temp << 1) + (dateTimeAsSpan[0] - '0');
        temp = (temp << 3) + (temp << 1) + (dateTimeAsSpan[1] - '0');
        temp = (temp << 3) + (temp << 1) + (dateTimeAsSpan[2] - '0');
        temp = (temp << 3) + (temp << 1) + (dateTimeAsSpan[3] - '0');

        return temp;
    }
}