using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._03의_자료형_변환_보강_및_operator_종류
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
//오칙연산 = (+,-,*,/,%) 더하기, 빼기, 곱하기, 나누기, 나머지
/*
int num = 32767;            
int val = num;

// 7
int result = val % 10; // 32767
Console.WriteLine(result);

// 6
val = val / 10; // 3276
result = val % 10;
Console.WriteLine(result);

// 7
val = val / 10; // 327
result = val % 10;
Console.WriteLine(result);

// 2
val = val / 10; // 32
result = val % 10;
Console.WriteLine(result);

// 3  => 각각의 자릿수를 출력할 것
val = val / 10; // 3
result = val % 10;
Console.WriteLine(result);

//대입     = int num = 333;

//증감     =
int hp = 50;
Console.WriteLine(hp++);
/*
++hp;
Console.WriteLine(hp);
hp--;
Console.WriteLine(hp);
--hp;
Console.WriteLine(hp);

hp += 10; => hp + 10 이란 뜻
hp /= 10; => hp / 10(0으로 나누어도 안되고, 값이 0인 상태가 안되도록)

*/
//비교     => 결과를 0, 1로 나눈다 = true / false
//            > 크다, < 작다, >= 이상, <= 이하, != 다르다, == 같다
// int age = 13; (age > 10), if(1) 혹은 if(0) => 1은 참, 0은 거짓

//논리     = and,         or,          not
//           &&(논리곱)   ||(논리합)   !(논리부정)  값(참 거짓의 관계)의 논리를 체크한다.
//           &            |            =>           메모리(비트)의 논리를 체크한다.
//          교집합      합집합       여집합
//        공통(그리고)   또는        아니다
//   통으로 만족할 때만             현재부정
//   Exception)
//   (a>10) && (a<50)   a = 34       a = 9
//   (a==1) || (a==100) a = 1        a = 33
//  !(a==100)           a = 33
//  cf)
//  a = 3;
//  ((a==5) || (a=7))  (할당)  => 할당식은 참으로 간주

/*
        int a = 3, b = 4;
        bool x, y; // 참, 거짓 체크
        x = (a < 0);
        y = (b > 0);

        Console.WriteLine((a == 3) && (b == 3)); // && : 공통으로 조건이 만족되지 않아 '거짓'
        Console.WriteLine(x || y); // || : 하나라도 조건이 만족되어 '참'
        Console.WriteLine(x);      // a는 0보다 크므로 '거짓'

        Console.WriteLine(2 * 8 - 6 / 2);
        Console.WriteLine(2 * (8 - 6) / 2);
        Console.WriteLine(1 - 2 + 3);
        Console.WriteLine(1 - (2 + 3));

        //형변환 cast 연산자 : 변수 앞에 ()를 넣고, 자료형(int, float, double 등등)을 넣으면 강제로 형변환이 일어남
        Console.WriteLine((float)(3 / 2));
        Console.WriteLine(3 / (float)2);
        Console.WriteLine((float)3 / (float)2);
        Console.WriteLine((float)3 / 2);
        */

/*
       //삼항 연산자..
       //조건식의 값에 따라 계산식을 선택함.
       //비슷한 문법적인 구조 : if - else
       //차이점       : 각 조건 별로 로직라인 1줄짜리로 제약한다.
       //형식         : 값     ?      로직1     :     로직2;
       //(조건식)     : 값     ?      세팅1     :     세팅2;
       //        0,1 값 => 값을 비교해서, 참(1)일 때엔 로직1 수행
       //                               거짓(0)일 때엔 로직2 수행


       string right = "정답";
       string wrong = "오답";
       bool value;

       value = true;
       //              value가 '참'이므로 로직1 : 로직2 중 로직1을 수행
       string answer = value ? right : wrong;
       Console.WriteLine("값은 " + answer);

       value = false;
       //              value가 '거짓'이므로 로직1 : 로직2 중 로직2을 수행
       answer = value ? right : wrong;
       Console.WriteLine("값은 " + answer);

       string answer2;
       value = true;
       answer2 = (value) ? "aaa" : "bbbb";
       */