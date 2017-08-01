using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.인터페이스의_다중_상속_Multi_Interface_Inheritance_
{
    interface IRunnable
    {
        void Run();
    }
    
    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable // 클래스 하나에 두 개의 인터페이스를 상속받음
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable; // 강제 형변환 as를 통해 car(class FlyingCar, IRunnable, IFlyable)을
                                                   // IRunnable로 변환시킨다.
            runnable.Run();

            IFlyable flyable = car as IFlyable;    // as를 통해 car(IRunnable)을
            flyable.Fly();                         // IFlyable로 변환시킨다.
        }
    }
}
