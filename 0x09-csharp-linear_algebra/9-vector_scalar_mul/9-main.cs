using System;

class Program
{

    public static void Main(string[] args)
    {
        double[] vector1 = {98, 972};
        double[] vector2 = {-3, 23, 50};

        double[] result = VectorMath.Multiply(vector1, 0.5);

        Console.WriteLine("{0}", result[0]);
        Console.WriteLine("{0}", result[1]);
    }
}
