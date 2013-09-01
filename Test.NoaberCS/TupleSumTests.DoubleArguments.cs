using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    private readonly Func<object, double> nullFuncDouble = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnOneTupleFuncNull()
    {
      var sut = new Tuple<double>(1);
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnTwoTupleFuncNull()
    {
      var sut = new Tuple<double, double>(1, 2);
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnThreeTupleFuncNull()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnFourTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnFiveTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnSixTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Sum(nullFuncDouble);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleSumOnSevenTupleFuncNull()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      sut.Sum(nullFuncDouble);
    }
  }
}