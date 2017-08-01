using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.중첩_method
{
    class Program
    {
        // c언어는 메서드를 선언(형태를 정의하다 : 메모리를 사용 안 함
        //                      (메서드가 어떻게 작동되는지 로직만 작성)
        //                      오직 선언 이후에 사용 가능
        //                      메서드의 작성 순서도 중요
        //                      Main 상단부에 메서드가 위치해야 하고, 메서드의 로직 또한 비대화(실제 메인로직의 수정이 어려움 => 메서드 프로토 타입)
        //                      메서드를 선언부와 비슷하게 해야 함. {} 없이, 재정의 끝에는 ;가 들어감
        //                  예) static void method_B();

        // c#언어는 메서드가 정의만 되어 있으면 어디서는 호출이 가능하고, 정의하는 위치는 중요하지 않다.
        //                      메서드의 정의할 위치는 중요 X, 오직 메서드의 정의 여부만이 중요함
        //                      메서드의 프로토 타입이 필요없음       

        static void Main(string[] args)
        {
            method_B();
            method_A();
        }
        static void method_B()
        {
            // 중첩 메서드 : 호출된 메서드 내에서 다른 메서드를 호출해서 사용할 수 있다.
            method_A();        // 메서드 내에서 다른 메서드 호출
            Console.WriteLine("B 메서드");

            method_A();
            Console.WriteLine("--------");
        }

        static void method_A() // 메서드가 정의된 위치(c#언어에선 정의위치는 중요하지 않음)
        {                      // 반면 c언어의 경우 반드시 Main 상단부에 위치해야 함
            Console.WriteLine("A 메서드");
        }
    }
}