using System;

class LList
{
    public static void Delete(System.Collections.Generic.LinkedList<int> myLList, int index)
    {
        System.Collections.Generic.LinkedListNode<int> node = myLList.First;
        int positionList = 0;
        while (node != null)
        {
            if (positionList == index)
            {
                myLList.Remove(node);
            }
            positionList++;
            node = node.Next;
        }
    }
}

