using System;

class LList
{
    public static int GetNode(System.Collections.Generic.LinkedList<int> myLList, int n)
    {
        int numberIndex = 0;
        foreach (int item in myLList)
        {
            if (numberIndex == n)
            {
                return item;
            }
            numberIndex++;
        }
        return 0;
    }
}

