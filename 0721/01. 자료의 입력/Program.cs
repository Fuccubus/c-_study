using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.자료의_입력
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            Console.WriteLine("입력한 문자는" + inputNum);

            //숫자로 출력하기            
            Console.WriteLine("입력한 숫자는" + int.Parse(inputNum));
            Console.WriteLine("입력한 숫자는" + Convert.ToInt32(inputNum));
        }
    }
}