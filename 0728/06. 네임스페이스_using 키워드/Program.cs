using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//사용자 정의
using Tokyo;
using Tokyo.Tosima; // 각 영역별로 namespace 이름을 넣어준다.

namespace Tokyo
{
    class tokyoTower
    {
        public void print()
        {
            Console.WriteLine("도쿄타워입니다.");
        }
    }

    namespace Tosima
    {
        class sunShine
        {
            public void print()
            {
                Console.WriteLine("선샤인 60");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {/* 아래 공식을 더 쉽게 하고 싶다면?)
      * using 키워드 : namespace를 미리 등록시켜 사용할 때 자동으로 내부의 데이터(클래스)를 접근할 수 있게 한다.
      *                해당 namespace 영역에 있는 다양한 클래스나 메서드나 자료형을 사용 가능하게 만들어준다.
      *                
      *       사용법 : using namespace이름; // using 다음엔 namespace만 올 수 있다.(클래스가 오는 자리가 아니다)
      *                                            프로그램 시작 전에 먼저 선언해야만 한다.
      *                                            내가 선언한 namespace 내의 영역(클래스나 메서드들)만 이용 가능
      *                                            namespace 내부의 namespace는 안 보여준다(직접 불러야만 함)
      */
        Tokyo.tokyoTower tower = new Tokyo.tokyoTower();
        Tokyo.Tosima.sunShine sS = new Tokyo.Tosima.sunShine(); // using 키워드 없이 namespace를 호출하는 방법

        tokyoTower tower2 = new tokyoTower();                   // using 키워드로 namespace를 호출하는 방법
        sunShine sS2 = new sunShine();

        tower.print();
        sS.print();

        System.Console.WriteLine("");
    }
}