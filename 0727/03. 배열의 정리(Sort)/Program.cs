using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.배열의_정리_Sort_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arrData = { 5, 3, 4, 2, 2 };
            System.Array.Sort(arrData);

            for(i = 0; i < arrData.Length; i++)
            {
                Console.Write("  " + arrData[i]);
            }
            Console.WriteLine("\n ---------------");

            // 앞의 System. 을 생략할 수 있다. *** Console.WriteLine도 앞의 System.을 생략한 것!
            System.Array.Clear(arrData,          0,              2);
            //       읽는 법 : 배열자료형  시작 위치부터 ~ 끝 위치까지  => 세팅된 영역을 클리어(모두 0값, 즉 NULL값을 부여)
            //                    arrData       [0]      ~      [2] 이란 뜻

            for (i = 0; i < arrData.Length; i++)
            {
                Console.Write("  " + arrData[i]);
            }
            Console.WriteLine("\n ---------------");


            Array.Clear(arrData, 0, arrData.Length);

            for (i = 0; i < arrData.Length; i++)
            {
                Console.Write("  " + arrData[i]);
            }
            Console.WriteLine("\n -----------------> 여기까지가 System.Array.Clear\n\n");

            int[] tst = { 1, 3, 5, 7, 9 };
            int indexNum = System.Array.IndexOf(tst,             5);
            //                     읽는 법 : 배열자료형     배열 내 값  => 해당 배열 내 기입한 값이 들어있는 인덱스를 찾는다
            //                                                             처음부터 기입한 값이 있는 곳까지 순차적으로 찾는다

            Console.WriteLine("\n {0}, {1}, {2}, {3}, {4}", tst[0], tst[1], tst[2], tst[3], tst[4]);

            Console.WriteLine(" 값 5은 배열의 {0}번째 인덱스입니다.", indexNum);

            indexNum = Array.IndexOf(tst, 9);

            Console.WriteLine(" 값 9은 배열의 {0}번째 인덱스입니다.", indexNum);
            Console.WriteLine("\n -----------------> 여기까지가 System.Array.IndexOf\n");
        }
    }
}
