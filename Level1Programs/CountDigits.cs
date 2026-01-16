using System;

namespace Level1Programs
{
    public class CountDigits
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to find how many digits does it consists : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int copy_num = num;
            while(num > 0)
            {
                int lastDigit = num % 10;
                count++;
                num /= 10;
            }
            System.Console.WriteLine($"there are {count} digits in {copy_num}");
        }
    }
}