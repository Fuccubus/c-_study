using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 생성자(Constructor)와 소멸자(Destructor

class A
{
    public int m_a;
    // 생성자를 안 만들었으므로 시스템이 자동으로 생성한 뒤 0으로 세팅해서 초기화시킴

    // 소멸자란) 객체가 파괴될 때 호출되는 메서드(자동으로)
    //     형태) ~클래스명() => 중복정의 불필요(파괴상황), 리턴타입 불필요
    ~A()
    {
        //객체의 파괴 시 처리할 루틴 => m_a = 0;
        Console.WriteLine("파괴됨");
    }
        //실제로 소멸자를 세팅하거나 코딩하는 경우는 별로 없음(자동으로 생성되므로)
        // 클래스 외부에선 호출여부(X)
}

namespace _05.class_생성자와_소멸자
{        
    class Program
    {
        static void Main(string[] args)
        {
            A ab = new A();
            Console.Write("111");
            Console.WriteLine("222");
        }
    }
}

    /*
    * 객체 생성 -> 메모리 공간 할당.
    * 
    * c언어 : malloc(크기) => 메모리 공간은 할당되지만 내부에는 쓰레기 값으로 가득참.
    * 
    * 생성자란?) 객체의 생성 이후에 내부의데이터를 초기화를 하기 위해 호출되는 메서드.
    *            자동 혹은 수동으로 호출됨(객체를 만들 때에만).
    *            객체가 만들어진 이후엔 생성자는 호출이 안된다.
    *            생성자 => 초기화 메서드
    *      형식) 메서드명 클래스명 (파라미터)
    *            리턴타입(x)
    *  특징요약) 1. 겉보기엔 class와 동일하지만
    *            2. 리턴타입의 유무로 구분이 가능하다
    *            3. 생성자를 아예 안 만들 경우 자동으로 값에 0을 부여하고 초기화
    */

    /*
    class A
    {
        public int m_a;
      //권한타입  클래스명 파라미터
        public        A       ()   //메서드인데 리턴타입이 없는 것이 생성자
      
      //생성과 초기화는 > 클래스 외부 > _외부에서 접근 가능하도록 권한을 public
        {
            m_a = 1;
        }
        public A(int setData)
        {
            m_a = setData;
        }
        public void showData()
        {
            Console.WriteLine("m_a " + m_a);
        }
    }
    */

    /*
            A ma;         // 객체의 생성이 아닌 => 객체를 받기 위한 변수(주소를 받는 변수)
            ma = new A(); // 객체의 공간을 만들고 초기화하는 부분 : -new- 구문
                          // 이후엔 생성자는 호출 안됨

                          // 생성자 사용방법) new 클래스명(파라미터) => 메모리 할당 + 생성자 호출 코드
            ma.showData();
                          // 클래스명() 생성자를 아예 안 만들었을 경우 => 시스템이 자동으로 생성자를 생성함
                          //                                              값에 자동으로 0을 부여하고 초기화
                          //                                              만약 단 1개라도 있으면, 객체를 만들 때 해당 생성자를 써야함
                          //                            기본 클래스(); => 파라미터가 없는 생성자는 스스로 다시 만들어야 사용할 수 있다.
            A ma_1 = new A(486);
            ma_1.showData();
            */