using System;

class LList
{
    public static int FindNode(System.Collections.Generic.LinkedList<int> myLList, int value)
    {
        int valueIndex = 0;

        foreach (int item in myLList)
        {
            if (item == value)
            {
                return valueIndex;
            }
            valueIndex++;
        }
        return -1;
    }
}

