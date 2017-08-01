using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.컬렉션_대기열_Queue__327p
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
