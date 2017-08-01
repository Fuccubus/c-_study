using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.배열_Array__ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] { 1, 2, 3 };  // 1차원 배열
            int[,] b = new int[2, 3]           // 2차원 배열
            {
                { 1,2,3},
                { 4,5,6}
            };
            int[][] c = new int[3][];          // 재그 배열
                                               // 초기화 방법
            c[0] = new int[3] { 10, 20, 30 };  // 방법 1)
            c[1] = new int[2] { 40, 50 };
            c[2] = new int[1] { 60 };

            int[][] d = new int[][]
            {
                new int[] { 10,20,30 },        // 방법 2) 생성과 동시에 초기화
                new int[] { 40,50 },
                new int[] { 60 }
            };

            Console.WriteLine("{0}, {1}, {2}", c[0][0], c[0][1], c[0][2]);
            Console.WriteLine("    {0}, {1}", c[1][0], c[1][1]);
            Console.WriteLine("        {0}", c[2][0]);
        }
    }
}
