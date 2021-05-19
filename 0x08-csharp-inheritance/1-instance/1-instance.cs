using System;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType() == typeof(int[]) || obj.GetType() == typeof(int[,]))
        {
            return true;
        }
        return false;
    }
}

