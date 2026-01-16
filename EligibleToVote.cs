using System;

namespace HelloCSharp
{
    public class EligibleToVote
    {
        public static void Run()
        {
            Console.Write("Welcome, to the Vote Eligibilty checker program");
            Console.Write("Please, Enter your age : ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                System.Console.WriteLine("you are elligible to vote");
            }
            else
            {
                System.Console.WriteLine("you are not elligible to vote");
            }
        }
    }
}