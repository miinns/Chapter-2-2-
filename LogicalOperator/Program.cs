using System;
class LogicalOperatorApp
{
    public static void Main()
    {
        Console.WriteLine("TRUE AND TRUE = " + (true && true));
        Console.WriteLine("TRUE AND FALSE = " + (true && false));
        Console.WriteLine("FALSE AND TRUE = " + (false && true));
        Console.WriteLine("FALSE AND FALSE = " + (false && false));

        int x = 3, y = 5, z = 7;
        bool b;
        b = x < y && y < z;
        Console.WriteLine("Result = " + b);
        b = x == y || x < y && y > z;
        Console.WriteLine("Result = " + b);
            }
}