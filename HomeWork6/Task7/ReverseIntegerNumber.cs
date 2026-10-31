namespace HomeWork6;

public class ReverseIntegerNumber
{
    public static int ReverseInteger(int x)
    {
        int result = 0;
        while (x != 0)
        {
            int digit = x % 10;                  // keeps the sign of x 
            x /= 10;

            // check BEFORE multiplying so we never overflow
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7)) return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8)) return 0;

            result = result * 10 + digit;
        }
        return result;
    }
}

