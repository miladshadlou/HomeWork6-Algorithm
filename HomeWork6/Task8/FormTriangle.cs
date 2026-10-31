namespace HomeWork6;

public class FormTriangle
{
    public static bool CanFormTriangle(int[] a)
    {
        if (a.Length < 3) return false;

        int[] s = (int[])a.Clone();
        Array.Sort(s);

        for (int i = 0; i + 2 < s.Length; i++)
        {
            if ((long)s[i] + s[i + 1] > s[i + 2])
                return true;
        }
        return false;
    }
}
