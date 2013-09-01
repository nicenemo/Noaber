using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    private readonly Func<object, double> nullFuncDouble = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnOneTupleFuncNull()
    {
      var sut = new Tuple<double>(1);
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnTwoTupleFuncNull()
    {
      var sut = new Tuple<double, double>(1, 2);
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnThreeTupleFuncNull()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFourTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnFiveTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSixTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Min(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMinOnSevenTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      sut.Min(nullFuncDouble);
    }
  }
}