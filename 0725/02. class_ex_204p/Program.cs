using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.class_ex_204p
{
    class Cat
    {
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
            Cat Kitty = new Cat();
            Kitty.Color = "하얀색";
            Kitty.Name = "키티";
            Kitty.Meow();
            Console.WriteLine("{0} : {1}", Kitty.Name, Kitty.Color);

            Cat Nero = new Cat();
            Nero.Color = "검은색";
            Nero.Name = "네로";
            Nero.Meow();
            Console.WriteLine("{0} : {1}", Nero.Name, Nero.Color);
        }
    }
}
