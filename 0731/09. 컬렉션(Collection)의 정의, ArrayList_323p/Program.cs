using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 컬렉션이란?) 1개 이상의 같은 자료형의 집합
 * 
 * 컬렉션의 종류) 1. ArrayList => list 객체
 *                2. HashTable => Dictionary (key-value 객체)
 *                3. Stack
 *                4. Queue
 *                
 * 컬렉션을 사용하기 위해선 using 키워드로 System.Collections을 미리 선언해놓아야 한다.
 */
namespace _09.컬렉션_Collection_의_정의__ArrayList_323p
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // Add, Remove, Insert. RemoveAt, IndexOf, Clear, Count

            ArrayList list = new ArrayList();// 생성 및 초기화
                                             // 데이터가 없는 최소한의 공간
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (object obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
                Console.Write(" {0} ", list.IndexOf(i));
            }

            Console.WriteLine();
        }
    }
}