using Generic_Stack;
using System;
using Xunit;

namespace StackTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           IntStack x = new IntStack(3);
            x.Push(1);
            x.Push(2);
            Assert.Equal(false, x.IsEmpty());
            Assert.Equal(2, x.Pop());
        }

        [Fact]
        public void TestStackIsFull()
        {
            Stack<string> s = new Stack<string>(3);
            s.Push("one");
            s.Push("two");
            s.Push("three");
            Assert.Equal(true, s.IsFull());
        }

    }
}
