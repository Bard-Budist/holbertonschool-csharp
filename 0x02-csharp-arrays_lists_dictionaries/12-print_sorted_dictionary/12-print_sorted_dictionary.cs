using System;

class Dictionary
{
    public static void PrintSorted(System.Collections.Generic.Dictionary<string, string> myDict)
    {
        System.Collections.Generic.List<string> sordListKeys = new System.Collections.Generic.List<string>(myDict.Keys);
        System.Collections.Generic.Dictionary<string, string> dictSorted = new System.Collections.Generic.Dictionary<string, string>();
        sordListKeys.Sort();
        for (var i = 0; i < sordListKeys.Count; i++)
        {
            dictSorted.Add(sordListKeys[i], myDict[sordListKeys[i]]);
        }
        foreach (var item in dictSorted)
        {
            Console.WriteLine("{0}: {0}", item.Key, item.Value);
        }
    }
}

