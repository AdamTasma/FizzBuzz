using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzTest
    {
        [Test]
        public void EnterOne()
        {
            string expected = "1";
            string actual = Program.FizzBuzzMethod("1");
            Assert.AreEqual(expected, actual, "1 should return 1");
        }
        [Test]
        public void EnterThree() {
            string expected = "Fizz";
            string actual = Program.FizzBuzzMethod("3");
            Assert.AreEqual(expected, actual, "3 should return Fizz");
        }
        [Test]
        public void EnterTen() {
            string expected = "Buzz";
            string actual = Program.FizzBuzzMethod("10");
            Assert.AreEqual(expected, actual, "10 should return Buzz");
        }
        [Test]
        public void EnterThirty() { 
            string expected = "FizzBuzz";
            string actual = Program.FizzBuzzMethod("30");
            Assert.AreEqual(expected, actual, "30 should return FizzBuzz");
        }

    }
}
