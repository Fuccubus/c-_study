using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.인덱서_Indexer_의_정의_ex_333p
{/* 
  * 인덱서(Indexer)란?) 객체 내의 배열을 접근(Access)하지만,
  *                     사용할 땐 클래스를 배열처럼 직접 취급하는 문법.
  *                     기본 문법의 베이스는 속성(Property, get/set)과 유사하다.
  *                     
  * 
  *      인덱서의 특징) 1. 배열을 접근하듯이 []기호를 사용함
  *                     2. this 키워드를 사용한다.
  *                     3. get/set 접근자로 표현
  *                     4. 멤버 변수처럼 보이지만, 내부적으론 메서드로써 동작
  *                     
  *                     
  *               형식) 멤버 자료형으로써 배열이 필요
  *               
  *                     접근권한 리턴타입 this [index]
  *                     {
  *                         get / set 사용
  *                     }
  */
  class K
    {
        int[] num = new int[4];     // 접근권한 기입 안 하면 => 자동으로 private
        public int this[int i]      // 해당 키워드를 통해 내부 정보에 접근
        {
            get { return num[i]; }  // get 객체

            set { num[i] = value; } // set 객체
        }
    }

    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            K kk = new K();
            kk[0] = 123;
            kk[1] = 486;
            kk[2] = 333;
            kk[3] = 777;

            for (int i = 0; i < 4; i++)
                Console.WriteLine(kk[i]);

            Console.WriteLine("\n");

            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
