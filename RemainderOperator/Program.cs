using System;
class RemainderOperatorApp
{
    public static void Main()
    {
        int n, rem;
        rem = 10 % 3;
        n = 10 - (10 / 3) * 3;
        Console.WriteLine("10 % 3 = " + rem);
        Console.WriteLine("10-(10/3)*3 = " + n);
    }
}