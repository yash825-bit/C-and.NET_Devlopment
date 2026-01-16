using System;

namespace Level1Programs
{
    public class CheckPrimeNumber
    {
        public static void Run()
        {
            Console.Write("Enter a number to check whether it is prime or non-prime : ");
            int num = Convert.ToInt32(Console.ReadLine());

            CheckPrimeNumber obj = new();
            if (obj.CheckPrime(num))
            {
                System.Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                System.Console.WriteLine($"{num} is not a prime number");
            }
        }
        private Boolean CheckPrime(int num)
        {
            int count = 0;
            for(int i = 1 ; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count == 2)return true;
            return false;
        }
    }
}