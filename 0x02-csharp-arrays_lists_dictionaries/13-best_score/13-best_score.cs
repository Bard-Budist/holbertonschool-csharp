using System;

class Dictionary
{
    public static string BestScore(System.Collections.Generic.Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        string positionMax = "";
        foreach (var item in myList)
        {
            if (positionMax == "")
            {
                positionMax = item.Key;
            }
            if (item.Value > myList[positionMax])
            {
                positionMax = item.Key;
            }
        }
        return positionMax;
    }
}

