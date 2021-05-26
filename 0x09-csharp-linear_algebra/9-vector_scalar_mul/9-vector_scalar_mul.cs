using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[0];

        if (vector.Length < 2 || vector.Length > 3)
        {
            result = Append(result, -1);
            return result;
        }

        foreach (double value in vector)
        {
            result = Append(result, value * scalar);
        }

        return result;
    }

    public static T[] Append<T>(T[] array, T item)
    {
        if (array == null) {
            return new T[] { item };
        }
        T[] result = new T[array.Length + 1];
        array.CopyTo(result, 0);
        result[array.Length] = item;
        return result;
    }
}

