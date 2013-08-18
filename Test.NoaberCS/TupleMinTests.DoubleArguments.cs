using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    private readonly Func<object, double> nullFuncDouble = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnOneTupleFuncNull()
    {
      Tuple<double> sut = new Tuple<double>(1);
      Func<object, double> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnTwoTupleFuncNull()
    {
      Tuple<double, double> sut = new Tuple<double, double>(1, 2);
      Func<object, double> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnThreeTupleFuncNull()
    {
      Tuple<double, double, double> sut = new Tuple<double, double, double>(1, 2, 3);
      Func<object, double> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFourTupleFuncNull()
    {
      Tuple<double, double, double, double> sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      Func<object, double> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFiveTupleFuncNull()
    {
      Tuple<double, double, double, double, double> sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      Func<object, double> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSixTupleFuncNull()
    {
      Tuple<double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      Func<object, double> func = null;
      sut.Min(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSevenTupleFuncNull()
    {
      Tuple<double, double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      Func<object, double> func = null;
      sut.Min(func);
    }
  }
}
