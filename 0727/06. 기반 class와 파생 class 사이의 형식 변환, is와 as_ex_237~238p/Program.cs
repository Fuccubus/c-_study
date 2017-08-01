using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.기반_class와_파생_class_사이의_형식_변환__is와_as_ex_237_238p
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog) // is : 해당 자료형(세팅된 데이터 공간)이 일치한가 여부를 체크
                              // ex) int a = 3;
                              //     if(a is int) => 참
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat; // as : 해당 자료형을 강제로 형변환시키되, 실패 시 강제로 0값(false, NULL)으로 변환
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
