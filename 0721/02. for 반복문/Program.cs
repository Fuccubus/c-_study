using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.for_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            // for문을 이용한 구구단
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " 곱하기 " + j + "는 " + (i * j));
                }
            }



            // for문을 이용한 별찍기
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 5 - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            /*
            for(int i = 1; i<10;i+=2) // 1 3 5 7 9 출력
            {
                Console.WriteLine(i);
            }
            */


            // 반복문 탈출문
            // continue : 현재 조건을 건너뜀(현재 상황만 탈출.. 다시 복귀)
            // break    : 가장 가까운 반복문을 탈출

            for (int k = 1; k < 3; k++)
                for (int i = 1; i < 12; i++) // 1 3 5 7 9 출력
                {
                    if (i == 5) continue;
                    //탈출 시 이하 구문은 실행 안됨

                    if (i == 9) break;
                    Console.WriteLine(i);
                }



        }
    }
}

// for 문 = 원하는 수만큼 반복문을 실행하고 싶을 때 사용
// for 문의 형식 = 

/*
        // 객체지향 언어에서 자료형은 필요할 때 생성해서 사용한다.
        // 자료형의 적용범위는 선언 이후부터 ~ 해당 영역이 끝날 때까지.
        int i = 3;

        for(; i<=5; )// 해당 세팅부는 필요에 따라 생략이 가능
        // 초기값, 조건식(반복문 탈출을 위해), 증감식(반복탈출을 위한 값의 변경)
        {
            Console.WriteLine("출력");
            i++;
        }
        Console.WriteLine("출력==>" + i);
        */