using System;

class LList
{
    public static int Length(System.Collections.Generic.LinkedList<int> myLList)
    {
        int sizeLinked = 0;

        foreach (int item in myLList)
        {
            sizeLinked++;
        }
        return sizeLinked;
    }
}

