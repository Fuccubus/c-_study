using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Book
{
    public int price;
    public int num = 0;
    public string title;
    public Book()
    {
        price = num = 0;
        title = "";
    }
    public Book(string t, int p)
    {        
        title = t;
        price = p;
    }
    public void printbook()
    {
        Console.WriteLine("제목 : " + title);
        Console.WriteLine("가격 : " + this.price); // this.의 의미 = 현재 내 객체를 참조함.
        /* 클래스 키워드...
         *    this.클래스명 => 현재 내가 사용중인 클래스의 이름을 통해
         *                     객체를 제어한다.
         *             
         */
        Console.WriteLine("주문량 : " + num);
        Console.WriteLine("총합 : " + price * num);
    }
}

namespace _08.constructor_destructor_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("해리포터_조애롤링", 34000);
            book.num = 10;
            book.printbook();
        }
    }
}
