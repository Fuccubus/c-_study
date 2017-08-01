using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 추상 클래스란?) 기반 객체로 현재 구현이 되지 않은 프로토 타입을 기능을 정의하고,
 *                 파생 객체로 프로토 타입을 구현하는 것을 말한다.
 *                 쉽게 말해, 부모 객체가 틀을 잡고, 자식 객체가 실현한다는 의미.
 *                 
 * 프로토 타입은?) 처리 루틴 없이 정의만을 내린 것을 프로토 타입이라 일컫는다.
 * 
 * 사용 방법) 1. 기반 클래스)
 *               클래스 앞에 abstract 키워드를 붙인다.
 *               추상화시킬 메서드 앞에 abstract를 붙여서 추상화시킨다.
 *               
 *            2. 파생 클래스)
 *               override 키워드를 붙여서 추상화시킨 메서드를 구현한다.
 */
abstract class calcA
{
    public int a;
    public int b;
    public abstract void answer(); // 지난 시간에 배운 다형성과 비슷 : virtual - override
    public void setData(int m, int n)
    {
        a = m;
        b = n;
    }
}

class plused : calcA
{
    public override void answer()
    {
        Console.WriteLine(a + " " + b + " " + (a + b));
    }
}

namespace _04.추상_클래스_abstract_class_의_정의
{
    class Program
    {
        static void Main(string[] args)
        {
            plused ps = new plused();
            ps.setData(123, 486);
            ps.answer();
        }
    }
}
