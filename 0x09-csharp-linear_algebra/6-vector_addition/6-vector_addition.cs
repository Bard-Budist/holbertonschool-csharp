using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[0];
        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3) || (vector1.Length != vector2.Length))
        {
            result = Append(result, -1);
            return result;
        }

        for (int i = 0; i < vector1.Length; i++)
        {
            double sum = vector1[i] + vector2[i];
            result = Append(result, sum);
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

