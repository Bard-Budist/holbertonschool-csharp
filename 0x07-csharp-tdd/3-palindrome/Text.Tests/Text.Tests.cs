using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class PalimdromeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string test = "A mi loca Colima";
            Assert.That(Text.Str.IsPalindrome(test), Is.True);
        }

        [Test]
        public void Test2()
        {
            string test = "A mi loca Colimaaaa";
            Assert.That(Text.Str.IsPalindrome(test), Is.False);
        }
    }
}