using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Fishing;
using F = Fishing; // using Fishing;와 동일한 의미
                   // 해당 namespace의 별명을 부여
                   // 이를 이용해 namespace의 이름을 축약시킬 수 있다
namespace Fishing
{
    class Fish
    {
        int num; //개수
        string name;

        public Fish(string m, int n)
        {
            name = m;
            num = n;
        }

        public void print()
        {
            Console.WriteLine("{0}를 {1}마리 낚았음", name, num);
        }
    }
}

namespace _07.네임스페이스의_별명_부여
{
    class Program
    {
        static void Main(string[] args)
        {
            Fishing.Fish a = new Fishing.Fish("정어리", 2);
            F.Fish b = new F.Fish("상어", 10);
            Fish c = new Fish("방어", 5);

            a.print();
            b.print();
            c.print();
        }
    }
}