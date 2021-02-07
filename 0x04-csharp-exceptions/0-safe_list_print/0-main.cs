using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        List<int> myList = new List<int>() {12, 23, 34, 45, 56, 67, 78, 89};
        int count;

        count = List.SafePrint(myList, 0);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        // count = List.SafePrint(myList, myList.Count - 2);
        // Console.WriteLine("Number of integers printed: " + count);
        // Console.WriteLine();

        // count = List.SafePrint(myList, myList.Count + 2);
        // Console.WriteLine("Number of integers printed: " + count);
    }
}