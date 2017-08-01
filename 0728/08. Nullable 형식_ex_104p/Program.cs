using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Nullable_형식_ex_104p
{
    class MainApp
    {
        static void Main(string[] args)
        {   // int, float, doulbe 등의 자료형의 변수들은 선언되면 강제로 값을 집어넣는다.
            //                         심지어 사용자가 안 집어넣으면 쓰레기 값이라도 채워버린다.
            //                         단, 변수 선언할 때 앞에 ?를 붙이면 변수 안에 null값(0이 아닌)을 채울 수 있다.
            int? a = null;

            Console.WriteLine(a.HasValue); // .HasValue = 해당 변수 안에 값의 유무를 참, 거짓(true, false)로 체크해준다
                                           // bool 함수와 비슷함
            Console.WriteLine(a != null);  // a 가 null 이 아니라면 이라는 뜻

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);    // .Value = 해당 변수 안의 값을 가리킨다.

            Console.WriteLine("\n==============");

            int? b = null;
            Console.WriteLine(b);

            if(b.HasValue == false)
            {
                Console.WriteLine("값을 세팅해야 함");
                b = 123;
            }

            if(b.HasValue == true)
            {
                Console.WriteLine(b.Value); // (문법적으로 보다 정확하게)내부의 값 출력
                Console.WriteLine(b);       // 내부의 값 출력
            }
        }
    }
}
