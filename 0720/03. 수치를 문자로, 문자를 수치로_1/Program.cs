using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.수치를_문자로__문자를_수치로_1
{
    class Program
    {
        static void Main(string[] args)
        {
        // 문자를 숫자 데이터로 바꾸기

        // 방법1-1) .Parse 연산자 이용하기

        //    ⑴ 변수 A 선언(문자 데이터)
              string A = "123"; // string은 오직 문자열만 기입할 수 있으므로,
                                    // strData 내 들어있는 값 123은 수치가 아닌 문자열이다.

        //    ⑵ 변수 B 선언(문자 데이터를 숫자로 받을 데이터)
              int B;

        //    ⑶ 아래 기술된 형식대로 코드 작성)

        //    문자를 숫자로 받을 변수 B = 변수B의 자료형.Parse ( 문자가 들어간 변수 A );
                            B           =        int    .Parse (A); // .Parse는 ()안에 기입한 변수의 값이 바꿀 수 있는 형태(숫자)인지 체크한 후 치환해준다.
              Console.WriteLine(B);

        // 방법1-2) 선언과 동시에 초기화

        //    ⑴ 

            A = "3.14";
            float C = float.Parse(A);
            Console.WriteLine(C);

            string forChange = "89.5";
            double toDouble = Convert.ToDouble(forChange);

            Console.WriteLine(toDouble);


        // 수치 데이터를 문자로 바꾸기

            float result = 123.456f; //실수 
                                     //방법 1)                                    
            string strD = result.ToString();
            Console.WriteLine(strD);

            //방법 2)
            // ""은 문자열이지만 데이터는 없음 => 빈 문자열 => Null 문자열
            string strD2 = "" + result; // c#언어는 "문자열"과 숫자 데이터를 합하면 자동으로 숫자 데이터까지 전부 문자열로 처리함.
            Console.WriteLine(strD2); // 솔루션 0720 내 HelloWorld 프로젝트 참조

            // 자료형의 변환

            // 방법 1
            string num = "3.14";
            float dat = float.Parse(num);
            Console.WriteLine(dat);

            // 방법 2
            double dat2 = Convert.ToDouble(num);
            Console.WriteLine(dat2);
            Console.WriteLine((float)dat2);

            // 방법 3
            int a = 33;
            double rest = Convert.ToDouble(a);

            Console.WriteLine(rest);
        }
    }
}