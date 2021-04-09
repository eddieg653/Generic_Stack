using System;

namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myInts = new Stack<int>(10);
            myInts.Push(1);
            myInts.Push(2);
            bool isFull = myInts.IsFull();
            bool isempty = myInts.IsEmpty();
            int x = myInts.Pop();
            Console.WriteLine(x);


            Stack<string> myStrings = new Stack<string>(10);
            myStrings.Push("One");
            myStrings.Push("two");
             isFull = myStrings.IsFull();
             isempty = myStrings.IsEmpty();
             string s = myStrings.Pop();
            Console.WriteLine(s);




            charStack charfive = new charStack(5);
            charfive.Push('a');
            charfive.Push('d');
            charfive.Push('3');
            charfive.Push('b');
            charfive.Push('y');
            charfive.Push('n');





            IntStack tenInts = new IntStack(10);
            bool mt = tenInts.IsEmpty();
            bool full = tenInts.IsFull();


            int v1 = tenInts.Pop();//-1
            int v2 = tenInts.Pop();//456

            tenInts.Push(789);
            Console.WriteLine("no error");

            StringStack newstringstuff = new StringStack(5);

            newstringstuff.Push("the little boy is small");
            bool ms = newstringstuff.IsEmpty();
            bool msfuldl = newstringstuff.IsFull();
            newstringstuff.Push("the little boy is small");
            newstringstuff.Push("the little boy is small");
            newstringstuff.Push("the little boy is small");
            newstringstuff.Push("the little boy is small");
            newstringstuff.Push("the little boy is small");
            newstringstuff.Push("the little boy is small");
            newstringstuff.Push("the little boy is small");
            bool msfull = newstringstuff.IsFull();
            bool mc = newstringstuff.IsEmpty();

            Console.WriteLine("no error again");







        }
    }
}
