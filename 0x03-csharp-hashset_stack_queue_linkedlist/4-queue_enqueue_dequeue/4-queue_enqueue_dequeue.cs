using System;

class MyQueue
{
    public static System.Collections.Generic.Queue<string> Info(System.Collections.Generic.Queue<string> aQueue, string newItem, string search)
    {
        int sizeQueue =  aQueue.Count;
        bool existElement = false;
        int searchIndex = 0;

        Console.WriteLine("Number of items: {0}", sizeQueue);

        if (sizeQueue == 0)
        {
            Console.WriteLine("Queue is empty");
        } else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        aQueue.Enqueue(newItem);

        foreach (string item in aQueue)
        {
            if (item == search)
            {
                existElement = true;
                break;
            }
            searchIndex++;
        }
        Console.WriteLine("Queue contains \"{0}\": {1}", search, existElement ? "True" : "False");

        if (existElement)
        {
            for (int i = 0; i <= searchIndex; i++)
            {
                aQueue.Dequeue();
            }
        }
        return aQueue;
    }
}

