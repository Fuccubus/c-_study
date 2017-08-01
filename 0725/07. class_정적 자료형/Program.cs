using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * 클래스 내에 정적 자료형을 만들었을 때)
 * 형식
 *  클래스명
 *  {
 *  정적 자료형의 선언과 초기화
 *  }
 * 사용방법)
 * 클래스명.선언된 자료형
 * 특정영역 변수를 사용(O)
 */
class Player
{
    public static int m_gold = 0;   // 저장공간을 만들고 값을 초기화함
    public static int m_score = 1;  // 전역변수로 선언된 게 아니지만, 전역변수처럼 사용
}

struct Player2
{
    public int m_gold;
    public int m_score;
}

namespace _07.class_정적_자료형
{
    class Program
    {
        static void Main(string[] args)
        {
            Player2 player2;
            player2.m_score = 100;
            player2.m_gold = 100;

            Console.WriteLine("값은 : " + Player.m_gold);
            Player.m_gold += 100;
            Player.m_score += 1000;
          // 영역 . 변수   => 구조체나 포인터의 멤버같은 느낌.
          //                  특정영역에 있는 변수를 사용.

            Console.WriteLine("값은 : " + Player.m_gold + ", 점수는 : " + Player.m_score);
            Console.WriteLine("값은 : {0}, 점수는 : {1}", Player.m_gold, Player.m_score);
        }
    }
}
