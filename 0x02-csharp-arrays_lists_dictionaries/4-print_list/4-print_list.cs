using System;

class List
{
    public static System.Collections.Generic.List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        string end = "";
        System.Collections.Generic.List<int> integer = new System.Collections.Generic.List<int>();
        for (int i = 0; i < size; i++)
        {
            integer.Add(i);
            if (i < size - 1)
            {
                end = " ";
            } else
            {
                end = "\n";
            }
            Console.Write("{0}{1}", i, end);
        }
        return integer;
    }
}

