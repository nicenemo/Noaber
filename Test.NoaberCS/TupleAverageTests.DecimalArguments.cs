using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleAverageTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnOneTupleFuncNull()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      Func<object, decimal> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnTwoTupleFuncNull()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      Func<object, decimal> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnThreeTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      Func<object, decimal> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFourTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      Func<object, decimal> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnFiveTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      Func<object, decimal> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSixTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      Func<object, decimal> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Average(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalAverageOnSevenTupleFuncNull()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      Func<object, decimal> func = null;
      sut.Average(func);
    }
  }
}
