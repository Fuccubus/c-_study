using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.상속_Inheritance_
{
    // 상속이란?) 특정 클래스(부모)를 기반으로 기능이 확장된 새로운 클래스(자식)를 생성하는 것
    //      형식) class 클래스명(자식) : 클래스명(부모) ===> (기반이 될 부모 클래스는 미리 정의가 되어있어야만 한다)
    class Base
    {                                               // ** 부모 클래스에서 정해놓은 접근권한들도 상속된다
        private string var1 = "private형 변수";     // private   => class 내부에서만 사용 가능
        protected string var2 = "protected형 변수"; // protected => class 내부 ~ 파생 class까지 사용 가능
        public void baseMethod()                    // public    => class 내부 ~ 외부까지 사용 가능
        {
            Console.WriteLine("기반 클래스 메서드");
        }
    }

    class Sub : Base
    {
        public void setData(string sData)
        {
            var2 = sData;
        }

        public void subMethod()
        {
            Console.WriteLine("파생 클래스 메서드");
        }
    }

    class Sub2 : Sub
    {
        public void AAA()
        {
            this.var2 = "aaaa";
            // 자료 메서드 사용
            subMethod();
        }
    }

    // 자료형 앞 표기..) 권한, 제한, 형식
    class noGive
    {
        public int num;
    }

    sealed class giveMe : noGive // sealed 키워드를 기입하면, 해당 클래스는 파생 클래스에 상속해줄 수 없다
    {
    }
    
    class veryGive : noGive
    {
    }

    class Program
    {
        static void Main()
        {
            Sub pSub = new Sub();
            pSub.setData("상속받은 객체의 속성은?");
            pSub.baseMethod();
            pSub.subMethod();
        }
    }
    
    
}



/*
    class Book
    {
        public string title;
        public string genre;
        public void printBook()
        {
            Console.WriteLine("제  목 : " + title);
            Console.WriteLine("장  르 : " + genre);
        }
    }

    class Novel : Book
    {
        public string writer;
        public void printNov()
        {
            printBook();
            Console.WriteLine("저  자 : " + writer);
        }
    }

    class Magazine : Book
    {
        public int month;
        public void printMag()
        {
            printBook();
            Console.WriteLine("발간월 : " + month + "월");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.title = "c# 강의";
            myBook.genre = "컴퓨터";
            myBook.printBook();

            Console.WriteLine("\n ---------------");

            Novel myNov = new Novel();
            myNov.title = "개미";
            myNov.genre = "판타지";
            myNov.writer = "베르나르 베르베르";
            myNov.printNov();

            Console.WriteLine("\n ---------------");

            Magazine myMag = new Magazine();
            myMag.title = "마이크로 소프트웨어";
            myMag.genre = "컴퓨터";
            myMag.month = 7;
            myMag.printMag();
        }
    }
    */
