using System;

class LList
{
    public static System.Collections.Generic.LinkedListNode<int> Insert(System.Collections.Generic.LinkedList<int> myLList, int n)
    {
        System.Collections.Generic.LinkedListNode<int> firstNode = myLList.First;
        System.Collections.Generic.LinkedListNode<int> newNode;

        System.Collections.Generic.LinkedListNode<int> previousNode = null;
        while (firstNode != null)
        {
            if (firstNode.Previous != null)
            {
                previousNode = firstNode.Previous;
            }
            
            if ((previousNode != null && previousNode.Value <= n && firstNode.Value >= n))
            {
                newNode = myLList.AddAfter(previousNode, n);
                break;
                
            } else if (firstNode.Value >= n && previousNode == null)
            {
                newNode = myLList.AddFirst(n);
                break;
            } else if (firstNode.Next == null && firstNode.Value <= n)
            {
                newNode = myLList.AddAfter(firstNode, n);
                break;
            }
            firstNode = firstNode.Next;
        }
        return firstNode;


    }
}

