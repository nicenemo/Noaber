using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    private readonly Func<object, long> nullFuncLong = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnOneTupleFuncNull()
    {
      var sut = new Tuple<long>(1);
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnTwoTupleFuncNull()
    {
      var sut = new Tuple<long, long>(1, 2);
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnThreeTupleFuncNull()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFourTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFiveTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSixTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSevenTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      sut.Max(nullFuncLong);
    }
  }
}