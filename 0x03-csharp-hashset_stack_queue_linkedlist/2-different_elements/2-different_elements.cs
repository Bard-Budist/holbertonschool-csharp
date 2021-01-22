using System;

class List
{
    public static System.Collections.Generic.List<int> DifferentElements(System.Collections.Generic.List<int> list1, System.Collections.Generic.List<int> list2)
    {
        System.Collections.Generic.List<int> listDifferents = new System.Collections.Generic.List<int>();

        int position = 0;
        foreach (int item in list1)
        {
            if (!list2.Contains(item))
            {
                listDifferents.Add(item);
            }
            
            if (!list1.Contains(list2[position]))
            {
                listDifferents.Add(list2[position]);
            }
            position++;
        }
        listDifferents.Sort();
        return listDifferents;
    }
}

