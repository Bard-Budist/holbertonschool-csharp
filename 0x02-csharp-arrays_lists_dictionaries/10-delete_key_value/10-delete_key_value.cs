using System;

class Dictionary
{
    public static System.Collections.Generic.Dictionary<string, string> DeleteKeyValue(System.Collections.Generic.Dictionary<string, string> myDict, string key)
    {
        if (myDict.ContainsKey(key))
        {
            myDict.Remove(key);
        }
        return myDict;
    }
}

