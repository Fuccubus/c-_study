using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.구조체_struct__ex_258_259p
{  /* 언어별 구조체의 차이)
    *    c, c++ = 자료형만 가능
    *    c#, java = 자료형, 메서드도 가능(즉, 생성자도 가능)
    */
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z) // return 타입이 없는 메서드 = 생성자
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", X, Y, Z);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1; // new 문이 안 들어간 것은 간접접근을 의미
            p3d1.X = 10;  // 바로 만들었단 뜻으로, 이는 생성자를 이용하지 않는다는 뜻
            p3d1.Y = 20;  // 쓰레기 값으로 가득참
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300); // Point3D 만큼 크기의 저장공간을 부여
            Point3D p3d3 = p3d2;                       // p3d2의 값을 대입하는 동시에 별도의 저장공간을 부여
            p3d3.Z = 400;                              // 만약 class에서 위와 같이 했다면 동일한 저장공간을 공유
                                                       // class => 간접접근만 가능.
                                                       // struct => 직접, 간접접근 가능.
                                                       //           쉽게 구분하는 방법으론, new 문 없이 선언해서 사용하는 것은 struct.
                                                       //           만약 new 문을 선언해서 사용한다면 class 일수도 있고, struct 일수도 있다.

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}
/* 함수 overloading(중복정의) => 메서드가 같은 이름의 여러개 => 원본 메서드는 보존
 * override 연산자 => 기존의 => 기존의 기능을 새롭게 재정의 => 기능추가 
 */