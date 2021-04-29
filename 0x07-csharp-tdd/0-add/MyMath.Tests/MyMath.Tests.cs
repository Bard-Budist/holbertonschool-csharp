using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        { 
        }

        [Test]
        public void Test()
        {
            var result = MyMath.Operations.Add(1, 2);
            Assert.AreEqual(result, 3);
        }
    }
}