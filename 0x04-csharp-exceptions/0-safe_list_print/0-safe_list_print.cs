using System;

class List
{
    public static int SafePrint(System.Collections.Generic.List<int> myList, int n)
    {
        int count = myList.Count, i;
        for (i = 0; i < count; i++)
        {
            Console.WriteLine("{0}", myList[i]);
            if (i + 1 == n)
            {
                return i + 1;
            }
        }
        return count;
    }
}

