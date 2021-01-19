using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0) {
            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('\\');
            }
        } else {
            Console.WriteLine("");
        }
    }
}
