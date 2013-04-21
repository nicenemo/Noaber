using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass()]
    public class TupleTailTests
    {
        #region "Tail Tests with null"

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TailOnNullTwoTupleThrowsArgumentNullException()
        {
            Tuple<int, int> t = null;
            t.Tail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TailOnNullThreeTupleThrowsArgumentNullException()
        {
            Tuple<int, int, int> t = null;
            t.Tail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TailOnNullFourTupleThrowsArgumentNullException()
        {
            Tuple<int, int, int, int> t = null;
            t.Tail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TailOnNullFiveTupleThrowsArgumentNullException()
        {
            Tuple<int, int, int, int, int> t = null;
            t.Tail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TailOnNullOneSixTupleThrowsArgumentNullException()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.Tail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TailOnNullSevenTupleThrowsArgumentNullException()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.Tail();
        }
        #endregion

        #region "Tail Tests"

        [TestMethod()]
        public void TailTwoTuple()
        {
            Tuple<int> expected = new Tuple<int>(1);
            Tuple<int, int> t = new Tuple<int, int>(42, 1);
            Tuple<int> actual = t.Tail();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TailOnThreeTuple()
        {
            Tuple<int, int> expected = new Tuple<int, int>(1, 1);
            Tuple<int, int, int> t = new Tuple<int, int, int>(42, 1, 1);
            Tuple<int, int> actual = t.Tail();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TailOnFourTuple()
        {
            Tuple<int, int, int> expected = new Tuple<int, int, int>(1, 1, 1);
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(42, 1, 1, 1);
            Tuple<int, int, int> actual = t.Tail();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TailOnFiveTuple()
        {
            Tuple<int, int, int, int> expected = new Tuple<int, int, int, int>(1, 1, 1, 1);
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
            Tuple<int, int, int, int> actual = t.Tail();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TailOnSixTuple()
        {
            Tuple<int, int, int, int, int> expected = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 1);
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
            Tuple<int, int, int, int, int> actual = t.Tail();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TailOnSevenTuple()
        {
            Tuple<int, int, int, int, int, int> expected = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 1);
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(42, 1, 1, 1, 1, 1, 1);
            Tuple<int, int, int, int, int, int> actual = t.Tail();
            Assert.AreEqual(expected, actual);
        }
        #endregion


    }
}