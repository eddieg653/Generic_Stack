using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Stack
{
    public class IntStack
    {
        private int _size; //initially 0
        private int[] _stack; //initially null
        private int _topOfStack;
        // C o n s t r u c t o r s
        public IntStack(int size)
        {
            _size = size;
            _stack = new int[size];
        }

        //M e t h o d s
        public bool IsEmpty()
        {
            if (_topOfStack > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsFull()
        {
            if (_topOfStack >= _size)
            {
                return true;
            }
            return false;
        }

        public int Pop()
        {
            if (_topOfStack > 0)
            {
                _topOfStack--;
                return _stack[_topOfStack];
            }
            return 0;
        }

        public void Push(int valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        }
    }
}
