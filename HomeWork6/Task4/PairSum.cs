namespace HomeWork6;

public class PairSum
{
    public static bool HasPairWithSum(int[] a, long target)
    {
        var seen = new HashSet<long>();
        foreach (int x in a)
        {
            if (seen.Contains(target - x)) return true;
            seen.Add(x);                         // added AFTER the check -> two different elements
        }
        return false;
    }
}
