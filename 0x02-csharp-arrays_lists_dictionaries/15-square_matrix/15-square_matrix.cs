using System;

    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int[,] squareMatrix = new int[3,3];
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    int number = myMatrix[i, j];
                    squareMatrix[i, j] = number * number;
                }
            }
            return squareMatrix;
        }
    }

