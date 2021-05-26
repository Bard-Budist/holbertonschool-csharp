using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        double total = 0;
        foreach (double value in vector)
        {
            total = total + Math.Pow(value, 2);
        }

        return Math.Round(Math.Sqrt(total), 2);
    }
}

