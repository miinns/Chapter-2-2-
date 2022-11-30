using System;
class DivisionOperatorApp
{
    public static void Main()
    {
        int i; double x;
        i = 1 / 2;
        x = 1 / 2;
        Console.Write("i = " + i);
        Console.WriteLine(", x = " + x);
        i = (int)(1 / 2.0); 
        x = 1 / 2.0;
        Console.Write("i = " + i);
        Console.WriteLine(", x = " + x);
    }
}
