using System;

class List
{
    public static System.Collections.Generic.List<int> DeleteAt(System.Collections.Generic.List<int> myList, int index)
    {
        if (myList.Count - 1 < index || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        myList.Remove(myList[index]);
        return myList;
    }
}

