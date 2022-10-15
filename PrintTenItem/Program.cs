using System;
class PrintTenItemApp
{
    public static void Main()
    {
        int i, n = 25;
        for (i = 1; i <= n; ++i)
            Console.Write(i + ((i % 10 == 0 || i == n) ? "\n" : " "));
    }
}