using System;

class Program
{
    public static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, 3 }, { -1, 0 } };
        double[,] matrix2 = { { 1, 7 }, { -8, -2 } };

        double[,] result = MatrixMath.Multiply(matrix1, matrix2);

        Console.WriteLine("[{0}]", string.Join(", ", result));
    }
}
