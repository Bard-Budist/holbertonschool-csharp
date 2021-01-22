using System;

class List
{
    public static System.Collections.Generic.List<int> CommonElements(System.Collections.Generic.List<int> list1, System.Collections.Generic.List<int> list2)
    {
        System.Collections.Generic.List<int> sameIntegers = new System.Collections.Generic.List<int>();
        foreach (int item in list1)
        {
            if (list2.Contains(item))
            {
                sameIntegers.Add(item);
            }
        }
        sameIntegers.Sort();
        return sameIntegers;
    }
}

