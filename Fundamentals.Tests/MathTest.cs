using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Fundamentals.Tests
{
    [TestFixture]
    class MathTest
    {
        [TestCase(5, 4, 9)]
        [TestCase(-1, -3, -4)]
        public void Add_AandB_ReturnAddition(int a, int b, int expect)
        {
            var mathD = new MathD();

            var result = mathD.Add(a, b);

            Assert.That(result, Is.EqualTo(expect));
        }

        [TestCase(5, 3, 5)]
        [TestCase(5, 9, 9)]
        [TestCase(4, 4, 4)]
        public void Max_AisGreaterThanB_ReturnA(int a, int b, int expect)
        {
            var _math = new MathD();

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expect));
        }

        [TestCase(5, new[] { 1, 3, 5 })]
        [TestCase(9, new[] { 1, 3, 5, 7, 9})]
        public void GetOddNumbers_OddNumbers_ReturnOdd(int odd, int[] expect)
        {
            var _math = new MathD();

            var result = _math.GetOddNumbers(odd);

            Assert.That(result, Is.EquivalentTo(expect));
        }




    }
}
