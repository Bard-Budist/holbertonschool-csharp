using System;

class LList
{
    public static int Sum(System.Collections.Generic.LinkedList<int> myLList)
    {
        int sumElements = 0;

        foreach (int item in myLList)
        {
            sumElements += item;
        }
        return sumElements;
    }
}

