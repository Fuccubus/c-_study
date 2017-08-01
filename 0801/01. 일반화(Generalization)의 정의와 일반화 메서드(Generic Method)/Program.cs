using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.일반화_Generalization_의_정의와_일반화_메서드_Generic_Method_
{/*    일반화를 부를 땐?) c#, java에선 Generic
  *                       c++ 에선 Template 이라 부른다.
  *
  *
  *           일반화란? ) 공통 자료형
  *                       어떤 자료형이든지 올 수 있도록 기호화한 키워드
  *                       선언 시 일반화시킬 대상의 이름 뒤에 <>키워드를 붙인다.
  *                       ex) 메서드명<T> 혹은 클래스명<T>
  *                    
  *                       <> 키워드 내부에 기입하는 것은 일반화 자료형의 이름으로
  *                       마치 변수명처럼 사용자가 구분하기 쉽게 정의하는 것 외의 의미는 없다.
  *                       
  *                       일반화 자료형은 1개 이상 가질 수 있다 => 이를 구분하기 위해 ,를 사용
  *                       
  *                    
  *    일반화 메서드란? ) 함수에 사용되는 자료형을 공통 자료형으로 셋팅한 메서드
  *                       파라미터와 로직 내 멤버변수를 선언할 때, 정확한 자료형 대신 자료형 T를 선언한다.
  *                   
  *        
  * 일반화 메서드의 형식) 리턴타입 메서드명 <일반화 자료명> (일반화 자료의 파라미터들)
  */
    class Program
    {//        리턴타입  메서드명  <일반화 자료명>  (일반화  자료의  파라미터들)
        static   void  calculate       <T, S>       (T t_x, T t_y, S s_x, S s_y)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", t_x, t_y, s_x, s_y);
        }

        static void Swap<T>(ref T x, ref T y)
        {
            T tmp;
            tmp = x;
            x = y;
            y = tmp;
        }

        static void SwapTest1()
        {
            int a = 1;
            int b = 2;
            Swap<int>(ref a, ref b);
            System.Console.WriteLine("{0}, {1}", a, b);
        }

        static void SwapTest2()
        {
            string a = "aaa";
            string b = "bbb";
            Swap<string>(ref a, ref b);
            System.Console.WriteLine("{0}, {1}", a, b);
        }

        static void Main(string[] args)
        {//     **일반화 자료형이 2개면 ,를 이용해 2개를 적어준다**
         //            원하는 자료형   각 자료형에 맞는
         // 메서드명 < 일반화 키워드 >(일반화    변수값);
            calculate<int,      float>(10, 20, 3.1f, 4.2f);
            calculate<string, decimal>("10", "20", 30.57m, 74.22m);

            SwapTest1();
            SwapTest2();
        }
    }
}