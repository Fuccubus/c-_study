using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.class_ex1
{
    /*
     * 객체 = 데이터, 메서드
     * 형식
     * class 객체명
     * {
     *     정보(자료형) 선언 //멤버 변수
     *     
     *     기능(메서드) 선언 //멤버 메서드
     * }
     */
    class Hero  //클래스를 만든 것(자료형 선언)
    {
        //권한 세팅 사용법)
        //권한 
        public int lv;
        public int hp;
        public int mp;
        public bool alive;
        public void now_Dead()
        {
            hp = 0;
            mp = 0;
            alive = false;
        }
        public void now_lvlUp()
        {
            lv += 1;
            hp += 10;
            mp += 5;
            alive = true;
        }
        public void initial()
        {
            lv = 1;
            hp = mp = 10;
            alive = true;
        }
        public void show_State()
        {
            Console.WriteLine("lv : " + lv);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("mp : " + mp);
            Console.WriteLine("state 1 : live, 0 : dead -> " + alive);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 내부의 데이터를 사용할 땐 먼저 .연산자를 사용한다.
            // 변수.내부정보

            // 멤버 에러 발생) 클래스 영역을 벗어난 상태에서 내부 정보를 사용할 땐 먼저 상황에 맞는 권한을 설정해야 한다.
            // 권한 종류) public, protected, private

            // 객체 에러 발생) 객체의 선언과 사용은 변수의 형태와는 다르다.
            // 변수             : 크기와 형태가 정해졌음.
            //                    선언과 동시에 바로 사용할 메모리가 만들어지고 바로 사용 가능.
            //                    직접 접근 방식 => 객체정보를 직접.
            // 반면 클래스 변수 : 크기와 형태가 제각각(사용자 정의), 별도로 메모리를 할당을 해야 한다.
            //                    객체 메모리를 얻고 주소 기준으로 접근.
            //                    간접 접근 방식 => 주소로 접근.
            //                                      주소 자료형을 숨겨놓았기 때문에 겉으로 보면 직접 접근처럼 보인다.
            //                    메모리 할당 키워드 = new -> 해당 자료형 크기만큼 할당.
            //                                         new 자료형() => 이것과 비슷한 뉘앙스는 malloc(sizeof(자료형));
            //                    메모리 반환 키워드 = new <-> delete                         malloc <-> free
            //                                         new는 메모리 반환을 위해 delete 구문을 쓸 필요가 없음(c#, java는 메모리 관리를 알아서 하므로)
            //                                         이를 두고 가비지 콜렉션이라 부른다.

            Hero Linx = new Hero();

            Linx.hp = 20;
            Linx.show_State();
            Linx.initial();
            Linx.now_lvlUp();
            Linx.show_State();
            Linx.now_lvlUp();
            Linx.show_State();
            Linx.now_Dead();
            Linx.show_State();
        }
    }
}