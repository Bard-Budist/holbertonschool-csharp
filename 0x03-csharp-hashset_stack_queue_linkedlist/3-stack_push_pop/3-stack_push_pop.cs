using System;
class MyStack
{
    public static System.Collections.Generic.Stack<string> Info(System.Collections.Generic.Stack<string> aStack, string newItem, string search)
    {
        int sizeStack = aStack.Count;
        bool containSearch = false;
        int indexSearch = 0;

        Console.WriteLine("Number of items: {0}", sizeStack);

        if (sizeStack == 0)
        {
            Console.WriteLine("Stack is empty");
        } else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }

        foreach (string item in aStack)
        {
            if (item == search)
            {
                containSearch = true;
                break;
            }
            indexSearch++;
        }

        Console.WriteLine("Stack contains \"{0}\": {1}", search, containSearch? "True": "False");

        if (containSearch)
        {
            for (var i = 0; i <= indexSearch; i++)
            {
                
                aStack.Pop();
                
                
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
