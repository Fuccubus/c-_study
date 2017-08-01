using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.응용문제
{
    class Program
    {
        static void Main(string[] args)
        {
            float myHgt = 174.5f, myWgt = 105.8f;
            float avWgt = (myHgt - 100.0f) * 0.9f;
            float myBmi = (myWgt - avWgt) / avWgt * 100.0f;

            Console.WriteLine("당신의 비만도는" + myBmi + "%입니다.");
        }
    }
}