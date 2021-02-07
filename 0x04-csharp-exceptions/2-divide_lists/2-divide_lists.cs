using System;

class List
{
    public static System.Collections.Generic.List<int> Divide(System.Collections.Generic.List<int> list1, System.Collections.Generic.List<int> list2, int listLength)
    {
        System.Collections.Generic.List<int> newList = new System.Collections.Generic.List<int>();
            for (var i = 0; i < listLength; i++)
            {
                try
                {
                    newList.Add(list1[i] / list2[i]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
                catch (System.DivideByZeroException)
                {
                    newList.Add(0);
                    Console.WriteLine("Cannot divide by zero");
                    
                }
            }
        return newList;
    }
}
