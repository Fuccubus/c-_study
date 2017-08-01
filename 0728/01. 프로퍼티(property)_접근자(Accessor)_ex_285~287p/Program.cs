using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.프로퍼티_property__접근자_Accessor__ex_285_287p
{
    /*
     * 멤버 변수처럼 보이지만 실제론 메서드의 동작이다.
     * get, set => 접근자로 로직을 작성.
     * 메서드 타입으로 동작하기 때문에, static과 추상화 키워드 사용 불가.
     * 내부적으로 메모리를 추가 할당하지 않는다.
     * 
     */

    /* 형식)
     * 권한    자료형  이름 // 가급적이면 public으로 설정(어디든지 접근하기 쉽게)
     * public   int    m_a 
     * { //블럭을 열었다는 건 => 메서드를 의미
     *      
     *      get // => 값을 얻는다 => 값을 넘겨준다
     *      {   // 메서드를 의미
     *          반드시 return 값이 필요
     *      }
     *      
     *      set // => 값을 세팅 => 프로퍼티(property)를 통해 얻은 값을 대입한다
     *      {   // 메서드를 의미
     *          값을 넣을 변수 => 프로퍼티 이름;
     *                           (해당 로직으로 얻은 세팅 값)
     *      }
     * }
     */
    class AA
    {
        private int _m_a; // 멤버 변수
      
        public   int    m_a    // get, set 기능을 쓸, 변수처럼 보이는 메서드
        {                      // 변수(처럼 보이는) 이름 => 메서드 이름

            get                
            {
                return _m_a;
            }

            set
            {
                _m_a = m_a;
            }
        }
    }
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
