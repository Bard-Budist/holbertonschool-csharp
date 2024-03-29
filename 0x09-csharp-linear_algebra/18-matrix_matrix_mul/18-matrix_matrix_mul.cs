﻿using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[matrix2.GetLength(1), matrix2.GetLength(0)];
        double[,] error = new double[,] { { -1 } };

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return error;
        }
        
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}

