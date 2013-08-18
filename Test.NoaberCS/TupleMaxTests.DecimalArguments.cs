using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnOneTupleFuncNull()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      Func<object, decimal> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnTwoTupleFuncNull()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      Func<object, decimal> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnThreeTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      Func<object, decimal> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFourTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      Func<object, decimal> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnFiveTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      Func<object, decimal> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSixTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      Func<object, decimal> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Max(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMaxOnSevenTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      Func<object, decimal> func = null;
      sut.Max(func);
    }
  }
}
