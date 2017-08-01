using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.재귀_method
{
    class Program
    {
        // 재귀 메서드
        // 중첩 메서드와 다른 점 : 메서드 내에서 자기 자신 메서드를 호출
        //                         반드시 끝을 지정해줘야 하며, 만약 끝이 없다면 무한 루프하게 됨
        public static uint factorial(uint number)
        {
            if (number <= 1) // 값이 1 이하일 시
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1); // 기입한 값 * 기입한 값 - 1(계산을 거듭할수록 1씩 줄어듬)
            }
        }
        static void Main(string[] args)
        {
            uint result;
            result = factorial(5); // factorial => 5! 5*4*3*2*1 =?
            Console.WriteLine("5! = 5*4*3*2*1 => " + result);
        }
    }
}