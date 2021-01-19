using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string number_str = "";
            for (var i = 0; i < 100; i++)
            {
                if (i < 99) {
                    number_str = ", ";
                } else {
                    number_str = "\n";
                }
                Console.Write("{0:00}{1}", i, number_str);
            }
        }
    }
}
