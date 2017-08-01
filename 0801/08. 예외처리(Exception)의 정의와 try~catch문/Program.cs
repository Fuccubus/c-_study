using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.예외처리_Exception_의_정의와_try_catch문
{/*
  *                     예외처리란?)  프로그램 실행 중 일어나게 되는 오류를 말하며,
  *                                  이러한 오류를 대응하는 코드들을 예외처리라 부른다.
  *                                  
  *                                  
  * try ~ catch ~ throw ~ finally는?) try문     : 예외가 일어날 지도 모르는 영역을 블록화 시키는 부분.
  *                                   catch문   : 예외(오류)가 일어났을 때, 오류의 종류와 처리를 담당하는 부분.
  *                                   throw문   : 의도적으로 예외 상황을 만들어서 강제로 catch문을 실행하게 만드는 부분.
  *                                   finally문 : 예외와 관계없이 처리되는 부분.
  *                                   
  *                             형식) try
  *                                   {
  *                                         오류가 날 지도 모르는 부분
  *                                         
  *                                         // 예외상황을 만들 땐) throw 예외코드; //
  *                                   }
  *                                   
  *                                   catch
  *                                   {
  *                                         예외 상황이 발생했을 때 처리
  *                                   }
  *                                   
  *                                   finally
  *                                   {
  *                                         예외가 있던 없던 처리되는 부분
  *                                   }
  */
class calc
    {
        public void divide(int x, int y)
        {
            int z;
            try
            {
                z = x / y; // x를 0으로 나눌 수 없다 = 에러 발생

             // 에러 발생 시, catch 구문 

             // 강제로 예외 상황을 만들 땐 throw 구문
                if (x == 0) // 상태에 맞추어
                {
                    Exception e1 = new Exception("값이 0이어서");
                 // e1.Message = "값이 0이어서";
                    throw e1; // 에러 코드를 날림.
                }
            }
            
            catch (Exception e) // 상황 별 에러 데이터가 들어감.
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("에러 발생");
            }            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calc c = new calc();
            c.divide(5, 3);
            c.divide(30, 0); // <- 0을 나눌 수 없다 = 에러 발생, try에서 catch 실행
            c.divide(0, 30); // <- try 내 throw문 조건 성립, try에서 throw를 통해 catch 실행 
        }
    }
}
