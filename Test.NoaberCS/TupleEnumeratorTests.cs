using System;
using System.Collections;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class TupleEnumertatorTests
    {

        #region "argumentnull test enumeration"
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test1TupleEnumeratorWithnull()
        {
            Tuple<int> t = null;
            t.GetEnumerator();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test2TupleEnumeratorWithnull()
        {
            Tuple<int, int> t = null;
            t.GetEnumerator();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test3TupleEnumeratorWithnull()
        {
            Tuple<int, int, int> t = null;
            t.GetEnumerator();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test4TupleEnumeratorWithnull()
        {
            Tuple<int, int, int, int> t = null;
            t.GetEnumerator();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test5TupleEnumeratorWithnull()
        {
            Tuple<int, int, int, int, int> t = null;
            t.GetEnumerator();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test6TupleEnumeratorWithnull()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.GetEnumerator();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test7TupleEnumeratorWithnull()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.GetEnumerator();
        }

        #endregion

        #region "DefaultValueThrowsOverflow initially"
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test1TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int> t = new Tuple<int>(1);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test2TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int, int> t = new Tuple<int, int>(1, 2);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test3TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int, int, int> t = new Tuple<int, int, int>(1, 2, 3);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test4TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(1, 2, 3, 4);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test5TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test6TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test7TupleEnumeratorShouldInitiallyThrowOutOfRangeException()
        {
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
            IEnumerator i = t.GetEnumerator();
            i.MoveNext();
            i.Reset();
            object v = i.Current;
        }
        #endregion

        #region "Tuple Iteration tests"
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test1TupleIteration()
        {
            Tuple<int> t = new Tuple<int>(-1);
            const int expected = -1;
            int actual = 0;

            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test2TupleIteration()
        {
            Tuple<int, int> t = new Tuple<int, int>(-1, -2);
            const int expected = -3;
            int actual = 0;
            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test3TupleIteration()
        {
            Tuple<int, int, int> t = new Tuple<int, int, int>(-1, -2, -3);
            const int expected = -6;
            int actual = 0;
            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test4TupleIteration()
        {
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
            const int expected = -7;
            int actual = 0;
            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test5TupleIteration()
        {
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
            const int expected = -14;
            int actual = 0;
            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test6TupleIteration()
        {
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(-1, 2, -3, -4, -5, -6);
            const int expected = -21;
            int actual = 0;
            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test7TupleIteration()
        {
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
            const int expected = -28;
            int actual = 0;
            foreach (int v in t.AsEnumerable())
            {
                actual += v;
            }
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region "ItemNullTests"
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullOneTupleShouldThrowException()
        {
            Tuple<int> t = null;
            t.Item(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullTwoTupleShouldThrowException()
        {
            Tuple<int, int> t = null;
            t.Item(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullThreeTupleShouldThrowException()
        {
            Tuple<int, int, int> t = null;
            t.Item(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullFourTupleShouldThrowException()
        {
            Tuple<int, int, int, int> t = null;
            t.Item(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullFiveTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int> t = null;
            t.Item(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullSixTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int> t = null;
            t.Item(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ItemOnNullSevenTupleShouldThrowException()
        {
            Tuple<int, int, int, int, int, int, int> t = null;
            t.Item(0);
        }
        #endregion

        #region "ItemTests"
        [TestMethod()]
        public void ItemOnOneTuple()
        {
            Tuple<int> t = new Tuple<int>(-1);
            Assert.AreEqual(t.Item1, t.Item(0));
        }

        [TestMethod()]
        public void ItemOnTwoTuple()
        {
            Tuple<int, int> t = new Tuple<int, int>(-1, -2);
            Assert.AreEqual(t.Item1, t.Item(0));
            Assert.AreEqual(t.Item2, t.Item(1));
        }

        [TestMethod()]
        public void ItemOnThreeTuple()
        {
            Tuple<int, int, int> t = new Tuple<int, int, int>(-1, -2, -3);
            Assert.AreEqual(t.Item1, t.Item(0));
            Assert.AreEqual(t.Item2, t.Item(1));
            Assert.AreEqual(t.Item3, t.Item(2));
        }

        [TestMethod()]
        public void ItemOnFourTuple()
        {
            Tuple<int, int, int, int> t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
            Assert.AreEqual(t.Item1, t.Item(0));
            Assert.AreEqual(t.Item2, t.Item(1));
            Assert.AreEqual(t.Item3, t.Item(2));
            Assert.AreEqual(t.Item4, t.Item(3));
        }

        [TestMethod()]
        public void ItemOnFiveTuple()
        {
            Tuple<int, int, int, int, int> t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
            Assert.AreEqual(t.Item1, t.Item(0));
            Assert.AreEqual(t.Item2, t.Item(1));
            Assert.AreEqual(t.Item3, t.Item(2));
            Assert.AreEqual(t.Item4, t.Item(3));
            Assert.AreEqual(t.Item5, t.Item(4));
        }

        [TestMethod()]
        public void ItemOnSixTuple()
        {
            Tuple<int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
            Assert.AreEqual(t.Item1, t.Item(0));
            Assert.AreEqual(t.Item2, t.Item(1));
            Assert.AreEqual(t.Item3, t.Item(2));
            Assert.AreEqual(t.Item4, t.Item(3));
            Assert.AreEqual(t.Item5, t.Item(4));
            Assert.AreEqual(t.Item6, t.Item(5));
        }

        [TestMethod()]
        public void ItemOnSevenTuple()
        {
            Tuple<int, int, int, int, int, int, int> t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
            Assert.AreEqual(t.Item1, t.Item(0));
            Assert.AreEqual(t.Item2, t.Item(1));
            Assert.AreEqual(t.Item3, t.Item(2));
            Assert.AreEqual(t.Item4, t.Item(3));
            Assert.AreEqual(t.Item5, t.Item(4));
            Assert.AreEqual(t.Item6, t.Item(5));
            Assert.AreEqual(t.Item7, t.Item(6));
        }
        #endregion
    }
}