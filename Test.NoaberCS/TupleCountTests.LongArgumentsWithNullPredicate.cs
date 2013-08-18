using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnOneTupleFuncNullWithNullPredicate()
    {
      Tuple<long> sut = new Tuple<long>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long, long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnTwoTupleFuncNullWithNullPredicate()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long, long, long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnThreeTupleFuncNullWithNullPredicate()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnFourTupleFuncNullWithNullPredicate()
    {
      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnFiveTupleFuncNullWithNullPredicate()
    {
      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnSixTupleFuncNullWithNullPredicate()
    {
      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongCountOnSevenTupleFuncNullWithNullPredicate()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}