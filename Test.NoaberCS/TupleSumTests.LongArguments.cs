using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    private readonly Func<object, long> nullFuncLong = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnOneTupleFuncNull()
    {
      var sut = new Tuple<long>(1);
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnTwoTupleFuncNull()
    {
      var sut = new Tuple<long, long>(1, 2);
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnThreeTupleFuncNull()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFourTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFiveTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSixTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSevenTupleFuncNull()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      sut.Sum(nullFuncLong);
    }
  }
}