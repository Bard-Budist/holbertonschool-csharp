using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size ==  0)
        {
            Console.WriteLine("");
        } else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] numbers_array = new int[size];
        string end = "";

        for (var i = 0; i < size; i++)
        {
            numbers_array[i] = i;
            if (i == size - 1)
            {
                end = "\n";
            } else
            {
                end = " ";
            }
            Console.Write("{0}{1}", i, end);
        }
        return numbers_array;
    }
}

