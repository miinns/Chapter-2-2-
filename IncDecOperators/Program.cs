using System;
class IncDecOperatorsApp
{
    public static void Main()
    {
        int x = 3, y = 5;
        int a, b;
        ++x; --y;
        Console.WriteLine("x = " + x + " , y = " + y);
        a = (++x) + 1; //전위 연산자를 사용하기 때문에 y증가 후 연산 시작
        Console.WriteLine("x = " + x + " , a = " + a);
        b = (y++) + 1; // 후위 연산자를 사용하기 때문에 연산 마치고 후위에 y증가
        Console.WriteLine("y = " + y + " , b = " + b);
    }
}