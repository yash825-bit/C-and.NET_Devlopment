using System;

namespace HelloCSharp
{
    public class EvenOdd
    {
        public static void Run()
        {
            Console.Write("Enter a number to check whether it is even or odd : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                System.Console.WriteLine($"{n} is an even number");
            }
            else
            {
                System.Console.WriteLine($"{n} is an odd number");
            }
        }
    }
}