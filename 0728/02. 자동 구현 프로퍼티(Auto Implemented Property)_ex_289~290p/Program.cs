using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.자동_구현_프로퍼티_Auto_Implemented_Property__ex_289_290p
{
    class BirthdayInfo
    {// 여기서부터...
        public string Name
        {
            get; // 짜놓을 로직이 간단한 변수 대입 정도로 단순할 경우,
                 // {}블럭을 열지 않고 세미콜론;만으로 간단하게 생략할 수 있다.
                 // return할 변수도, 세팅할 변수도 모두 내부적으로 생성, 자동으로 사용한다.
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            } // 여기까지 본 솔루션 01번 프로젝트와 비교 분석할 것
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
