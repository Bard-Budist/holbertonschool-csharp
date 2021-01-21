using System;

class List
{
    public static System.Collections.Generic.List<bool> DivisibleBy2(System.Collections.Generic.List<int> myList)
    {
        System.Collections.Generic.List<bool> mult_2 = new System.Collections.Generic.List<bool>();
        for (var i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
            {
                mult_2.Add(true);
            } else
            {
                mult_2.Add(false);
            }
        }
        return mult_2;
    }
}

