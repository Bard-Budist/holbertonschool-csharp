using System;

class Dictionary
{
    public static System.Collections.Generic.Dictionary<string, string> AddKeyValue(System.Collections.Generic.Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value;
            
        } else
        {
            myDict.Add(key, value);
        }
        return myDict;
    }
}

