//Assignment 6.2.1
//Write a C# program to implement a stack by using array with push and pop operations.

using System;
using System.Linq;

Console.WriteLine("Manual Stack Using an Array:");

ManualStack arrayStack = new ManualStack();

if (arrayStack.Count() == 0)
{
    Console.WriteLine("Stack is empty.");
}

Console.WriteLine($"Count: {arrayStack.Count()}");

arrayStack.Push(6);
arrayStack.Push(7);
arrayStack.Push(8);

Console.WriteLine($"\nTop item: {arrayStack.Peek()}");
Console.WriteLine($"Count: {arrayStack.Count()}");

Console.WriteLine($"\nPopped: {arrayStack.Pop()}");

Console.WriteLine($"Top item after Pop: {arrayStack.Peek()}");
Console.WriteLine($"Count after Pop: {arrayStack.Count()}");


class ManualStack
{
    private int[] stack;

    public ManualStack()
    {
        stack = Array.Empty<int>();
    }

    public void Push(int value)
    {
        stack = stack.Append(value).ToArray();
    }

    public int Pop()
    {
        if (stack.Length == 0)
        {
            Console.WriteLine("Stack is empty.");
            return -1;
        }

        int value = stack[stack.Length - 1];

        stack = stack.Take(stack.Length - 1).ToArray();

        return value;
    }

    public int Peek()
    {
        if (stack.Length == 0)
        {
            Console.WriteLine("Stack is empty.");
            return -1;
        }

        return stack[stack.Length - 1];
    }

    public int Count()
    {
        return stack.Length;
    }
}



//initial code for manual stack implementation using an array in seperate class file
//using Assignment_6._2._1;

//Console.WriteLine("Manual Stack Implementation:");


//ManualStack arrayStack = new ManualStack(5);


//Console.WriteLine($"Count: {arrayStack.Count()}");

//arrayStack.Push(6);
//arrayStack.Push(7);
//arrayStack.Push(8);

//Console.WriteLine($"\nTop item: {arrayStack.Peek()}");
//Console.WriteLine($"Count: {arrayStack.Count()}");

//Console.WriteLine($"\nPopped: {arrayStack.Pop()}");

//Console.WriteLine($"Top item after Pop: {arrayStack.Peek()}");
//Console.WriteLine($"Count after Pop: {arrayStack.Count()}");










