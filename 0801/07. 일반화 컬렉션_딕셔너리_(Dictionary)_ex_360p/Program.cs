using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.일반화_컬렉션_딕셔너리__Dictionary__ex_360p
{
    class MainApp
    {
        static void Main(string[] args)
        {//             Tkey , Tvalue
            Dictionary<string, string> dic = new Dictionary<string, string>();
                            
            dic["하나"] = "One";
            dic["둘"] = "Two";
            dic["셋"] = "Three";
            dic["넷"] = "Four";
            dic["다섯"] = "Five";

            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
            Console.WriteLine(dic["넷"]);
            Console.WriteLine(dic["다섯"]);
        }
    }
}
