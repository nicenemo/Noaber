using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    private readonly Func<object, double> nullFuncDouble = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnOneTupleFuncNull()
    {
      var sut = new Tuple<double>(1);
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnTwoTupleFuncNull()
    {
      var sut = new Tuple<double, double>(1, 2);
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnThreeTupleFuncNull()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFourTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnFiveTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSixTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Average(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleAverageOnSevenTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      sut.Average(nullFuncDouble);
    }
  }
}