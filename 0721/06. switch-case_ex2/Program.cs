using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.switch_case_ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputDay = Console.ReadLine(); // 입력을 받는다/

            switch (inputDay)
            {
                case "일":
                    Console.WriteLine("sun");
                    break;
                case "월":
                    Console.WriteLine("mon");
                    break;
                case "화":
                    Console.WriteLine("tue");
                    break;
                case "수":
                    Console.WriteLine("wed");
                    break;
                case "목":
                    Console.WriteLine("thu");
                    break;
                case "금":
                    Console.WriteLine("fri");
                    break;
                case "토":
                    Console.WriteLine("sat");
                    break;
            }

            //요일을 입력 받으면 해당 요일을 영어로 출력하는 프로그램을 만드시오.
            //단, 요일 외 글자나 숫자를 입력받으면 "잘못 입력하셨습니다"를 출력할 것.
            // Hint) Console.Inputline , 1)if-else 2)switch-case 2번을 권장..

            /* 
            string inputDay = Console.ReadLine();

            switch (inputDay)
                {
                 내 스스로 한 것
                   case "일요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Sunday.");
                       break;
                   case "월요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Monday.");
                       break;
                   case "화요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Tuesday.");
                       break;
                   case "수요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Wednesday.");
                       break;
                   case "목요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Thursday.");
                       break;
                   case "금요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Friday.");
                       break;
                   case "토요일":
                       Console.WriteLine("입력한 요일을 영어로 말하면 Saturday.");
                       break;
                   default:
                       Console.WriteLine("잘못 입력하셨습니다.");
                       break;
                 }
             */
        }
    }
}