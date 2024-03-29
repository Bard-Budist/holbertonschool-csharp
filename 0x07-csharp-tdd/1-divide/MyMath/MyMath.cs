﻿using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {

            if (matrix == null)
            {
                return null;
            }

            try
            {
                int[,] newMatrix =  new int[matrix.GetLength(0), matrix.GetLength(1)];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] =  matrix[i, j] / num;
                    }
                }
                return newMatrix;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
