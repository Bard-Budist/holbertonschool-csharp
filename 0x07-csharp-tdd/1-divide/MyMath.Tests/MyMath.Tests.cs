using NUnit.Framework;

namespace MyMath.Tests
{
    public class MatrixTest
    {
        [Test]
        public void Test1()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            int number = 2;
            int[,] resultMatrix = Matrix.Divide(matrix, number);
            Assert.AreEqual(resultMatrix[1, 0], 2);
        }

        [Test]
        public void Test2()
        {
            int[,] matrix = null;
            int number = 2;
            int[,] resultMatrix = Matrix.Divide(matrix, number);
            Assert.IsNull(resultMatrix);
        }


        [Test]
        public void Test3()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            int number = 0;
            int[,] resultMatrix = Matrix.Divide(matrix, number);
            Assert.IsNull(resultMatrix);
        }
    }
}