using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    public partial class TupleSumTests
    {
        [TestMethod]
        public void LongSumOnTwoTuple()
        {
            Tuple<long, long> sut = new Tuple<long, long>(1, 2);
            long expected = sut.AsEnumerable().Cast<long>().Sum();
            long actual = sut.Sum(x => (long)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongSumOnThreeTuple()
        {
            Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
            long expected = sut.AsEnumerable().Cast<long>().Sum();
            long actual = sut.Sum(x => (long)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongSumOnFourTuple()
        {

            Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
            long expected = sut.AsEnumerable().Cast<long>().Sum();
            long actual = sut.Sum(x => (long)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongSumOnFiveTuple()
        {

            Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
            long expected = sut.AsEnumerable().Cast<long>().Sum();
            long actual = sut.Sum(x => (long)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongSumOnSixTuple()
        {

            Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
            long expected = sut.AsEnumerable().Cast<long>().Sum();
            long actual = sut.Sum(x => (long)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongSumOnSevenTuple()
        {
            Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
            long expected = sut.AsEnumerable().Cast<long>().Sum();
            long actual = sut.Sum(x => (long)x);
            Assert.AreEqual(expected, actual);
        }

    }
}
