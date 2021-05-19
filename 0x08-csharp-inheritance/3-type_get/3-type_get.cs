using System;
using System.Reflection;
using System.Collections.Generic;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo objType = myObj.GetType().GetTypeInfo();
        Console.WriteLine(objType.Name + " Properties:");

        IEnumerable<PropertyInfo> pList = objType.GetProperties();
        IEnumerable<MethodInfo> mList = objType.GetMethods();
           
        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine(objType.Name + " Methods:");

        foreach (MethodInfo p in mList)
        {
            Console.WriteLine(p.Name);
        }
    }
}

