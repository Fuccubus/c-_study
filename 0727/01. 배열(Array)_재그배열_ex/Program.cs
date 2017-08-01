using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.배열_Array__재그배열_ex
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

            // 배열의 길이 확인하기(.Length 연산자)
            Console.WriteLine("배열a : {0}, 배열b : {1}", a.Length, b.Length); // .Length = 배열의 길이

            Console.WriteLine("{0}, {1}, {2}", c[0][0], c[0][1], c[0][2]);
            Console.WriteLine("    {0}, {1}", c[1][0], c[1][1]);
            Console.WriteLine("        {0}", c[2][0]);

            int[] array1 = new int[4];
            int[,] array2 = new int[2, 3];
            int[,,,] array3 = new int[2, 4, 3, 2];

            // 배열의 차원 확인하기(.Rank 연산자)(
            Console.WriteLine("1번쨰 배열" + array1.Rank); // .Rank = 배열의 차원 갯수
            Console.WriteLine("3번째 배열" + array3.Rank);
            Console.WriteLine("2번째 배열" + array2.Rank);
        }
    }
}