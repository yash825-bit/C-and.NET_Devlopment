using System;
namespace Level2Programs;

public class SumOfNumbers
{
    public static void Run()
    {
        Console.WriteLine("Enter the size of an array : ");
        int n = ReadInput<int>();

        Console.WriteLine("Enter the elements : ");
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ReadInput<int>();
        }
        Console.WriteLine(SumOfElements(arr));
    }
    private static T ReadInput<T>()
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
                Console.WriteLine($"Invalid Error ❌, Please enter an input {typeof(T).Name}");
            }
        }
    }
    private static int SumOfElements(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr)
        {
            sum += x;
        }
        return sum;
    }
}