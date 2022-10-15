using System;
class CastOperatorApp
{
    public static void Main()
    {
        int i = 0Xffff;
        short s;
        s = (short)i; //값이 바뀌는 경우
        Console.WriteLine("i = " + i);
        Console.WriteLine("s = " + s);
    }
}