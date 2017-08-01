using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.DeepCopy_ex_216_217p
{
    class MyClass
    {
        public int myField1;
        public int myField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.myField1 = this.myField1;
            newCopy.myField2 = this.myField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.myField1 = 10;
                source.myField2 = 20;

                MyClass target = source;
                target.myField2 = 30;

                Console.WriteLine("{0} {1}", source.myField1, source.myField2);
                Console.WriteLine("{0} {1}", target.myField1, target.myField2);
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.myField1 = 10;
                source.myField2 = 20;

                MyClass target = source.DeepCopy();
                target.myField2 = 30;

                Console.WriteLine("{0} {1}", source.myField1, source.myField2);
                Console.WriteLine("{0} {1}", target.myField1, target.myField2);
            }
        }
    }
}
