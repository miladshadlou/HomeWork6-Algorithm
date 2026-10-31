namespace HomeWork6;

public class NumberToWord
{
    private static readonly string[] Ones =
    {
        "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
        "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
        "Eighteen", "Nineteen"
    };

    private static readonly string[] Tens =
    {
        "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
    };

    private static string Below100(int n) =>
        n < 20 ? Ones[n] : Tens[n / 10] + (n % 10 != 0 ? "-" + Ones[n % 10] : "");

    private static string Below1000(int n)
    {
        var parts = new List<string>();
        if (n >= 100) parts.Add(Ones[n / 100] + " Hundred");
        if (n % 100 > 0) parts.Add(Below100(n % 100));
        return string.Join(" ", parts);
    }

    public static string NumberToWords(int n)
    {
        if (n < 1 || n > 9999)
            throw new ArgumentOutOfRangeException(nameof(n), "n must be between 1 and 9999");

        var parts = new List<string>();
        if (n >= 1000) parts.Add(Ones[n / 1000] + " Thousand");
        if (n % 1000 > 0) parts.Add(Below1000(n % 1000));
        return string.Join(" ", parts);
    }
}
