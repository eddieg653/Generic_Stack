using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Stack
{
    public class Stack<T>
    {
        private int _size; //initially 0
        private T[] _stack; //initially null
        private int _topOfStack;

        // C o n s t r u c t o r s
        public Stack(int size)
        {
            _size = size;
            _stack = new T[size];
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

        public T Pop()
        {
            if (_topOfStack > 0)
            {
                return _stack[--_topOfStack];
            }
            return default(T);
        }

        public void Push(T valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        }
    }
}
