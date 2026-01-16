using System;
namespace Level1Programs;

public class Armstrong
{
    public static void Main()
    {
        Console.WriteLine("Enter a number to check whether it's an Armstrong Number or not : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Armstrong obj = new();
        int arms_num = 0;
        int org_num = n;
        int count = obj.CountingDigits(n);
        while (n > 0)
        {
            int lastDigit = n % 10;
            arms_num += (int)Math.Pow(lastDigit, count);
            n /= 10;
        }
        if(arms_num == org_num)
        {
            Console.WriteLine($"{org_num} is an Armstrong number");
        }
        else
        {
            Console.WriteLine($"{org_num} is not an Armstrong Number");
        }
    }
    private int CountingDigits(int n)
    {
        int count = 0;
        while(n > 0)
        {
            int lastDigit = n % 10;
            count++;
            n /= 10;
        }
        return count;
    }
}