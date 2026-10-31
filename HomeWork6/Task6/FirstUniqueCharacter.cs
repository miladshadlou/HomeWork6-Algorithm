namespace HomeWork6;

public class FirstUniqueCharacter
{
    public static string FirstUniqueChar(string s)
    {
        var counts = new Dictionary<char, int>();
        foreach (char c in s)
            counts[c] = counts.GetValueOrDefault(c) + 1;

        foreach (char c in s)
            if (counts[c] == 1) return c.ToString();

        return "-1";
    }
}
