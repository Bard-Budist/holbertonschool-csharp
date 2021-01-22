using System;

class List
{
    public static int Sum(System.Collections.Generic.List<int> myList)
    {
        System.Collections.Generic.List<int> sumUnique =  new System.Collections.Generic.List<int>();

        int sumIntegers = 0;
        foreach (int item in myList)
        {
            if (!sumUnique.Contains(item))
            {
                sumIntegers += item;
                sumUnique.Add(item);
            }
        }
        return sumIntegers;

    }
}

