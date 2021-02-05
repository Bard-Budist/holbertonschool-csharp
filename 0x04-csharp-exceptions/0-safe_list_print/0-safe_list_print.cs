using System;

class List
{
    public static int SafePrint(System.Collections.Generic.List<int> myList, int n)
    {
        int count = myList.Count, i;
        try
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", myList[i]);
                if (i + 1 == n)
                {
                    return i + 1;
                }
            }
        }
        catch (System.Exception)
        {
            return count;
        }
        return count;
    }
}

