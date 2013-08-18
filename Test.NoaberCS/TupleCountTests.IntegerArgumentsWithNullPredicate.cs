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
    public void IntegerCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnOneTupleFuncNullWithNullPredicate()
    {
      Tuple<int> sut = new Tuple<int>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnTwoTupleFuncNullWithNullPredicate()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnThreeTupleFuncNullWithNullPredicate()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFourTupleFuncNullWithNullPredicate()
    {
      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFiveTupleFuncNullWithNullPredicate()
    {
      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSixTupleFuncNullWithNullPredicate()
    {
      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSevenTupleFuncNullWithNullPredicate()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}