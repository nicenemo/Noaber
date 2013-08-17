using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    public partial class TupleSumTests
    {
        [TestMethod]
        public void ShortSumOnOneTuple()
        {
            Tuple<short> sut = new Tuple<short>(1);
            short expected = sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortSumOnTwoTuple()
        {
            Tuple<short, short> sut = new Tuple<short, short>(1, 2);
            short expected = sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortSumOnThreeTuple()
        {
            Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
            short expected = sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortSumOnFourTuple()
        {

            Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
            short expected = sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortSumOnFiveTuple()
        {

            Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
            short expected = sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortSumOnSixTuple()
        {

            Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
            short expected =sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortSumOnSevenTuple()
        {
            Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
            short expected = sut.AsEnumerable().Cast<short>().Sum();
            short actual = sut.Sum(x => (short)x);
            Assert.AreEqual(expected, actual);
        }

    }
}
