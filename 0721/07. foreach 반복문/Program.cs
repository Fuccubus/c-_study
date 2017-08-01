using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.foreach_반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 문을 이용한 객체 데이터 접근 및 정보 취득...
            // 컬렉션 : 객체 1개 이상의 데이터를 가진 (복수)자료형, 클래스.
            // 배열... 배열 index, 리스트, 현재 위치... 데이터 1개.
            // foreach(데이터타입 변수명 in 배열이나 컬렉션 객체)
            // => 해당 객체가 가진 모든 데이터를 ()안에 선연된 변수에 차례로 넣어줌.
            int[] num = { 1, 2, 3, 4, 5 };
            foreach (int readData in num)   // 하나씩 넣어주면서 반복 > 값이 없을 때까지
            {
                Console.WriteLine(readData);
            }
            Console.WriteLine();
            string[] itmList = new string[] { "집행검", "돌도끼", "레이져총" };
            string[] tmp = new string[3];
            int count = 0;
            foreach (string itmName in itmList)
            {
                Console.WriteLine(itmName);
                tmp[count] = itmName;
                count++;
            }
            Console.WriteLine();
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(tmp[j]);
            }
        }
    }
}