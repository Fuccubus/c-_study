using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class A
{
    public int a = 3;               //부모 객체 a
}

class B : A
{
    public int a = 100;             // 자식 객체 a
    public void print()
    {
        Console.WriteLine(a);       // 자기자신의 객체 접근
        Console.WriteLine(base.a);  // 앞에 base. 키워드를 붙이면..
    }                               // 부모 객체에 접근하게 된다..
}

class Program
{
    static void Main()
    {
        B b = new B();
        b.print();
    }
}

/*
class calc1
{
    public int x;
    public calc1(int a, int b)
    {
        x = a + b;
    }
}

class calc2 : calc1
{
    public calc2(int c, int d):base(c,d) // 파생 클래스에서 기반 클래스의 생성자를 호출할 때 Base 키워드를 사용한다.
    {
        x = c + d;
    }
}
 class Program
 {
    static void Main(string[] args)
    {
        calc2 cx = new calc2(1, 2);
        Console.WriteLine(cx.x);
    }
}
*/
