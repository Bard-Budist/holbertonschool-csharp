using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string msg = "";
        int number_10 = number % 10;
        if (number_10 > 5)
        {
            msg = "and is greater than 5";
        } else if (number_10 < 6 && number_10 != 0)
        {
            msg = "and is less than 6 and not 0";
        } else {
            msg = "and is 0";
        }
        Console.WriteLine("The last digit of {0} is {1} {2}", number, number_10, msg);
    }
}