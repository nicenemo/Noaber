using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnOneTupleFuncNull()
    {
      var sut = new Tuple<decimal>(1);
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnTwoTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnThreeTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFourTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFiveTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSixTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSevenTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      sut.Average(nullFuncDecimal);
    }
  }
}