namespace HomeWork6;

public class LongestIncreasingSubarray
{
    public static int LongestIncreasingRun(int[] a)
    {
        if (a.Length == 0) return 0;

        int best = 1, current = 1;
        for (int i = 1; i < a.Length; i++)
        {
            current = a[i] > a[i - 1] ? current + 1 : 1;
            best = Math.Max(best, current);
        }
        return best;
    }
}
