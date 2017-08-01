using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.method_ex_179_180p_ref_키워드_
{
    class MainApp
    {
        public static void swapWithoutRef(int a, int b)      // 1) 매개 변수 앞에 ref를 안 붙이면...
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void swapWithRef(ref int a, ref int b) // 4) 반대로 매개변수 앞에 ref를 붙이면...
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("x:{0}, y:{1}", x, y);

            swapWithoutRef(x, y);
            Console.WriteLine("x:{0}, y:{1}", x, y);         // 2) ...값이 바뀌지 않는다.
                                                             // 3) 왜냐하면 메서드는 한번 계산하고 나면 즉시 휘발되어 버리기 때문                                                        

            swapWithRef(ref x, ref y);
            Console.WriteLine("x:{0}, y:{1}", x, y);         // 5) 정상적으로 값이 변경됨
        }
    }
}