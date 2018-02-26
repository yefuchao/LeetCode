using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Queue
{
    public class MyStack
    {
        Queue<int> q1;
        Queue<int> q2;

        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        public void Push(int x)
        {
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            q1.Enqueue(x);


            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
        }

        public int Pop()
        {
            return q1.Dequeue();
        }

        public int Top()
        {
            return q1.Peek();
        }

        public bool Empty()
        {
            return q1.Count == 0;
        }
    }
}
