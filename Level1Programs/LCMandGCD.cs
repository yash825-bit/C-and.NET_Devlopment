using System;
namespace Level1Programs;

public class LCMandGCD
{
    public static void run()
    {

    }
    static T readInput<T>()
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
}