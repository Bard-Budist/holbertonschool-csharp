using System;

class Dictionary
{
    public static int NumberOfKeys(System.Collections.Generic.Dictionary<string, string> myDict)
    {
        int indexLen = 0;
        foreach (var item in myDict)
        {
            indexLen++;
        }
        return indexLen;
    }
}
