using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleSumTests
  {
    private readonly Func<object, short> nullFuncShort = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnOneTupleFuncNull()
    {
      Tuple<short> sut = new Tuple<short>(1);
      Func<object, short> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnTwoTupleFuncNull()
    {
      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
      Func<object, short> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnThreeTupleFuncNull()
    {
      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
      Func<object, short> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFourTupleFuncNull()
    {
      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      Func<object, short> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFiveTupleFuncNull()
    {
      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      Func<object, short> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSixTupleFuncNull()
    {
      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      Func<object, short> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSevenTupleFuncNull()
    {
      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      Func<object, short> func = null;
      sut.Sum(func);
    }
  }
}
