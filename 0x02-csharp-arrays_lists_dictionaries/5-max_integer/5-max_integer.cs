using System;

class List
{
    public static int MaxInteger(System.Collections.Generic.List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = myList[0];
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] > max) 
            {
                max = myList[i];
            }
        }
        return max;
    }
}

