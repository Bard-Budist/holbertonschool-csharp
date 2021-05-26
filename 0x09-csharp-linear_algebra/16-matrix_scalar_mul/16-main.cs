using System;

class Program
{

    public static void Main(string[] args)
    {
        double[,] matrix1 = { { -13, 10, 8 }, { 2, 0, 14 }, { -4, -5, 2 } };

        double[,] result = MatrixMath.MultiplyScalar(matrix1, 4);

        Console.WriteLine("{0}", result[0, 0]);
    }
}
