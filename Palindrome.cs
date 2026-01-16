using System;

namespace HelloCSharp
{
    public class Palindrome
    {
        public static void Run()
        {
            Console.Write("Enter a number to check whether it is palindrome or not : ");

            int num = Convert.ToInt32(Console.ReadLine());

            int old_num = num;
            int reverse = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                reverse = reverse * 10 + lastDigit;
                num /= 10;
            }
            if(reverse == old_num)
            {
                System.Console.WriteLine($"{old_num} is a palindrome");
            }
            else
            {
                System.Console.WriteLine($"{old_num} is not a palindrome");
            }
        }
    }
}