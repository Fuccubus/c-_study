using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Date
{
    private int yy;
            int mm; // 접근권한을 기입하지 않으면
            int dd; // 자동으로 private 속성을 부여한다

    public Date(int yy, int mm, int dd)
    {
        this.yy = yy;
        this.mm = mm;
        this.dd = dd;
    }
    //  new Date(2017,07,26) =======> 프로그래머가 생성자를 만들면,
                                   // 시스템에서 제공되는 기본 생성자(default constructor)가 활성화가 안된다.
                                   // 이런 경우 Main 내에서 Date today = new Date(); 사용 불가.
    public Date():this(2017,07,27) // 따라서 this 생성자를 이용해 사용자가 직접 기본 생성자를 만들 수 있다.
    {
    }

    public void GetDate()
    {
        Console.WriteLine("{0}년도 {1}월 {2}일", yy, mm, dd);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Date time1 = new Date();
        time1.GetDate();

        Date time2 = new Date(1988, 02, 22);
        time2.GetDate();
    }
}