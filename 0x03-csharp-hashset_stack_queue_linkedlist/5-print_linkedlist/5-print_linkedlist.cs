using System;

class LList
{
    public static System.Collections.Generic.LinkedList<int> CreatePrint(int size)
    {
        
        System.Collections.Generic.LinkedList<int> linkedNumbers = new System.Collections.Generic.LinkedList<int>();

        if (size < 0)
        {
            return linkedNumbers;
        }

        for (int i = 0; i < size; i++)
        {
            linkedNumbers.AddLast(i);
            Console.WriteLine(i);
        }
        return linkedNumbers;
    }
}
