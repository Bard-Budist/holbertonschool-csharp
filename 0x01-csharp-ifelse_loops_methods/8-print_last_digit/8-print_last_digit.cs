using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int number_return = 0;
        if (number > 0)
        {
            number_return = number % 10;
        } else {
            number_return = (number * -1) % 10;
        }
        Console.Write("{0}", number_return);
        return number_return;
    }
}
