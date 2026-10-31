using System.Numerics;

namespace HomeWork6;

public class FibonacciSequence
{
   
    public static BigInteger Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be >= 0");
        if (n < 2) return n;

        BigInteger prev = 0, curr = 1;
        for (int i = 2; i <= n; i++)
            (prev, curr) = (curr, prev + curr);

        return curr;
    }
}
