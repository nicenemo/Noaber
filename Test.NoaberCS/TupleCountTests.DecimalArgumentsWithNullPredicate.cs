using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnOneTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnTwoTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnThreeTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFourTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFiveTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSixTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSevenTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}