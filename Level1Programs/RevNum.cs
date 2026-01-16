using System;

namespace Level1Programs
{
    public class RevNum
    {
        public static void Run()
        {
            Console.Write("Enter a number to  find reverse of it : ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int copy_num = num;
            int rev_num = 0;

            while(num > 0)
            {
                int lastDigit = num % 10;
                rev_num = rev_num * 10 + lastDigit;
                num /= 10;
            }
            System.Console.WriteLine($"reverse number of {copy_num} is {rev_num}");
        }
    }
}