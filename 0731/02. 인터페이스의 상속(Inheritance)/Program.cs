using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *  인터페이스의 상속) 인터페이스는 클래스처럼 상속해서 새로운 인터페이스를 만들 수 있다.
 *                     이 때 상속받는 인터페이스는 :기호를 사용한다.(클래스와 동일)
 *                 ex) interface A : B
 *                     {}
 *                
 *                     인터페이스는 클래스와 다르게 복수로 상속받을 수 있다 => 기능(메서드)의 형태만 추가이기 때문
 *                 ex) interface A : B,C,D,E
 *                     {}
 * 
 * 상속형식을 만들 때) 파생 객체(자식)와 기반 객체(부모)의 멤버 메서드가 중복될 시
 *                     모호성이 발생되며, 이에 대해 컴파일러는 경고를 호출한다.
 *                     
 *                     부모자식이 같은 멤버가 갖고 있다면 부모 객체의 멤버를 은폐시켜야 한다.
 *                     이를 위해 은폐 키워드인 new 를 사용한다.
 *                     
 *         new 키워드) 사용하는 영역에 따라 쓰임새가 틀리다.
 *                     
 *                     클래스의 외부에서 사용할 때)
 *                     객체에 맞는 크기의 저장공간을 할당    
 *                     
 *                     클래스의 내부에서 사용할 때)
 *                     부모 클래스와 자식 클래스 간의 중복되는 멤버를 은폐
 *                     
 */
namespace _02.인터페이스의_상속_Inheritance_
{
    interface A
    {
        void f();
    }
    interface B : A
    {
        new void f(); // 기반 객체에 똑같은 멤버변수 f가 있으므로,
                      // 자식 객체는 반드시 new를 앞에 붙여야 한다.
    }
    class C : B
    {
        public void f()
        {
            Console.WriteLine("aaa");
        }
    }
    class D : C
    {
        new public void f()
        {
            Console.WriteLine("bbb"); // 기반 객체에 똑같은 멤버변수 f가 있으므로,
                                      // 자식 객체는 반드시 new를 앞에 붙여야 한다.
        }
    }



    interface Greet
    {
        void greet();
    }
    interface Bye : Greet
    {
        void bye();
    }
    class GreetInt : Bye
    {
        public void greet()
        {
            Console.WriteLine("Hello");
        }
        public void bye()
        {
            Console.WriteLine("Bye");
        }
    }



    interface ILogger                            // 인터페이스 1
    {
        void WriteLog(string message);
    }
    //        자식 인터페이스    : 부모 인터페이스
    interface IFormattableLogger : ILogger       // 인터페이스 2가 위의 인터페이스 1을 상속받음
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("the World is not Flat.");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);

            Console.WriteLine("\n=======================");

            GreetInt gt = new GreetInt();
            gt.greet();
            gt.bye();
        }
    }
}
