using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GeometricFigures.Tests
{
    [TestClass]
    public class GeometricFiguresTests
    {
        SquareCalc.GeometricFigures res = new SquareCalc.GeometricFigures();

        [TestMethod]
        public void Triangle_5_and_9_and_3_returnminus1()
        {
            double a = 5, b = 9, c = 3, expected = -1;
            double actual = res.Triangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Triangle_minus4_and_5_and_3_returnminus1()
        {
            double a = -4, b = 5, c = 3, expected = -1;
            double actual = res.Triangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Triangle_3_and_5_and_8_return0()
        {
            double a = 3, b = 5, c = 8, expected = 0;
            double actual = res.Triangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Triangle_6_and_10_and_8_return24()
        {
            double a = 6, b = 10, c = 8, expected = 24;
            double actual = res.Triangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Circle_10_return100pi()
        {
            double r = 10, expected = 100*Math.PI;
            double actual = res.Circle(r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Circle_minus3_returnminus1()
        {
            double r = -3, expected = -1;
            double actual = res.Circle(r);
            Assert.AreEqual(expected, actual);
        }
    }
}
