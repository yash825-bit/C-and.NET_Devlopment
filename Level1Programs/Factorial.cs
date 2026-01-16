using System;

namespace Level1Programs;

public class Factorial
{
    public static int FactorialNum(int n)
    {
        if (n == 1 || n == 0) return 1;
        return n * FactorialNum(n - 1);
    }
}
