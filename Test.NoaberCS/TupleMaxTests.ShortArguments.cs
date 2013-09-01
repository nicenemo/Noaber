using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    private readonly Func<object, short> nullFuncShort = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnOneTupleFuncNull()
    {
      var sut = new Tuple<short>(1);
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnTwoTupleFuncNull()
    {
      var sut = new Tuple<short, short>(1, 2);
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnThreeTupleFuncNull()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFourTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnFiveTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSixTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);

      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Max(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortMaxOnSevenTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      sut.Max(nullFuncShort);
    }
  }
}