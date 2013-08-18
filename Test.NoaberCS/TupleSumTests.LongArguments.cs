using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleSumTests
  {
    private readonly Func<object, long> nullFuncLong = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnOneTupleFuncNull()
    {
      Tuple<long> sut = new Tuple<long>(1);
      Func<object, long> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnTwoTupleFuncNull()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      Func<object, long> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnThreeTupleFuncNull()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      Func<object, long> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFourTupleFuncNull()
    {
      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      Func<object, long> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnFiveTupleFuncNull()
    {
      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      Func<object, long> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSixTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      Func<object, long> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Sum(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongSumOnSevenTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      Func<object, long> func = null;
      sut.Sum(func);
    }
  }
}
