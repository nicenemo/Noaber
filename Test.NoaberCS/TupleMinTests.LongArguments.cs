using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    private readonly Func<object, long> nullFuncLong = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnOneTupleFuncNull()
    {
      var sut = new Tuple<long>(1);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnTwoTupleFuncNull()
    {
      var sut = new Tuple<long, long>(1, 2);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnThreeTupleFuncNull()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFourTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFiveTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSixTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSevenTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      sut.Min(nullFuncLong);
    }
  }
}