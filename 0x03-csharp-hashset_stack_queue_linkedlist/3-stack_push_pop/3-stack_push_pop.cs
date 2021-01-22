using System;
class MyStack
{
    public static System.Collections.Generic.Stack<string> Info(System.Collections.Generic.Stack<string> aStack, string newItem, string search)
    {
        int sizeStack = aStack.Count;
        bool containSearch = false;

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
            }
        }

        Console.WriteLine("Stack contains \"{0}\": {1}", search, containSearch? "True": "False");

        if (containSearch)
        {
            for (var i = 0; i < sizeStack; i++)
            {
                if (aStack.Peek() != search)
                {
                    aStack.Pop();
                } else
                {
                    aStack.Pop();
                    break;
                }
                
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
