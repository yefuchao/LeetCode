using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Stack
{
    public class MinStack
    {
        #region
        private Stack<long> _stack;

        private long _min;

        public MinStack()
        {
            _stack = new Stack<long>();
        }

        public void Push(int x)
        {
            if (_stack.Count == 0)
            {
                _stack.Push(0L);
                _min = x;
            }
            else
            {
                _stack.Push(x - _min);
                if (x < _min)
                {
                    _min = x;
                }
            }
        }

        public void Pop()
        {
            if (_stack.Count == 0)
            {
                return;
            }

            long pop = _stack.Pop();

            if (pop < 0)
            {
                _min = _min - pop;
            }
        }

        public int Top()
        {
            long top = _stack.Peek();

            if (top > 0)
            {
                return (int)(top + _min);
            }
            else
            {
                return (int)(_min);
            }
        }

        public int GetMin()
        {
            return (int)_min;
        }
        #endregion
    }
}
