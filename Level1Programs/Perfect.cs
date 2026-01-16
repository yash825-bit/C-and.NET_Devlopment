using System;
using System.Runtime.InteropServices;
namespace Level1Programs;

public class Perfect
{
    public static void Run()
    {
        Console.Write("Enter a number to check whether it's a perfect number or not : ");
        int num = ReadInput<int>();

        List<int> factorList = GetFactors(num);
        factorList.Sort();
        factorList.RemoveAt(factorList.Count - 1);
        int sumOfFactors = 0;
        foreach (int x in factorList)
        {
            sumOfFactors += x;
        }
        if (sumOfFactors == num)
        {
            System.Console.WriteLine($"{num} is a perfect number");
        }
        else
        {
            System.Console.WriteLine($"{num} is not a perfect number");
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
                Console.WriteLine($"Invalid input, please enter an input of {typeof(T)}");
            }
        }
    }
    static List<int> GetFactors(int n)
    {
        List<int> factors = [];

        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
                if (i != n / i)
                {
                    factors.Add(n / i);
                }
            }
        }
        return factors;
    }
}