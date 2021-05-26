using System;

class Program
{

    public static void Main(string[] args)
    {
        double[] vector1 = {14, -2, 0};
        double[] vector2 = {-3, 23, 50};

        double[] result = VectorMath.Add(vector1, vector2);

        Console.WriteLine("{0}", result[0]);
        Console.WriteLine("{0}", result[1]);
        Console.WriteLine("{0}", result[2]);
    }
}
