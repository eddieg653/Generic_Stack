using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Stack
{
    class charStack
    {
        private int     _charsize;        // initially 0
        private char[]  _charstack;       // initially null
        private int     _topofCharStack;  // initially 0
        // C o n s t r u c t o r s
        public charStack(int size)
        {
            _charsize  = size;
            _charstack = new char[size];
        }

        //M e t h o d s
        public bool IsEmpty()
        {
            if (_topofCharStack > 0)
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
            if (_topofCharStack >= _charsize)
            {
                return true;
            }

            return false;
        }

        public char Pop()
        {
            if (_topofCharStack > 0)
            {
                _topofCharStack--;
                return _charstack[_topofCharStack];
            }
            return '\0'; // ascii
        }

        public void Push(char valueToPush)
        {
            if (_topofCharStack < _charsize)
            {
                _charstack[_topofCharStack] = valueToPush;
                _topofCharStack++;
            }
        }




    }
}
