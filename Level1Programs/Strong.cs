using System;
using MathUtils;
namespace Level1Programs;

public class Strong
{
    public static void Run()
    {
        Console.Write("Enter a number to check whether it is Strong number or not : ");
        int n = ReadInput<int>();

        int strong_num = 0;
        int org_numb = n;
        while (n > 0)
        {
            int lastDigit = n % 10;
            strong_num += Factorials.Factfunc(lastDigit);
            n /= 10;
        }
        if (strong_num == org_numb)
        {
            System.Console.WriteLine($"{org_numb} is a strong number");
        }
        else
        {
            System.Console.WriteLine($"{org_numb} is not a strong number");
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
                Console.WriteLine($"Invalid input. Enter a number");
            }
        }
    }
}
