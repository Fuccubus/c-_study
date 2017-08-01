using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.method_ex_194p_선택적_매개변수_
{
    class MainApp
    {   //선택적 매개변수(Optional Parameter)
        public static void PrintProfile(string name, string phone = "") // string phone 과 같이 선언과 동시에 값을 넣고 초기화하면 기본 값을 부여할 수 있다.
        {
            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile("태연"); // 변수는 무조건 순차적으로 값을 부여한다. name > phone 순으로 기입되기 때문.
            PrintProfile("윤아", "010-123-1234");
            PrintProfile(name: "유리"); // "유리"는 name에 기입되므로, 입력하지 않은 phone은 미리 정해놓았던 기본 값인 ""이 출력된다.
            PrintProfile(name: "서현", phone: "010-789-7890");
        }
    }
}