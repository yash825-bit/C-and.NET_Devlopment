using System;

namespace MathUtils;

public class Factorials
{
    public static int Factfunc(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Factfunc(n - 1);
    }
}