using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 가상 메서드 또는 오버라이딩란?)
 *      기반 클래스의 메서드를 파생 클래스에서 변형(재정의)해서 사용하기 위한 방법
 *      
 * 형식
 *      1) 부모 클래스
 *         메서드에 virtual 키워드를 넣는다
 *         권한     virtual     리턴타입     메서드명(파라미터)
 *         {
 *             내부 로직 구현
 *         }
 *         
 *         현재 클래스는 그대로 사용
 *         파생 클래스는 재정의해서 사용
 *         
 *      2) 자식 클래스
 *         메서드에 override 키워드를 넣는다.
 *         권한     override     리턴타입     메서드명(파라미터)
 *         {
 *             내부 로직 구현
 *         }
 *         
 * virtual 키워드란?)
 *      현재 구현이 안된 것을 파생 클래스로 구현하게 만들어준다.
 *      부모클래스는 정의만 내린다(예측)
 *      
 * 가상 메서드 virtual의 특징
 *         자식 클래스가 부모 클래스에게 재정의하는 것을 요청함
 *         단, 부모 클래스의 메서드 권한이 private 라면 재정의가 불가능
 *         부모 자식 클래스의 문법 구조가 같아야만 한다. // 예)부모 : protected virtual => 자식 : protected override)
 *         부모 클래스의 메서드가 정적변수(static)이라면 사용이 불가능
 *         부모 클래스에서 정의한 것을 자식 클래스에서 재정의한다. => virtual이 있어야만 override가 성립된다.
 *              예) virtual만 있으면? => 자식 클래스에 override가 되어 있다면 재정의된 메서드 실행
 *                                    => 만약 없다면 => virtual로 된 메서드를 실행
 */

namespace _10.오버라이딩_Overriding_과_다형성_Polymorphism__ex_241_242p
{
    class Parent
    {
        public virtual void ShowData()
        {
            Console.WriteLine("부모의 기능");
        }
    }

    class Child : Parent
    {
        public void SetData()
        {
            Console.WriteLine("-----");
        }

        public override void ShowData()
        {
            Console.WriteLine("개선된 자식의 기능");
        }
    }

    class Child2 : Child
    {
        public override void SetData() //에러가 난 이유는?)
                                       //       부모인 Child 클래스 내 SetData() 메서드에 virtual이 없기 때문에..
        {
            Console.WriteLine("에러 발생");
        }
    }

    class ArmorSuit
    {// 권한   virtual   리턴타입   메서드명()
        public virtual     void   Initialize()
        {
            Console.WriteLine("Armored");       // 부모 클래스 내 Initialize() 메서드 내 로직
        }
    }

    class IronMan : ArmorSuit
    {// 권한   override   리턴타입   메서드명()
        public override     void   Initialize()
        {
            base.Initialize();                  // base.메서드명(); => 기반 클래스 내 Initialize() 메서드 호출
                                                //                     여기서 base는 현재 클래스의 기반 클래스에 해당하는 클래스를 가리킨다.
                                                //                     마치 this 키워드가 자기 자신의 클래스를 가리키는 것처럼..
            Console.WriteLine("Repulsor Rays Armed"); //               기반 클래스 내 Initialize() 메서드 재정의함
        }
    }

    class WarMachine : ArmorSuit
    {// 권한   override   리턴타입   메서드명()
        public override     void   Initialize()
        {
            base.Initialize();                               //        기반 클래스 내 Initialize() 메서드 호출

            Console.WriteLine("Double-Barrel Cannons Armed");//        기반 클래스 내 Initialize() 메서드 재정의함
            Console.WriteLine("Micro-Rocket Launcher Armed");//        기반 클래스 내 Initialize() 메서드 재정의함
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.ShowData();

            Child c = new Child();
            c.SetData();
            c.ShowData();
            Console.WriteLine("\n");


            Console.WriteLine("Creating ArmorSuit...\n========================");
            ArmorSuit amrSuit = new ArmorSuit();
            amrSuit.Initialize();
            Console.WriteLine();

            Console.WriteLine("\nCreating Iron Man...\n========================");
            ArmorSuit irnMan = new IronMan();
            irnMan.Initialize();
            Console.WriteLine();

            Console.WriteLine("\nCreating War Machine...\n========================");
            ArmorSuit warMcn = new WarMachine();
            warMcn.Initialize();
            Console.WriteLine();
        }
    }
}
