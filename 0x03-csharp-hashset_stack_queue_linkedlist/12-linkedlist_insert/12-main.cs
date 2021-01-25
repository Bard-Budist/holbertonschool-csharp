using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(7);
        myLList.AddLast(11);
        myLList.AddLast(15);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);
        // myLList.AddLast(0);


        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("------------------");
        LList.Insert(myLList, 25);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}