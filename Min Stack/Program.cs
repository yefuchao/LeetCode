using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack stack = new MinStack();

            stack.Push(2);

            stack.Push(0);

            stack.Push(3);

            stack.Push(0);

            Console.WriteLine(stack.GetMin());

            stack.Pop();

            Console.WriteLine(stack.GetMin());

            stack.Pop();

            Console.WriteLine(stack.GetMin());

            stack.Pop();

            Console.WriteLine(stack.GetMin());

            Console.ReadLine();


        }
    }
}
