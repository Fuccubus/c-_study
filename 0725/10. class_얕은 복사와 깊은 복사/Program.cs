using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyClass
{
    public int data1;   // 1) 생성자 X
                        // 2) 컴파일러에서 생성자를 만들고 값을 0으로 초기화
    public MyClass cloneData()
    {
        MyClass tempData = new MyClass(); //할당
                                          /* 클래스 내 클래스의 형태
                                           |   data1                  | MyClass
                                           | [       ] cloneData()    |
                                           | [|data1 | tempData]      |
                                           */
        tempData.data1 = this.data1;
        return tempData;
    }
}
namespace _10.class_얕은_복사와_깊은_복사
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass source;
            MyClass copy;
            source = new MyClass(); // 해당 클래스 크기만큼 공간 만들고 생성자를 호출
                                    /*
                                       Console.WriteLine("내부값은 = " + source.data1);

                                       copy = source;    // source가 MyClass 자료형으로부터 할당받은 주소(공간)을 공유
                                       copy.data1 = 123; // copy가 source의 주소 내 데이터 중 data1을 가리켜 바꿈
                                       Console.WriteLine("내부값은 = " + copy.data1);
                                    */

            copy = source.cloneData();
            copy.data1 = 123;
            source.data1 = 486;
            Console.WriteLine(copy.data1 + "   " + source.data1);
        }
    }
}
