using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class purse
{
    public static int money = 0;
    public void printMoney(int m_In, int m_Out)
    {
        money = money + m_In - m_Out;
        if (money < 0)
        {
            Console.WriteLine((-1 * money) + "원이 모자랍니다."); // (-1 * money) : 음수를 반대로.. 모자라다는 말 자체가 음수를 의미하니 반대로
        }
        else
        {
            Console.WriteLine(money + "원이 있습니다.");
        }
    }
}

namespace _07.class_내_정적_Static__변수
{
    class Program
    {
        static void Main(string[] args)
        {
            purse store1 = new purse();
            purse store2 = new purse();

            store1.printMoney(1000, 100);
            store2.printMoney(0, 250);
            store1.printMoney(0, 800);

            Console.WriteLine(purse.money);
        }
    }
}
