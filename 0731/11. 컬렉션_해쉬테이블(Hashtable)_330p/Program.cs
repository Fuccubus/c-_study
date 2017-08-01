using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*                                                  (검색) (정보)
 * 해쉬테이블은 배열(Array)과 달리 index가 없는 대신 key와 value를 가지고 있다.
 */
namespace _11.컬렉션_해쉬테이블_Hashtable__330p
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //  key      value
            ht["하나"] = "one";
            ht["둘"]   = "two";
            ht["셋"]   = "three";
            ht["넷"]   = "four";
            ht["다섯"] = "five";

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
            Console.WriteLine(ht["다섯"]);
        }
    }
}
