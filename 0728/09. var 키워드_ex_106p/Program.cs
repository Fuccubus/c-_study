using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.var_키워드_ex_106p
{
    class A
    {
        public int m_a = 33;
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            System.Int32 aaint = 33; // int aaint = 33;와 같은 의미
            var asd = 3.14f;         // 우변된 값을 기준으로 자료형을 해석해서
                                     // 값에 맞는 변수를 자동으로 생성
                                     // 때문에 우변된 값을 해석하기 전까진 어떠한 저장공간을 할당받지 못하므로 
                                     // static과 같은 정적(전역)변수로써 사용할 수 없고,
                                     // 오로지 지역 내에서만 사용할 수 있는 단점이 존재한다.
            Console.WriteLine(asd.GetType()); // .GetType() 함수는 해당 변수의 자료형 타입을 보여준다.
            Console.WriteLine(aaint);

            var pp = new A();
            pp.m_a = 33;      

            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello, World!";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.Write("Type : {0}, Value : ", d.GetType());
            foreach (var e in d)
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine();

        }
    }
}
