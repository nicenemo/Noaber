using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    private readonly Func<object, short> nullFuncShort = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnOneTupleFuncNull()
    {
      var sut = new Tuple<short>(1);

      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnTwoTupleFuncNull()
    {
      var sut = new Tuple<short, short>(1, 2);
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnThreeTupleFuncNull()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);

      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFourTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnFiveTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSixTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Sum(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortSumOnSevenTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      sut.Sum(nullFuncShort);
    }
  }
}