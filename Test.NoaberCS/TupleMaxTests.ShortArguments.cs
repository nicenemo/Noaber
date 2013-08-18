using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    private readonly Func<object, short> nullFuncShort = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnOneTupleFuncNull()
    {
      Tuple<short> sut = new Tuple<short>(1);
      Func<object, short> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnTwoTupleFuncNull()
    {
      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
      Func<object, short> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnThreeTupleFuncNull()
    {
      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
      Func<object, short> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFourTupleFuncNull()
    {
      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      Func<object, short> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFiveTupleFuncNull()
    {
      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      Func<object, short> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSixTupleFuncNull()
    {
      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      Func<object, short> func = null;
      sut.Max(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSevenTupleFuncNull()
    {
      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      Func<object, short> func = null;
      sut.Max(func);
    }
  }
}
