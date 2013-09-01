using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    private readonly Func<object, double> nullFuncDouble = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnOneTupleFuncNull()
    {
      var sut = new Tuple<double>(1);
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnTwoTupleFuncNull()
    {
      var sut = new Tuple<double, double>(1, 2);
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnThreeTupleFuncNull()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnFourTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnFiveTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnSixTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Max(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleMaxOnSevenTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      sut.Max(nullFuncDouble);
    }
  }
}