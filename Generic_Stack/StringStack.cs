using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Stack
{
    class StringStack
    {
        private int _stringsize; //initially 0
        private string[] _stringstack; //initially null
        private int _stringTopOfStack;
        // C o n s t r u c t o r s
        public StringStack(int stringsize)
        {
            _stringsize = stringsize;
            _stringstack = new string[stringsize];
        }

        //M e t h o d s


        public bool IsEmpty()
        {
            if (_stringTopOfStack > 0)
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
            if (_stringTopOfStack >= _stringsize)
            {
                return true;
            }
            return false;
        }

        public string Pop()
        {
            if (_stringTopOfStack > 0)
            {
                _stringTopOfStack--;
                return _stringstack[_stringTopOfStack];
            }
            return "";
        }

        public void Push(string valueToPush)
        {
            if (_stringTopOfStack < _stringsize)
            {
                _stringstack[_stringTopOfStack] = valueToPush;
                _stringTopOfStack++;
            }
        }

    }
}
