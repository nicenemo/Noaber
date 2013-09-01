using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnOneTupleFuncNull()
    {
      var sut = new Tuple<decimal>(1);
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnTwoTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnThreeTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFourTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFiveTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSixTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSevenTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      sut.Sum(nullFuncDecimal);
    }
  }
}