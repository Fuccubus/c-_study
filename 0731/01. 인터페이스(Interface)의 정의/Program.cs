
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 인터페이스(Interface)란? : 상속관계가 없는 클래스에게 기능(형태)를 제공함.(부모 클래스처럼)
 * 
 *                            => 인터페이스가 메서드나 멤버 변수들을 정의하고,
 *                               그것을 차용하는 클래스가 구현을 담당함.
 *                               
 *                            => 클래스와 비슷한 구조이며, 해당 인터페이스의 멤버로는
 *                               메서드, 이벤트, 인덱서, 프로퍼티만을 받을 수 있음.
 *                               
 *                            => 인터페이스를 차용한 클래스는 구현할 때,
 *                               멤버들의 접근권한을 public으로 부여해야 한다.
 *                         
 *           정의할 땐... )
 *           interface 이름
 *           {
 *            메서드 프로토타입();
 *           }
 *           
 *           
 *           
 *           사용할 땐...)
 *           class 클래스명 : 인터페이스 이름 // 자식클래스 : 부모클래스 와 비슷
 *           { 로직부...
 *           
 *             차용한 인터페이스에 정의된 메서드를 구현
 *             (접근권한은 public으로 부여)
 *           }
 */
interface A
{
    void say();            // 메서드
    int prop { get; set; } // 속성
}

class X : A
{
    public int b;
    public void say()
    {
        Console.WriteLine("인터페이스 내용을 구현");
    }
    public int prop
    {
        get { return b; }
        set { b = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        X x = new X();
        x.say();
        x.prop = 52;
        Console.WriteLine(x.prop);
    }
}