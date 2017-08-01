using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.method_ex_190p_가변길이_매개변수_
{
    class MainApp
    {
        public static int Sum(params int[] args)
        {
            Console.Write("Summing... ");

            int sum = 0;

            for (int i = 0; i < args.Length; i++) // for > if 순으로 출력
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine("Sum : {0}", sum);
        }
    }
}