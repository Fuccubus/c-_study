using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.기초와_Console.Write문__Console.WriteLine문
{
    class Program
    {/* c언어와 c#의 특징)               c언어                  c#
      *                               절차지향언어    |    객체지향언어
      *   반드시 정의부와 연산부가 구분되어야 한다    |    필요에 따라 언제든지 데이터를 정의할 수 있다
      *                         정의 > 연산.메소드    |    연산 > 정의 or 정의 > 연산 = 마음대로
      */


        static void Main(string[] args)
        {/* 자주 쓸 단축키) 1. 컴파일은 ctrl+shift+b
          *                 2. build AND run은 ctrl + f5
          * 
          * 화면에 문자열 및 데이터 출력을 할 땐?)
          * 
          *  c언어            java                    c#
          * printf()   System.Out.printIn()   System.Console.Write()
          *                                   System.Console.WriteLine()
          *                                     └----> 맨 위에 using 키워드로 System(namespace)을
          *                                             미리 호출해 놓았으므로 생략해도 된다.
          */
          
            Console.Write("윤하 "); //""이 있으면 문자열을 출력
            Console.WriteLine(123); //""이 없으면 숫자를 출력

            Console.WriteLine("비밀번호 486");
         /*
          * Console.Write와 WriteLine의 차이점)
          *         Write는 ()의 내용을 출력한 다음 라인을 넘기지 않고,
          *         WriteLine은 ()의 내용을 출력한 다음 라인을 넘긴다.(마치 엔터키를 치듯이)
          *         ()안에 문자열 출력을 위한 "" 안에다 \n를 기입하면 라인을 넘긴다.
          *         
          *                             코드                        출력
          *                 ex) Console.Write("윤\n\n하"); ===> 윤
          *                 
          *                                                     하
          */


          //데이터와 문자열을 동시에 출력하는 방법
            Console.WriteLine("가나다라" + 12345);
            Console.WriteLine("abce {0} {1} {2}", 98765, "defg", 13579);
            Console.WriteLine("abce " + 98765 + " defg " + 13579);
            Console.WriteLine("펜" + "파인애플" + "애플" + "팬");
            
            int num = 333;
            Console.WriteLine(num);

            // char  은 한 글자만
            // string은 문장을 선언할 수 있다.

            char a = 'a';  //unicode //nbyte //cf c  utf-8 => 1byte
            char b = '가';
            char c = '飛';
            string strData = "안녕하세요 ^^";

            Console.WriteLine(a + "  " + b + "  " + c);
            Console.WriteLine(strData);

            strData = "123";
            Console.WriteLine(strData);
        }
    }
}