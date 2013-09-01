using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnOneTupleFuncNull()
    {
      var sut = new Tuple<decimal>(1);
      sut.Min(nullFuncDecimal);
      ;
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnTwoTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      sut.Min(nullFuncDecimal);
      ;
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnThreeTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      sut.Min(nullFuncDecimal);
      ;
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFourTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      sut.Min(nullFuncDecimal);
      ;
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFiveTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      sut.Min(nullFuncDecimal);
      ;
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSixTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      sut.Min(nullFuncDecimal);
      ;
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSevenTupleFuncNull()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      sut.Min(nullFuncDecimal);
      ;
    }
  }
}