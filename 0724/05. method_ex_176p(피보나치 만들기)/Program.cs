using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 소스를 분석할 땐 Main부터 볼 것(176p 기준)
// 28번 라인 피보나치 메서드 호출... 피보나치 값 10
// 30, 31 라인 PrintProfile() 메서드 선언
// 피보나치부터... 7~13
// 10
// 피보나치(9) + 피보나치(8)
//               피보나치(7) + (6)
//                     피보나치(5) + (4)
//                           피보나치(3) + (2)
namespace _05.method_ex_176p_피보나치_만들기_
{
    class MainApp
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("10번째 피보나치 수 : {0}", Fibonacci(10));

            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");
        }
    }
}