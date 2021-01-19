using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = "";
            for (var i = 1; i < 101; i++)
            {
                if (i < 100){
                    delimiter = " ";
                } else {
                    delimiter = "";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz{0}", delimiter);
                } else if (i % 3 == 0)
                {
                    Console.Write("Fizz{0}", delimiter);
                } else if (i % 5 == 0)
                {
                    Console.Write("Buzz{0}", delimiter);
                } else {
                    Console.Write("{0}{1}", i, delimiter);
                }
                
            }
        }
    }
}
