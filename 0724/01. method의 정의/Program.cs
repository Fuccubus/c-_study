using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.method의_정의
{
    // 메서드(method)란 : 프로그램 내에서 결과를 도출하는 로직을 특정한 이름으로 정의한 것.
    // 공식
    // c언어  :                   returntype 메서드명 (파라미터)
    // c#언어 : 접근권한 변수타입 returntype 메서드명 (파라미터)
    //           public   static      int      add    (int x, int y)
    // c#언어의 메서드는 class 내에서 사용을 한다.
    class Program
    {
        int numData(int x)
        {
            int ret = 3;
            return ret;
        }
        void Main2()
        {
            numData(3);
        }
        // 접근권한 변수타입 returntype 메서드명 (파라미터)
        public static int add_Data(int a, int b) // 접근권한의 종류 : public, protected, private
        {
            int ret = 0;
            ret = a + b;
            return ret;
        }

        public static float add_Data(float a, float b)
        {
            float ret = 0;
            ret = a + b;
            return ret;
        }

        public static string add_Data(string a, string b)
        {
            string ret = "";
            ret = a + b;
            return ret;
        }
        // 컴파일러가 메서드를 인식할 때는...
        // c언어는 이름으로 인식 => 메서드명을 중복 불가 => 고유함(unique)
        // c#언어는 파라미터 타입으로 인식 => 파라미터가 다르면 메서드명을 중복으로 사용해도 무방 => 같은 이름의 같은 파라미터의 메서드는 불가
        // 이같이 함수를 중복으로 정의하는 것을 overload라 칭함

        static void Main(string[] args) // static 이란 자료타입이 정적(종료가 되기 전까지 메모리 상에 계속 존재)
                                        // 호출하는 메서드는 해당영역의 자료타입에 맞추어야 한다.
        {
            int num1, num2, num3;
            num1 = 123;
            num2 = 456;
            num3 = 0;

            //두 수를 더하는 기능을 새로 정의...
            num3 = add_Data(num1, num2); //함수의 호출.. c, c# 동일
            Console.WriteLine(num3);

            float nFlt1, nFlt2, nFlt3;
            nFlt1 = 1.14f;
            nFlt2 = 2.0f;
            nFlt3 = 0.0f;

            nFlt3 = add_Data(nFlt1, nFlt2);
            Console.WriteLine(nFlt3);

            string nStr1, nStr2, nStr3;
            nStr1 = "Hello ";
            nStr2 = "World123";
            nStr3 = "";

            nStr3 = add_Data(nStr1, nStr2);
            Console.WriteLine(nStr3);
        }
    }
}