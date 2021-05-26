using System;

class Program
{

    public static void Main(string[] args)
    {
        double[] vector1 = {-4, 0, 10};
        double[] vector2 = {3, 7, -9};

        double result = VectorMath.DotProduct(vector1, vector2);

        Console.WriteLine("{0}", result);
    }
}
