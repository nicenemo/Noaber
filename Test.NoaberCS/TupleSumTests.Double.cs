using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    public partial class TupleSumTests
    {
        [TestMethod]
        public void DoubleSumOnTwoTuple()
        {
            Tuple<double, double> sut = new Tuple<double, double>(1, 2);
            double expected = sut.AsEnumerable().Cast<double>().Sum();
            double actual = sut.Sum(x => (double)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleSumOnThreeTuple()
        {
            Tuple<double, double, double> sut = new Tuple<double, double, double>(1, 2, 3);
            double expected = sut.AsEnumerable().Cast<double>().Sum();
            double actual = sut.Sum(x => (double)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleSumOnFourTuple()
        {

            Tuple<double, double, double, double> sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
            double expected = sut.AsEnumerable().Cast<double>().Sum();
            double actual = sut.Sum(x => (double)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleSumOnFiveTuple()
        {

            Tuple<double, double, double, double, double> sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
            double expected = sut.AsEnumerable().Cast<double>().Sum();
            double actual = sut.Sum(x => (double)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleSumOnSixTuple()
        {

            Tuple<double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
            double expected = sut.AsEnumerable().Cast<double>().Sum();
            double actual = sut.Sum(x => (double)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoubleSumOnSevenTuple()
        {
            Tuple<double, double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
            double expected = sut.AsEnumerable().Cast<double>().Sum();
            double actual = sut.Sum(x => (double)x);
            Assert.AreEqual(expected, actual);
        }

    }
}
