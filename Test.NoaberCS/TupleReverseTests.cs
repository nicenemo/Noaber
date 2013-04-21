using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass()]
    public class TupleReverseTests
    {
        #region "Reverse Tests"

        [TestMethod()]
        public void ReverseOneTuple()
        {
            Tuple<int> expected = new Tuple<int>(42);
            Tuple<int> t = new Tuple<int>(42);
            Tuple<int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullOneTupleShouldThrowException()
        {
            Tuple<int> t = null;
            t.Reverse();
        }


        [TestMethod()]
        public void ReverseTwoTuple()
        {
            Tuple<int, int> expected = new Tuple<int, int>(1, 42);
            Tuple<int, int> t = new Tuple<int, int>(42, 1);
            Tuple<int, int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullTwoTupleShouldThrowException()
        {
            Tuple<int, int> t = null;
            t.Reverse();
        }

        [TestMethod()]
        public void ReverseOnThreeTuple()
        {
            Tuple<int, int, int> expected = new Tuple<int, int, int>(1, 1, 42);
            Tuple<int, int, int> t = new Tuple<int, int, int>(42, 1, 1);
            Tuple<int, int, int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullThreeTupleShouldThrowException()
        {
            Tuple<int, int, int> t = null;
            t.Reverse();
        }

        [TestMethod()]
        public void ReverseOnFourTuple()
        {
            Tuple<int, int, int, int> expected = new Tuple<int, int, int, int>(1, 1, 1, 42);
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(42, 1, 1, 1);
            Tuple<int, int, int, int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullFourTupleShouldThrowException()
        {
            Tuple<int, int, int, int> t = null;
            t.Reverse();
        }

        [TestMethod()]
        public void ReverseOnFiveTuple()
        {
            Tuple<int, int, int, int, int> expected = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 42);
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
            Tuple<int, int, int, int, int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullFiveTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int> t = null;
            t.Reverse();
        }

        [TestMethod()]
        public void ReverseOnSixTuple()
        {
            Tuple<int, int, int, int, int, int> expected = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 42);
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
            Tuple<int, int, int, int, int, int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullSixTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.Reverse();
        }
        [TestMethod()]
        public void ReverseOnSevenTuple()
        {
            Tuple<int, int, int, int, int, int, int> expected = new Tuple<int, int, int, int, int, int, int>(1, 1, 1, 1, 1, 1, 42);
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(42, 1, 1, 1, 1, 1, 1);
            Tuple<int, int, int, int, int, int, int> actual = t.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWithNullSevenTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.Reverse();
        }
        #endregion
    }
}