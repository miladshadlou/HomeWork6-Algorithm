using System.Numerics;

namespace HomeWork6;

public class MaxProductOfThreeIntegers
{
    public static BigInteger MaxProductOfThree(int[] a)
    {
        if (a.Length < 3) throw new ArgumentException("Array must contain at least 3 numbers.");

        long max1 = long.MinValue, max2 = long.MinValue, max3 = long.MinValue;
        long min1 = long.MaxValue, min2 = long.MaxValue;

        foreach (int x in a)
        {
            if (x > max1) { max3 = max2; max2 = max1; max1 = x; }
            else if (x > max2) { max3 = max2; max2 = x; }
            else if (x > max3) { max3 = x; }

            if (x < min1) { min2 = min1; min1 = x; }
            else if (x < min2) { min2 = x; }
        }

        BigInteger allPositive = (BigInteger)max1 * max2 * max3;
        BigInteger twoNegatives = (BigInteger)max1 * min1 * min2;
        return BigInteger.Max(allPositive, twoNegatives);
    }
}
