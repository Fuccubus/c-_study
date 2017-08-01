using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.class_접근권한
{
    class Temp
    {
        /* 교재 224p ~ 225p 참조
         * 접근권한) 클래스 내부에서 모든 데이터의 접근이 가능하다.
         *           반면 클래스 외부에선?
         *           만약 현재 클래스를 기준으로 기능을 추가했다면
         *           기능 추가한 클래스는 기반 클래스의 자료형을 쓸 수 있는가?
         * 접근권한 종류)     public,     private,     protected
         *               외부   O            X             X
         *               내부   O            O             O
         * 
         */
        public int a;
        private int b;
        protected int c;
        int d;           // 접근권한을 부여하지 않으면 자동으로 private 속성을 부여한다.
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
        /* OOP(객체지향 프로그래밍) 특징 : 캡슐화(Encapsulation)      : 데이터와 메서드(함수)를 하나의 단위로 묶는 것(독립적으로 실행)
         * 
         *                                 상속(Inheritance)          : 기존의 클래스를 바탕으로 새로운 클래스를 만들 수 있음
         *                                   
         *                                 다형성(Polymorphism)       : 같은 메서드에 대해 클래스에 따라 다르게 동작하게 만드는 특징
         *                                 
         *                                 정보 은폐(Information Hiding) : 객체의 상태를 외부의 허가되지 않은 동작으로부터 보호
         */