using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;

namespace lab3Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestSumFractions()
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(7, 9);
            var f3 = f1 + f2;
            Assert.AreEqual(f3.ToString(), "23/18");

            var f4 = new Fraction(3, 7);
            var f5 = new Fraction(5, 2);
            var f6 = f4 + f5;
            Assert.AreEqual(f6.ToString(), "41/14");
        }

        [TestMethod]
        public void TestSumPolynomials()
        {
            var p1 = new Polynomial(new[] { new Fraction(1, 2), new Fraction(3, 5), new Fraction(4, 7) });
            var p2 = new Polynomial(new[] { new Fraction(3, 5), new Fraction(2, 3), new Fraction(3, 7) });
            var p3 = p1 + p2;
            Assert.AreEqual(p3.ToString(), "11/10*x^0+19/15*x^1+49/49*x^2");

            var p4 = new Polynomial(new[] { new Fraction(1, 1), new Fraction(1, 2), new Fraction(4, 1) });
            var p5 = new Polynomial(new[] { new Fraction(1, 1), new Fraction(1, 3), new Fraction(2, 4) });
            var p6 = p4 + p5;
            Assert.AreEqual(p6.ToString(), "2/1*x^0+5/6*x^1+18/4*x^2");
        }
    }
}
