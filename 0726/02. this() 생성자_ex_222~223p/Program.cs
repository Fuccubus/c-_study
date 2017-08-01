using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.this___생성자_ex_222_223p
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine("MyClass({0})", b);
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine("MyClass({0}. {1})", b, c);
        }

        public void PrintFields()
        {
            Console.WriteLine("a:{0}, b:{1}, c:{2}", a, b, c);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}

/*
 * class AAA
 * {
 *      int m_a, m_b;
 *      // this.m_a; => .연산자는 클래스의 내부 데이터를 의미
 *      // 내부에 return 타입이 없는 메서드는? -> 생성자(constructor)
 *      // 클래스 내의 :연산자는 영역지정 연산자를 의미
 *      
 *      // public AAA() : AAA(0,0) ==> 잘못된 영역지정 연산자
 *      //                              클래스가 생성되고 생성되고 생성자를 호출할 때는 쓸 수 있지만
 *      //                              내부에 있는 생성자 메서드를 호출할 수 없다
 *      
 *      // public AAA() : this(0,0)  => 올바른 영역지정 연산자
 *      // {                            : 내 영역에 있는...
 *      // }                            : this()는 => this 생성자)
 *      //                                            현재 내 생성자에 작성이 끝난 다른 생성자(현재 클래스 내부의)를 호출할 때 사용
 *      //                                            이를 이용해 불필요하게 중복되는 로직을 작성할 필요가 없음
 *      //                                            단, this 생성자는 현재 자신의 생성자를 호출할 수 없다
 *      //                                            이미 정의가 완료된 생성자만 호출이 가능
 *      //                                            다른 생성자에서 this 생성자는 현재 내가 작성 중인 생성자를 호출할 수 없다.
 *                                      
 *      
 *      public AAA(int a, int b)
 *      {
 *          m_a = a;
 *          m_b = b;
 *      }
 * }
 * 
 * class Program
 * {
 *      static void Main()
 *      {
 *      
 *      }
 * }
