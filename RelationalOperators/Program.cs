using System;
class RelationalOperatorsApp
{
    public static void Main()
    {
        int x = 3, y = 5, z = 7;
        bool b1, b2;
        b1 = x > y;
        b2 = x < y && y < z;
        Console.WriteLine("b1 = " + b1 + ", b2 = " + b2);
        b1 = x <= y;
        b2 = x >= y == y >= x;
        Console.WriteLine("b1 = " + b1 + ", b2 = " + b2);
    }
}