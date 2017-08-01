using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
     * 네임스페이스란?)
     *      다중작업을 통해 프로젝트 구성 시, 클래스(메서드)의 중복이 생길 수 있다.
     *      해당 클래스를 구분지을 수 있는 영역을 만들어 클래스를 제작할 시
     *      중복이나 모호성을 해소할 수 있다.(같은 이름의 클래스가 있어도 충돌이 안 나게)
     * 형식) 선언..
     *      namespace 영역이름
     *      {
     *          클래스들을 구현
     *      }
     * 
     * 사용방법)
     *      영역이름.클래스명 변수명 = new 영역이름.클래스명();
     *      namespace를 이용한 객체는 해당 namespace(영역이름)을 명시해야 한다.
     *      네임스페이스 내에 정의된 클래스를 참조할 때는 .연산자를 이용한다.
     *      서로 다른 namespace 1: 1
*/

namespace AA //
{
    class CardData
    {
        public int m_a;
    }
}

namespace BB
{
    class CardData
    {
        public int m_a;
    }
}

/*
     * namespace 내에 namespace가 들어갈 수 있다
     * 즉, 중첩해서 사용 가능
     * 
     * 사용방법)
     *      영역이름.영역이름.클래스명 변수명 = new 영역이름.영역이름.클래스명();
*/

namespace CC
{
    class CardData
    {
        public int m_a;
    }
    namespace DD
    {
        class CardData
        {
            public int m_a;
        }
    }
}

namespace _04.네임스페이스_namespace_의_정의
{   
    class Program
    {
        static void Main(string[] args)
        {//영역이름.클래스명 변수명 = new 영역이름.클래스명();
            AA     .CardData    a   = new    AA   .CardData();
            BB     .CardData    b   = new    BB   .CardData();
            CC     .CardData    c   = new    CC   .CardData();
         //영역이름.영역이름.클래스명 변수명 = new 영역이름.영역이름.클래스명();
            CC     .DD      .CardData    d   = new    CC   .DD      .CardData();

            b.m_a = 1;
            c.m_a = 2;
            d.m_a = 3;

            // 사용은 기존과 동일하게
            Console.WriteLine("{0}, {1}, {2}, {3}", a.m_a, b.m_a, c.m_a, d.m_a);


        }
    }
}
