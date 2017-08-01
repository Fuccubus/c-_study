using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.if_else와_switch_case_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;

            // if-else문
            if (num >= 90)
            {
                Console.WriteLine("학점 A");
            }
            else if (num >= 80)
            {
                Console.WriteLine("학점 B");          
            }
            else
            {
                Console.WriteLine("학점 C");
            }

            // switch-case
            switch(num/10)
            {
                case 10:
                    Console.WriteLine("학점 S");
                    break;
                case 9:
                    Console.WriteLine("학점 A");
                    break;
                case 8:
                    Console.WriteLine("학점 B");
                    break;
                default:
                    Console.WriteLine("학점 C");
                    break;
            }
        }
    }
}