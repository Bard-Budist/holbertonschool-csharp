using System;

class LList
{
    public static int Pop(System.Collections.Generic.LinkedList<int> myLList)
    {
        System.Collections.Generic.LinkedListNode<int> elementeDeleted;
        if (myLList.Count == 0)
        {
            return 0;
        } else 
        {
            elementeDeleted = myLList.First;
            myLList.RemoveFirst();
            return elementeDeleted.Value;
        }

    }
}

