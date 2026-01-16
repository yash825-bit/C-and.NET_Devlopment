using System;

namespace HelloCSharp
{
    public class FirstProgram
    {
        public static void Run()
        {
            Console.Write("Enter a year : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if((n % 4 == 0 && n % 100 !=0) || (n % 400 == 0))
            {
                System.Console.WriteLine("year {0} {1} ",n.ToString()," is a leap year");
            }
            else
            {
                System.Console.WriteLine("year {0} {1} ", n.ToString()," is not a leap year");
            }
        }
    }
}