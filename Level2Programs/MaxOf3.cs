using System;
namespace Level2Programs;

public class MaxOf3
{
    public static void Run()
    {
        Console.WriteLine("Enter three to find the maximum one among them : ");
        Console.Write("Enter first number : ");
        int a = ReadInput<int>();

        Console.Write("Enter second number : ");
        int b = ReadInput<int>();

        Console.Write("Enter third number : ");
        int c = ReadInput<int>();

        Console.Write($"The maximum number is : {Maximum(a, b, c)}");
    }
    public static T ReadInput<T>()
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
                Console.WriteLine($"Invalid Error ❌, Please enter an input of type {typeof(T)}");
            }
        }
    }
    public static int Maximum(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            return a;
        }
        else if (b > c)
        {
            return b;
        }
        return c;
    }
}