using System;

class List
{
    public static System.Collections.Generic.List<int> DifferentElements(System.Collections.Generic.List<int> list1, System.Collections.Generic.List<int> list2)
    {
        System.Collections.Generic.List<int> listDifferents = new System.Collections.Generic.List<int>();

       
        foreach (int item in list1)
        {
            if (!list2.Contains(item))
            {
                listDifferents.Add(item);
            }
        }

        foreach (int item in list2)
        {
            if (!list1.Contains(item))
            {
                listDifferents.Add(item);
            }
        }
        listDifferents.Sort();
        return listDifferents;
    }
}

