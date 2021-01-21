using System;

class Dictionary
{
    public static System.Collections.Generic.Dictionary<string, int> MultiplyBy2(System.Collections.Generic.Dictionary<string, int> myDict)
    {
        System.Collections.Generic.Dictionary<string, int> dict = new System.Collections.Generic.Dictionary<string, int>();
        foreach (var item in myDict)
        {
            dict.Add(item.Key, item.Value * 2);
        }
        return dict;
    }
}

