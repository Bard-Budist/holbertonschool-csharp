using System;

class LList
{
    public static System.Collections.Generic.LinkedListNode<int> Add(System.Collections.Generic.LinkedList<int> myLList, int n)
    {
        System.Collections.Generic.LinkedListNode<int> node;

        node = myLList.AddFirst(n);

        return node;
    }
}

