using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.배열의_복사_ArrayCopy_
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열의 복사 1) 같은 공간을 보유
            //               내부적으론 class의 메커니즘과 비슷하다
            long[] origin = new long[4] { 1, 2, 3, 4 };
            long[] copy = origin;

            Console.WriteLine("1 : " + copy[3]);

            origin[3] = 12345;

            Console.WriteLine("2 : " + origin[3]);
            Console.WriteLine("2_2 : " + copy[3]);
            Console.WriteLine("----------------------");

            //배열의 복사 2) 클론(Clone) 함수를 이용하기
            //               전자와 달리 같은 저장공간을 공유하지 않고, 독자적으로 공간을 생성해 복사한 값을 이관
            //               때문에 클론 함수를 이용해 복사한 값은 변경해도 원본이 바뀌지 않는다
            //               클론 함수는 리턴 타입이 object이므로 문자든, 실수든, 정수든 상관없이 복사할 수 있다
            int[] a = { 5, 4, 3, 2, 1 };
            int[] clone = (int[])a.Clone();

            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("배열 값 : " + a[i]);
            }
            Console.WriteLine("----------------------");


            clone[2] = 33;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("변경된 배열 값 : " + a[i]);
            }
            Console.WriteLine("----------------------");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("변경된 배열 값 : " + clone[i]);
            }
            Console.WriteLine("----------------------");
        }
    }
}
