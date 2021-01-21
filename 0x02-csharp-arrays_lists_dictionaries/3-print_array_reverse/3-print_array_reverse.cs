using System;

class Array
{
    public static void Reverse(int[] array)
    {
        string end = "";
        if (array != null && array.Length > 0)
        {
            for (var i = array.Length - 1; i >= 0 ; i--)
            {
                if (i - 1>= 0) {
                    end = " ";
                } else
                {
                    end = "\n";
                }
                Console.Write("{0}{1}", array[i], end);
            }
        } else {
            Console.WriteLine("");
        }
    }
}

