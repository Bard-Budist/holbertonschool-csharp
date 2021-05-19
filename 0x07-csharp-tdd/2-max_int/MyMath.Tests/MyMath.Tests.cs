using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class MaxTest
    {
        [Test]
        public void Test1()
        {
            List<int> numbers = new List<int>() {500, 2, 3, -100, 5, 6, 7, 20, -727};
            int max = Operations.Max(numbers);
            Assert.That(max, Is.EqualTo(500));
        }

        [Test]
        public void Test2()
        {
            List<int> numbers = new List<int>();
            int max = Operations.Max(numbers);
            Assert.That(max, Is.EqualTo(0));
        }
    }
}