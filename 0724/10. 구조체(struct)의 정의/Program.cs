using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.구조체_struct_의_정의
{
    /*
     * 구조체(struct)란 사용자 정의 자료형
     * 형식..
     * struct 구조체 이름
     * {
     *      멤버 데이터
     * }
     */
    //사용
    //자료형 이름  변수

    struct Hero
    {   // 구조체 내부

        public int hp, mp; // 내부를 접근할 때 보호 수준이 있다..(접근권한)
                           // 접근권한의 종류는 public, protected, private가 있다.
        public void init_data() // c# 기능도 넣을 수 있다(메서드)
        {
            hp = 300;
            mp = 300;
        } // 선언부인 경우엔 저장공간이 없음

        public void print()
        {
            Console.WriteLine("aaa{0}, bbb{1}", hp, mp);
        }
    }
    class Program // 구조체 외부
    {
        static void Main(string[] args)
        {   //직접접근 => 변수처럼 직접 가져다 씀
            Hero IronMan; // 1) 자료형 선언
                          // 2) 멤버를 직접 접근 -> 값 세팅(일반변수처럼 사용)
                          // IronMan.init_data(); // 내부 메서드, 내부의 데이터를 변경
            IronMan.hp = 100;
            IronMan.mp = 100;

            Console.WriteLine("aaa{0}, bbb{1}", IronMan.hp, IronMan.mp);

            // 내부에 있는 메서드를 쓰고 싶은 구조체
            // 간접접근(저장공간을 만들고, 해당 주소를 받음)
            Hero SpiderMan = new Hero(); // c언어식 의미 = Hero *SpiderMan = Malloc(sizeof(Hero));
            SpiderMan.init_data();
            SpiderMan.print();
        }
    }
}