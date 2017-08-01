using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.this_키워드_ex_219_220p
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine("{0} {1}", pooh.GetName(), pooh.GetPosition());

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine("{0} {1}", tigger.GetName(), tigger.GetPosition());
        }
    }
}
/*
 * this 키워드 : 현재 활성화된 나의 클래스..
 * 
 * class Employee
 * {
 *      string a; <-- 클래스 내의 멤버변수
 *      void SetData(string a) <-- 내 클래스 내의 함수에서 사용할 파라미터 변수(임시 자료형)
 *                                 호출하면 생성되고, 함수가 끝나면 파기
 *                                 클래스 영역, 내부의 함수 영역 => 만들어지는 영역이 다르다
 *                                 때문에 이름이 같아도 문제 없으나, 모호성이 발생하기 마련                                 
 *      {
 *          a = a;  <------------- 이렇게 무엇이 멤버인지 파라미터인지 모를 때가 바로 모호성 발생
 *                                 위의 문제는 this 키워드를 이용하면...
 *          this.a = a;            this 는 현재 활성화된 나의 클래스내 멤버변수인 a
 *                                 = 뒤의 a는 SetData 메서드 내 파라미터 a를 의미한다 *          
 *      }
 * }
 * 
 *    @ 변수를 읽는 우선순위는 = 마지막에 만들어진 블록 내 변수 > 먼저 만들어진 블록 내 변수 순으로 읽는다.
 *                               스택(stack)의 원리와 동일하다.