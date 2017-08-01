using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parent
{
    public virtual void name()
    {
        Console.WriteLine("부모");
    }
}

class Child : Parent
{
    public override void name() // 1) 파생 클래스 Child의 입장에선 기반 클래스 Parent 내 name()메서드의 재정의(override)이지만...
    {
        Console.WriteLine("자식");
    }
}

class GrandSon : Child          // 2) Child 클래스가 이미 재정의한 메서드는 파생 클래스인 GrandSon의 입장에선 virtual이나 다름없다
{
    public override void name()
    {
        Console.WriteLine("손자");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parent obj1 = new Parent();
        Child obj2 = new Child();
        GrandSon obj3 = new GrandSon();

        obj1.name();
        obj2.name();
        obj3.name();
    }
}