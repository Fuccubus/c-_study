using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.method_ex_191_192p_명명된_매개변수_
{
    class MainApp
    {   // 명명된 매개 변수(Named Parameter)
        public static void PrintProfile(string name, string phone)
        {
            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-567-5678");
        }
    }
}