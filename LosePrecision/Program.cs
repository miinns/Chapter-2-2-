using System;
class LosePrecisionApp
{
    public static void Main()
    {
        int big = 1234567890;
        float approx;
        approx = (float)big;
        Console.WriteLine("difference = " + (big - (int)approx));
    }
}