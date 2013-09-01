using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    private readonly Func<object, short> nullFuncShort = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnOneTupleFuncNull()
    {
      var sut = new Tuple<short>(1);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnTwoTupleFuncNull()
    {
      var sut = new Tuple<short, short>(1, 2);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnThreeTupleFuncNull()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFourTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFiveTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSixTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSevenTupleFuncNull()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      sut.Average(nullFuncShort);
    }
  }
}