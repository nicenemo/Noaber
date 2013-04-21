using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass()]
    public class TupleLengthTests
    {
        #region "Length"

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullOneTupleShouldThrowException()
        {
            Tuple<int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnOneTuple()
        {
            const int expected = 1;
            Tuple<int> t = new Tuple<int>(-1);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullTwoTupleShouldThrowException()
        {
            Tuple<int, int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnTwoTuple()
        {
            const int expected = 2;
            Tuple<int, int> t = new Tuple<int, int>(-1, -2);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullThreeTupleShouldThrowException()
        {
            Tuple<int, int, int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnThreeTuple()
        {
            const int expected = 3;
            Tuple<int, int, int> t = new Tuple<int, int, int>(-1, -2, -3);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullFourTupleShouldThrowException()
        {
            Tuple<int, int, int, int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnFourTuple()
        {
            const int expected = 4;
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullFiveTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnFiveTuple()
        {
            const int expected = 5;
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullSixTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnSixTuple()
        {
            const int expected = 6;
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LengthOnNullSevenTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.Length();
        }

        [TestMethod()]
        public void LengthOnSevenTuple()
        {
            const int expected = 7;
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
            int actual = t.Length();
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region "LongLength"

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullOneTupleShouldThrowException()
        {
            Tuple<int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnOneTuple()
        {
            const long expected = 1;
            Tuple<int> t = new Tuple<int>(-1);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullTwoTupleShouldThrowException()
        {
            Tuple<int, int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnTwoTuple()
        {
            const long expected = 2;
            Tuple<int, int> t = new Tuple<int, int>(-1, -2);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullThreeTupleShouldThrowException()
        {
            Tuple<int, int, int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnThreeTuple()
        {
            const long expected = 3;
            Tuple<int, int, int> t = new Tuple<int, int, int>(-1, -2, -3);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullFourTupleShouldThrowException()
        {
            Tuple<int, int, int, int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnFourTuple()
        {
            const long expected = 4;
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullFiveTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnFiveTuple()
        {
            const long expected = 5;
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullSixTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnSixTuple()
        {
            const long expected = 6;
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LongLengthOnNullSevenTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.LongLength();
        }

        [TestMethod()]
        public void LongLengthOnSevenTuple()
        {
            const long expected = 7;
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
            long actual = t.LongLength();
            Assert.AreEqual(expected, actual);
        }
        #endregion
        #region "Count"

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullOneTupleShouldThrowException()
        {
            Tuple<int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnOneTuple()
        {
            const int expected = 1;
            Tuple<int> t = new Tuple<int>(-1);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullTwoTupleShouldThrowException()
        {
            Tuple<int, int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnTwoTuple()
        {
            const int expected = 2;
            Tuple<int, int> t = new Tuple<int, int>(-1, -2);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullThreeTupleShouldThrowException()
        {
            Tuple<int, int, int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnThreeTuple()
        {
            const int expected = 3;
            Tuple<int, int, int> t = new Tuple<int, int, int>(-1, -2, -3);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullFourTupleShouldThrowException()
        {
            Tuple<int, int, int, int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnFourTuple()
        {
            const int expected = 4;
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullFiveTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnFiveTuple()
        {
            const int expected = 5;
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullSixTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnSixTuple()
        {
            const int expected = 6;
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOnNullSevenTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.Count();
        }

        [TestMethod()]
        public void CountOnSevenTuple()
        {
            const int expected = 7;
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
            int actual = t.Count();
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
