using System;

class Program
{
    static void Main(string[] args)
    {
        string end = "";
        for (var i = 0; i < 5; i++)
        {
            for (var j = 0; j < 5; j++)
            {
                if (j < 4) {
                    end = " ";
                } else
                {
                    end = "\n";
                }
                if (j == 2 && i == 2) {
                    Console.Write("1{0}", end);
                } else
                {
                    Console.Write("0{0}", end);
                }
                
            }
            
        }
    }
}

