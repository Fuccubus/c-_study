﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.상속으로_코드_재활용_ex_231_233p
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0}.Base()", this.Name);
        }

        ~Base()
        {
            Console.WriteLine("{0}.~Base()", this.Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", this.Name);
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine("{0}.Derived()", this.Name);
        }

        ~Derived()
        {
            Console.WriteLine("{0}.~Derived", this.Name);
        }

        public void DerivedMethod()
        {
            Console.WriteLine("{0}.DerivedMethod()", Name);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
