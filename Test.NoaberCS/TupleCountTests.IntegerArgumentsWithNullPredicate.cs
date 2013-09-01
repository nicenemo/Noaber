using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnOneTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnTwoTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int, int>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnThreeTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFourTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFiveTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSixTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSevenTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}