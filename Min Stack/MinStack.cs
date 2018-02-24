using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Stack
{
    public class MinStack
    {
        private object[] _array;
        private int _size;

        public MinStack()
        {
            _size = 0;
            _array = new object[int.MaxValue];
        }

        public void Push(int x)
        {
            _array[_size] = x;
            _size++;
        }

        public void Pop()
        {
            _array[--_size] = null;
        }

        public int Top()
        {
            var top = _size - 1;
            return (int)_array[top];

        }

        public int GetMin()
        {
            return (int)_array.Min(p => p);
        }
    }
}
