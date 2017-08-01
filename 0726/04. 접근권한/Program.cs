using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyClass
{
    int m_a; // 앞에 접근권한을 기입 안 하면 자동으로 private 속성 부여
    private int m_b;
    public int m_c;
    public int m_d;

    // c#은 객체의 접근권한의 설정은 해당 멤버에만 적용됨.
    //   ex) public int a;
    //              int b; <= c#에서 앞 멤버에 public을 쓰고 이후 멤버들은 생략하면?
    //                        직접 설정했던 앞 멤버만 public 속성이 적용, 이후 멤버들은( 적용X), 자동으로 private로 설정된다

    // c# 외에는 해당 접근권한은 세팅 이후의 모든 객체에 앞에 세팅된 권한을 따른다.
    //   ex) public int a;
    //              int b; <= c# 외 앞 멤버에 public을 쓰고 이후 멤버들은 생략하면?
    //                        앞 멤버에서 적용한 public 속성이 이후 멤버들까지 적용(O)
}

class Program
{
    static void Main()
    {
        MyClass aa = new MyClass();
        aa.m_c = 33;
        aa.m_d = 66;
        /* System.String.Format에 대한 맛보기
        System.Console.WriteLine("aaa");
        string temp;
        temp = System.String.Format("문자 {0}데이터를 결합", 123);

        Console.WriteLine(temp);
        */

        Object a = 3.14;
        int b = 123;

        int c = b;          // 데이터와 더불어 형태가 정해진 자료형(그냥 할당이 가능)
     // float d = a;        // a 변수는 값만 들어가 있음 => 자료형의 종류는 세팅이 안되어 있음
                            // 변수의 값을 넣는다 (박싱, 언박싱)
                            // 데이터 세팅과 자료형 타입 알려줌
        float d = (float)a; // 올바른 표기법

        Console.Write("값은 {0}     {1}", c, d);
    }
}

