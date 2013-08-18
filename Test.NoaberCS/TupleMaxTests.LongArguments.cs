using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    private readonly Func<object, long> nullFuncLong = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnOneTupleFuncNull()
    {
      Tuple<long> sut = new Tuple<long>(1);
      Func<object, long> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnTwoTupleFuncNull()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      Func<object, long> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnThreeTupleFuncNull()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      Func<object, long> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFourTupleFuncNull()
    {
      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      Func<object, long> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnFiveTupleFuncNull()
    {
      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      Func<object, long> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSixTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      Func<object, long> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Max(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMaxOnSevenTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      Func<object, long> func = null;
      sut.Max(func);
    }
  }
}
