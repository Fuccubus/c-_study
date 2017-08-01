using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameTest
{
    public class tstA
    {
        public void showData()
        {
            Console.WriteLine("NameTest 영역에 있는 클래스입니다.");
        }
    }
}
/*
 * 1. 클래스 이름은 중복 불가능하지만..)
 *      같은 이름의 클래스라도 각자 다른 namespace에 있다면 OK
 * 
 * 2. 만약 namespace의 이름이 중복된다면?)
 *      같은 이름의 namespace끼리 병합된다.
 *      이를 이용해 namespace를 분할해서 합쳐서 사용할 수 있다.
 * 
 * 3. 만약 같은 이름의 namespace끼리 합쳐질 때 같은 이름의 내부 클래스들은 어떻게?)
 *      위 1번과 마찬가지로 중복 에러가 발생한다.
 *      
 */
namespace NameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NameTest.tstA a = new NameTest.tstA();
            a.showData();

            tstA b = new tstA();
            b.showData();
        }
    }
}