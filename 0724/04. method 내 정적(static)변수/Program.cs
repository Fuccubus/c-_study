using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace namespace_04.method_내_정적_static_변수
{
    class Program                       // 형태를 정한 것이지 메모리가 만들어진 것은 아니다
    {
        public static int numData = 33; // 정적변수 : static 함수로 인해 별도의 메모리 공간을 지님
                                        // 전역변수와 비슷하게 프로그램이 종료될 때까지 사용할 수 있음

        public static void var_Data()
        {
            int a = 123;                // 지역변수 : {}안에 선언된 변수로, {}밖으로 나가면 사라짐
            int b = 486;
        }
        static void Main(string[] args)
        {
            /*
            //구체화된 것(메모리가 정의된 것들만)
            numData = 773;
            int aaa;                    // 메모리 공간이 있는 것을 구체화
            var_Data();
            Console.WriteLine(numData);
            */
            int[] num1 = new int[5];
            Console.WriteLine(num1.Length); // 배열의 길이
            // temp(1);
            // temp(1, 1);
            temp(1, 1, 1);
        }

        static void temp(params int[] datastr)
        {
            Console.WriteLine(datastr.Length);
        }
    }
}
/*
 * 메서드 내에서 만드는 자료형들은 일반적으로 지역변수라 부른다.
 * 지역변수 : 특정 영역 안에 만들어진 변수로, 해당 영역(블럭)을 벗어나면 자동으로 파괴된다.
 * 
 * ex) static -> 정적
 * 메모리 공간의 정적... => 메모리 공간을 만들고 해당 공간을 재사용한다.
 *     static 변수       -> 첫번째 호출 ============================>>  두번째 호출
 * ... 공간을 생성          값의 변경                                   반환하지 않은 공간을 재사용
 * ...  값을 세팅           값이 없을 때 초기화                         초기화 세팅은 하지 않음
 * ...                      메서드는 저장공간을 반환하나                값의 변경은 가능
 * ...                      정적 자료형은 저장공간을 반환 안함
 * ...                      초기화가 된 경우 다시 초기화를 하지 않음
 * 
 *  결론   ) 지역변수처럼 만들어지나 => 내부형태나 사용은 전역변수처럼 사용할 수 있다.
 *  사용처 ) 어디에 사용을 하는가/
 *           main 루틴이 존재하는 경우엔 static 변수를 사용 여부는 중요하지 않으나...
 *           main 루틴이 존재하지 않은 경우
 *              -> class 혹은 struct만 있는 경우, Main()이 없는 경우엔 전역변수를 만들 수 없다.
 *              -> 프로그램에서 데이터가 끝까지 유지가 안된다. (상황에 따라 모두 삭제처리)
 *              -> 이런 경우에 static 기호를 통한 변수(자료형)을 만들어서 전역변수처럼 사용할 수 있다.
 *              -> 따라서 main 루틴 외 공간에서 전역자료형을 만드는 방법으로써 사용된다.
 */