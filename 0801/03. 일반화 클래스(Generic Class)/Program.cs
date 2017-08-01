using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.일반화_클래스_Generic_Class_
{/* 일반화 클래스란?) 클래스 선언 시, 내부의 멤버 자료형 중
  *                   필요에 따라 일반화(T) 자료형으로 만들어진 클래스.
  *                   
  *                   자료형의 구체적인 형태는 객체 생성 시에 지정함.
  *                   클래스 내부에 보통의 자료형과 일반화 자료형이 공존 가능.
  *                   
  *             형식) class 클래스명 <T>
  *                   {
  *                        T멤버 생성
  *                   }
  */
    class A
    {
        public int m_x;
        public int m_y;
    }

class A <G, S> // 일반화 클래스 =  일반화 자료형이 G, S 두 개가 있다.
    {
     // public float m_z; // 보통의 멤버변수
        public G g_x;     // 일반화된 멤버변수
        public G g_y;
        public S s_x;
        public S s_y;        
    }
    /*                   **일반화 자료형이 2개면 ,를 이용해 2개를 적어준다**
     *                    원하는 자료형                       원하는 자료형
     * 사용방법) 클래스형<일반화 키워드> 변수명 = new 생성자 <일반화 키워드>();
     */

class connector<T>
    {
        public string connect(T a, T b)
        {
            return a.ToString() + b.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A<int, float> a = new A<int, float>(); // 일반화 자료형이 G, S 두 개이므로 두 개의 자료형을 기입함
            a.g_x = 1;
            a.s_y = 3.14f;

            connector<int> c = new connector<int>();
            Console.WriteLine(c.connect(123, 486));
        }
    }
}
