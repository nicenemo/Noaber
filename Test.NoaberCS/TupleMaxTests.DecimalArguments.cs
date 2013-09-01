using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnOneTupleFuncNull()
    {
      var sut = new Tuple<decimal>(1);
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnTwoTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnThreeTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFourTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFiveTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSixTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSevenTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      sut.Max(nullFuncDecimal);
    }
  }
}