using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            List<char> tmpString = new List<char>();
            foreach (char stringChar in s)
            {
                if (!Char.IsPunctuation(stringChar) && !Char.IsWhiteSpace(stringChar))
                {
                    tmpString.Add(Char.ToLower(stringChar));
                }
            }
            if (tmpString.Count == 0)
                return (true);
            List<char> revString = new List<char>(tmpString);
            revString.Reverse();
            return (tmpString.SequenceEqual(revString));
        }
    }
}
