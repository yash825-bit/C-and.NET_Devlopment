using System;
namespace Level2Programs;

public class EvenOdd
{
    public static void Run()
    {
        Console.Write("Enter a number : ");
        int n = ReadInput<int>();

        if (evenodd(n))
        {
            Console.WriteLine($"{n} is an even number");
        }
        else
        {
            Console.WriteLine($"{n} is an odd number");
        }
    }
    static T ReadInput<T>()
    {
        while (true)
        {
            string input = Console.ReadLine();
            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                Console.Write($"Invalid input❌, please enter input of {typeof(T)}");
            }
        }
    }
    public static bool evenodd(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        return false;
    }
}