using System;

namespace Level1Programs
{
    public class SumOfDigits
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to find sum of it's digits : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int copy_num = num;
            int sum = 0;
            while(num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }
            System.Console.WriteLine($"The sum of digits in {copy_num} is {sum}");
        }
    }
}