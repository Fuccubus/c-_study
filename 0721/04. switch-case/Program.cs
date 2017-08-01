using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.switch_case
{
    class Program
    {
        enum Animal { mouse, cat, bird, dog = 100, pig = 200, lion }
        static void Main()
        {
            Animal a;
            a = Animal.dog;
            Console.WriteLine(Animal.bird);
            Console.WriteLine(Animal.pig);
            Console.WriteLine((int)Animal.pig);
            Console.WriteLine((int)a + " animal " + a);
        }
    }
}

/*
  int num = 23;
            num = num % 5;
            switch(num)
            {
                case 1:
                    Console.WriteLine("나머지는 1");
                    break;
                case 2:
                    Console.WriteLine("나머지는 2");
                    break;
                case 3:
                    Console.WriteLine("나머지는 3");
                    break;
                case 4:
                    Console.WriteLine("나머지는 4");
                    break;
                default:
                    Console.WriteLine("나머지는 0");
                    break;
            }
 */


/*
int score = 75;
            switch(score/10) // 기입한 값 나누기 10
            {
                case 10:
                    Console.WriteLine("학점 S"); 
                    break;
                case 9:
                    Console.WriteLine("학점 A");
                    break;
                case 8:
                    Console.WriteLine("학점 B");
                    break;
                default:
                    Console.WriteLine("학점 C");
                    break;
            }
 */


//상수..
//변수 선언과 비슷하지만 앞에 const 를 붙인다. ex) const int num =33;
//생성과 동시에 초기화해야 한다(생성 후에 초기화 불가)
//생성 후 값의 변경이 불가

//열거..
//멤버변수 별로 자동으로 값이 세팅되는 자료형

//열거의 형식..
//1) 자료형의 선언..
//enum 자료형 이름{파라미터(키워드)}; 해당 키워드에 값이 자동으로 세팅된다.
//                                    0부터 세팅이 됨.
//2) 변수선언
//열거자료형 변수

//3) 변수에 값을 세팅
//변수 = 열거형, 파라미터;   파라미터가 가리키고 있는 숫자값이 변수에 들어감

// C언어는 자료형들에 들어가는 데이터는 값으로 들어감.
// enum의 경우는 정수 값을 들어감.


/*
enum GameState { Load = 1, Intro, Game, Option = 7, Exit }
static void Main(string[] args)
{            
    GameState state;        // 변수
    state = GameState.Load; //세팅
    Console.WriteLine(state);
    Console.WriteLine((int)GameState.Load);
    Console.WriteLine((int)GameState.Exit);

    switch (state)
    {
        case GameState.Load:
            Console.WriteLine("Load");
            break;
        case GameState.Game:
            Console.WriteLine("Game");
            break;
        case GameState.Option:
            Console.WriteLine("Option");
            break;
        case GameState.Intro:
            break;
    }
}
*/