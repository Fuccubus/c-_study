using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class bookData
{
    public string m_title;
    public int    m_price;
    public bookData(string t, int p)
    {
        m_title = t;
        m_price = p;
    }
    public void print()
    {
        Console.WriteLine("제목 : " + m_title);
        Console.WriteLine("가격 : " + m_price);
    }
 // 객체의 인자로 받는 생성자 => 내부의 데이터 세팅을 위해
 // 복사 생성자                 (받은 객체의 정보를 복사해서 현재 객체에 넣기 때문에)
    public bookData(bookData temp) // 저장공간을 만든 것이 아닌, 자료형을 받은 것
    {
        this.m_title = temp.m_title; // 받은 자료형을 수정하는 것이 아닌, 값을 넣어주는 것
        this.m_price = temp.m_price;
                                     // temp 내부 데이터의 변경(X)
    }
}

class Program
{
    static void Main()
    {
        bookData source = new bookData("트와일라잇", 19800);
        source.print();

        bookData copy = new bookData(source);
        copy.print();

        source.m_price = 21300;
        source.print();

        copy.print();
    }
}