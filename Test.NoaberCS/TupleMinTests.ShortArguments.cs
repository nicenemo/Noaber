using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    private readonly Func<object, short> nullFuncShort = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnOneTupleFuncNull()
    {
      var sut = new Tuple<short>(1);
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnTwoTupleFuncNull()
    {
      var sut = new Tuple<short, short>(1, 2);
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnThreeTupleFuncNull()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnFourTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnFiveTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnSixTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Min(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMinOnSevenTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      sut.Min(nullFuncShort);
    }
  }
}