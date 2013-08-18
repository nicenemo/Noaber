using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnOneTupleFuncNull()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      Func<object, decimal> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnTwoTupleFuncNull()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      Func<object, decimal> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnThreeTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      Func<object, decimal> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFourTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      Func<object, decimal> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnFiveTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      Func<object, decimal> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSixTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      Func<object, decimal> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Min(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalMinOnSevenTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      Func<object, decimal> func = null;
      sut.Min(func);
    }
  }
}
