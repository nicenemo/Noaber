using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleAverageTests
  {
    private readonly Func<object, double> nullFuncDouble = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnOneTupleFuncNull()
    {
      Tuple<double> sut = new Tuple<double>(1);
      Func<object, double> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnTwoTupleFuncNull()
    {
      Tuple<double, double> sut = new Tuple<double, double>(1, 2);
      Func<object, double> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnThreeTupleFuncNull()
    {
      Tuple<double, double, double> sut = new Tuple<double, double, double>(1, 2, 3);
      Func<object, double> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFourTupleFuncNull()
    {
      Tuple<double, double, double, double> sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      Func<object, double> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFiveTupleFuncNull()
    {
      Tuple<double, double, double, double, double> sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      Func<object, double> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSixTupleFuncNull()
    {
      Tuple<double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      Func<object, double> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSevenTupleFuncNull()
    {
      Tuple<double, double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      Func<object, double> func = null;
      sut.Average(func);
    }
  }
}
