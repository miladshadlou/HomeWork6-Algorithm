using System;

namespace HomeWork6;

public class Program
{
    public static void Main()
    {
        int Choice = 0;
        do
        {
            ShowMenu();
            string input = Console.ReadLine();
            if (int.TryParse(input, out Choice) && Choice > 0 && Choice < 12)
            {
                switch (Choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("**** Fibonacci Sequence ****");
                        try { Console.WriteLine($"Result: {FibonacciSequence.Fibonacci(Input.ReadInt("Please enter a number n: "))}"); }
                        catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("**** Prime Number ****");
                        Console.WriteLine(IsPrimeNumber.IsPrime(Input.ReadLong("Please enter a number n: ")) ? "Prime" : "Not prime");                      
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("**** Longest Increasing Sub array ****");
                        Console.WriteLine($"Length: {LongestIncreasingSubarray.LongestIncreasingRun(Input.ReadIntArray("Please enter Array numbers (space separated): "))}");

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("**** Pair Sum equal target ****");
                        {
                            int[] arr = Input.ReadIntArray("Please enter Array numbers (space separated): ");
                            long target = Input.ReadLong("Please enter target number: ");
                            Console.WriteLine(PairSum.HasPairWithSum(arr, target) ? "true" : "false");
                            break;
                        }
                    case 5:
                        Console.Clear();
                        Console.WriteLine("**** Number To Word ****");
                        try { Console.WriteLine(NumberToWord.NumberToWords(Input.ReadInt("Please enter number (1-9999): "))); }
                        catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message); }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("**** First Unique Character ****");
                        Console.Write("Please enter your String: ");
                        Console.WriteLine($"Result: {FirstUniqueCharacter.FirstUniqueChar(Console.ReadLine() ?? "")}");
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("**** Reverse Integer Number ****");
                        Console.WriteLine($"Result: {ReverseIntegerNumber.ReverseInteger(Input.ReadInt("Please enter number n: "))}");
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("**** Form Triangle ****");
                        Console.WriteLine(FormTriangle.CanFormTriangle(Input.ReadIntArray("Array of positive ints: ")) ? "true" : "false");
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("**** BalanceParenthes ****");
                        Console.Write("Please enter your String: ");
                        Console.WriteLine(BalanceParenthes.IsBalanced(Console.ReadLine() ?? "") ? "Balanced" : "Not balanced");
                        break;
                    case 10:
                        Console.Clear();
                        try { Console.WriteLine($"Result: {MaxProductOfThreeIntegers.MaxProductOfThree(Input.ReadIntArray("Please enter your Array (space separated): "))}"); }
                        catch (ArgumentException e) { Console.WriteLine(e.Message); }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid menu number.");
            }
            Console.ReadKey();

        } while (Choice != 11);

    }

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("========================= Home Work 6 =========================");
        Console.WriteLine("1) Fibonacci          2) Prime check        3) Longest increasing run");
        Console.WriteLine("4) Two-sum            5) Number to words    6) First unique char");
        Console.WriteLine("7) Reverse integer    8) Triangle check     9) Balanced brackets");
        Console.WriteLine("10) Max product of 3  11) Exit");
        Console.Write("Choose an Option: ");
     
    }
}

public static class Input
{
    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value)) return value;
            Console.WriteLine("Please enter a valid integer.");
        }
    }

    public static long ReadLong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (long.TryParse(Console.ReadLine(), out long value)) return value;
            Console.WriteLine("Please enter a valid integer.");
        }
    }

    public static int[] ReadIntArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string line = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Array cannot be empty. Please enter again.");
                continue;
            }

            string[] parts = line.Split(
                (char[]?)null,
                StringSplitOptions.RemoveEmptyEntries);

            if (parts.All(p => int.TryParse(p, out _)))
                return parts.Select(int.Parse).ToArray();

            Console.WriteLine("Please enter integers separated by spaces.");
        }
    }
}

