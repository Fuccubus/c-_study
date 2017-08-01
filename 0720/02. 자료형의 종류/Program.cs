using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.자료형의_종류
{/*
            자료형
            var num = "asss";
            Console.WriteLine(num);
            var num2 = 333;
            Console.WriteLine(num2);

            정수            c언어            크기            c#언어             
            int       : -21억 ~ 21억     =  4byte  =  "
            long      : -21억 ~ 21억     =  4byte  =  8byte(21억 이상의 엄청 큰 수) => longlong          
            short     : -32768 ~ 32767   =  2byte  =  "
            char      : -128 ! 127       =  1byte  =  "
            long long :                  =  8byte  =  x
            byte      : 0 255            =  1byte  =  "


            자료형에서 c#만의 특징            
            c언어에선 unsigned를 붙이고,                c#언어에선 u를 붙인다
            unsigned int                             uint
            unsigned long                            ulong
                                                     u+자료형 => unsigned 자료형 타입이다

            실수(정수로는 불가능한 정밀한 계산을 할 때 사용)

            float     : 소수점 3자리수 정밀도
            double    : 소수점 8자리수 정밀도
            위의 둘은 c, c# 공통으로 쓰이는 자료형
            
            c#언어 만의 실수
            decimal   : double 보다 훨씬 더 정밀한 자료형
            사람들은 실수 계산을 말하면 보통 float을 떠올리지만, 컴퓨터는 보통 double을 떠올린다.

            실수 자료형 타입을 표시하면..
            double  => 3.14159
            float   => 3.14159f
            decimal => 3.14159m            
  */

    class Program
    {
        static void Main(string[] args)
        {
            byte byteValue = 250;    // 바이트 자료형은 원래 (양) 정수 타입
            sbyte byteValueS = -120; // 음수 양수
            int intValue = 123456789;
            uint unsignedIntValue = 3876543210;
            long longValue = 12345678987654;
            ulong unsignedLonbValue = 24691357975309;

            Console.WriteLine("값은 \n {0} {1} {2} {3} {4} {5}", byteValue, byteValueS, intValue, unsignedIntValue, longValue, unsignedLonbValue);

            /* int에 unsigned(부호없음)를 붙이려면 앞에 u를 기입한다
             *      예) int -> uint
             *      
             * 반면 byte는 기본적으로 부호가 없기에 u 대신 s(signed)를 붙여야 한다
             *      예) byte -> sbyte
             */
            
         // 소숫점이 필요할 만큼 정교한 계산이 필요할 땐...
         // 정수 대신 실수를 쓴다.

            double dValue = 3.1415;    // double은  3자리까지
            float fValue = 3.1415f;    // float은   8자리까지
            decimal dmValue = 3.1415m; // decimal은 8자리 이상까지 가능

                                       // double 외 float과 decimal은 반드시 기입한 값 뒤에 구분해주는 문자를 적어야 한다.

                                       //                   ex) double  = 3.14;
                                       //                       float   = 3.14f; <= 'f'loat   의 'f'
                                       //                       decimal = 3.14m; <= deci'm'al 의 'm'

            Console.WriteLine("실수 값은 \n {0} {1} {2}", fValue, dValue, dmValue);

            //환구조에 대해 알아보기
            //int maxValue = 2300000000;
            int maxValue = int.MaxValue;
            maxValue++;

            Console.WriteLine(maxValue);

            int minValue = int.MinValue;
            minValue--;

            Console.WriteLine(minValue);
        }
    }
}

