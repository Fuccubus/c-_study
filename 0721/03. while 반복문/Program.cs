using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.while_반복문
{
    class Program
    {
        static void Main(string[] args)
        {


            // do 무조건 한번 실행한 뒤
            //{
            //}
            // while(); <- 그냥 while과 다르게 뒤에 세미콜론(;)이 들어감

            int num = 1;
            do
            {
                Console.WriteLine("값 : " + num);
                num += 2;
            }
            while (num <= 15);



            // if문으로 바꾸면..
            if (num > 5)
            {   // 메모리 영역 가변으로 -> 1개의 기능을 위한.. -수행한다.
                Console.WriteLine("aaaa");
            }
            if (num > 10)
                Console.WriteLine("aaaa"); //처리영역(기능수행영역 1줄)


        }
    }
}

/*
            // C언어에서 while문은..

            // while(조건) >~~~~ true false
            // C언어에선 bool의 true, false 외에도 int의 0(거짓), 1(참)도 인식하지만,
            // C#에선 오직 bool만 인식함

            int i = 10;
            while(i > 0)
            {
                Console.WriteLine("값 : " + i--);
            }
            Console.WriteLine("---- " + i--);
       


            // while문을 이용해 1, 3, 5, 7, 9, 11, 13, 15를 출력
            int num = 1;
            while (num <= 15)
            {
                Console.WriteLine("값 : " + num); // 값을 출력한 후
                num += 2;                         // 출력한 뒤 num에 2씩 증가
            }
            */