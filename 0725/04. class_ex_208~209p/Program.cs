using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.class_ex_208_209p
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine("{0} : 잘 가", Name);
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", Name);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat("키티", "하얀색");
            Kitty.Meow();
            Console.WriteLine("{0} : {1}", Kitty.Name, Kitty.Color);

            Cat Nero = new Cat("네로", "검은색");
            Nero.Meow();
            Console.WriteLine("{0} : {1}", Nero.Name, Nero.Color);
        }
    }
}
