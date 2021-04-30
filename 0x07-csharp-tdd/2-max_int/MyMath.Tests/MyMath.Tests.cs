using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class MaxTest
    {
        [Test]
        public void Test1()
        {
            List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 9};
            int max = Operations.Max(numbers);
            Assert.AreEqual(max, 9);
        }

        [Test]
        public void Test2()
        {
            List<int> numbers = new List<int>();
            int max = Operations.Max(numbers);
            Assert.AreEqual(max, 0);
        }
    }
}