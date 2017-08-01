using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.배열_array_의_정의
{
    class Program
    {
        static void Main(string[] args)
        {


            {   //다차원 배열

                // C언어 방식의 2차원 배열int[][] num2;
                int[] ary1;
                int[,] ary2;            // 2차원
                int[,,] ary3;           // 3차원
                ary1 = new int[2];      // [] []
                ary2 = new int[2, 3];
                // [] [] []
                // [] [] []

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" " + ary2[i, j]);
                    }
                    Console.WriteLine();
                }

                ary3 = new int[2, 3, 4];
                //          [] [] [] []
                //   []  :  [] [] [] []
                //          [] [] [] []
                //          [] [] [] []
                //   []  :  [] [] [] []
                //          [] [] [] []





                int row, col;
                string inputData;
                Console.Write("row->");
                inputData = Console.ReadLine();
                row = int.Parse(inputData);
                Console.Write("col->");
                inputData = Console.ReadLine();
                col = int.Parse(inputData);

                int[,] aryData = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(" " + aryData[i, j]);
                    }
                    Console.WriteLine();
                }

                // 배열변수.Length => 전체 배열의 갯수를 구한다.
                int[] arrData2 = new int[5];
                Console.WriteLine(arrData2.Length); // 배열의 갯수

                int[,] arrData3 = new int[3, 5];
                Console.WriteLine(arrData3.Length); // 배열의 갯수
            }
        }
    }
}

/*
            배열 array
            같은 형태의 여러 개의 자료형을 하나의 이름으로 정의해서 사용하는 것

                    C# 언어                    C언어
              int[] a = new int [5];         int a[5];
              
            1. 배열형 변수 선언
            2. 갯수나 값의 초기화
            
            int[] num;        // 데이터형[] 배열명;
            num = new int[5]; // 초기화 new 데이터형[갯수]; => 배열변수에 할당.

            num[0] = 111;     //값의 세팅(값을 안 넣으면 0으로 출력)
            num[1] = 222;
            num[2] = 333;
            num[3] = 444;
            num[4] = 555;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("배열->" + num[i]);
            }
                
            // int a[5];        => int []a = new int[5];
            // int a[5] = {};   => int []a = new int[5];

            int[] num2 = { 486, 123, 999, 777, 888 }; //=> int a[] = {1,2,3,4,5}와 동일

            Console.WriteLine("배열->" + num2[0]);

            {
                float[] tst1 = new float[3];                            // 빈 배열
                float[] tst2 = { 3.14f, 4.12f, 5.5f };                  // 생성과 동시에 초기화
                float[] tst3 = new float[] { 3.14f, 4.12f, 5.5f };      // 생성과 동시에 초기화
                                                                        // 배열형 -> 갯수는 데이터 갯수만큼
            }

            {   // 배열에 있어서 표준적으로 사용하는 기능은
                // array.기능(배열)... 사용
                int[] numNum = { 3, 2, 1, 6, 7, 9, 8 };
                Array.Sort(numNum); // 위의 숫자들을 순서대로 정렬
                for(int i = 0; i < 7; i++)
                {
                    Console.Write(" " + numNum[i]);
                }

                int count = 3;
                int[] ary4 = new int[count];
                for(int i = 0; i < count ;i++)
                {
                    Console.WriteLine("갯수" + ary4[i]);
                }        

            }
            */