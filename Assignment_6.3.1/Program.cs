//Assignments: 6.3.1
//You are developing a program to manage a call queue of customers using the Queue  in C#.
//The program creates a queue of callers and
//demonstrates the functionality of enqueueing elements into the queue and iterating over the elements and dequeuing.

LinkedList<string> callQueue = new LinkedList<string>();

Enqueue("Alice");
Enqueue("Bob");
Enqueue("Charlie");
Enqueue("David");

Console.WriteLine("Call Queue:");
Iterate();

Console.WriteLine($"\nNumber of callers: {callQueue.Count}");

Console.WriteLine($"\nNext caller: {Peek()}");

Console.WriteLine($"\nDequeued: {Dequeue()}");

Console.WriteLine("\nCall Queue after dequeue:");
Iterate();


void Enqueue(string caller)
{
    callQueue.AddLast(caller);
}

string? Dequeue()
{
    if (callQueue.Count == 0)
    {
        Console.WriteLine("The queue is empty.");
        return null;
    }

    string caller = callQueue.First.Value;
    callQueue.RemoveFirst();

    return caller;
}

string? Peek()
{
    if (callQueue.Count == 0)
    {
        Console.WriteLine("The queue is empty.");
        return null;
    }

    return callQueue.First.Value;
}

void Iterate()
{
    foreach (string caller in callQueue)
    {
        Console.WriteLine(caller);
    }
}