using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
namespace _프로퍼티와_생성자_예제
{
    class AA
    {
        public int m_a { get; set; }
        public string m_b { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA() { m_a = 486, m_b = "비밀번호" };
            // 생성자(멤버변수 세팅) {내부인자(프로퍼티 세팅}
            Console.WriteLine(aa.m_b + " " + aa.m_a);
        }
    }
}
*/

namespace _03.프로퍼티와_생성자_Constructor_with_Property__ex_292_293p
{
    class BirthdayInfo
    {
        public string Name      // 프로퍼티1
        {
            get;
            set;
        }

        public DateTime Birthday// 프로퍼티2
        {
            get;
            set;
        }

        public int Age          // 프로퍼티3
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {// 여기서부터...
        static void Main(string[] args)
        {// 클래스명  인스턴스 = new 클래스명()
            BirthdayInfo birth = new BirthdayInfo()

            { // 리턴 타입이 없다 = 생성자
                Name = "서현",                         // 프로퍼티 1
                Birthday = new DateTime(1991, 6, 28)   // 프로퍼티 2
                                                       // 프로퍼티 3이 생략되었다.
                                                       // 이처럼 생성자 내에 꼭 모든 프로퍼티들이 들어갈 필요 없다.
            };

            // 여기까지 본 솔루션 01번 프로젝트와 비교 분석할 것

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}