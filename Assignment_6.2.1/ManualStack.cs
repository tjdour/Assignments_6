using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._2._1
{
    internal class ManualStack
    {
        private int[] stack;
        private int top;

        public ManualStack(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int item)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack is full.");
                return;
            }

            top++;
            stack[top] = item;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }

            int item = stack[top];
            top--;

            return item;
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }

            return stack[top];
        }

        public int Count()
        {
            return top + 1;
        }
    }
}
