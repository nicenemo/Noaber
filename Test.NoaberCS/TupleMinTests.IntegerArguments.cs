using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    private readonly Func<object, int> nullFuncInteger = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnOneTupleFuncNull()
    {
      var sut = new Tuple<int>(1);
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnTwoTupleFuncNull()
    {
      var sut = new Tuple<int, int>(1, 2);
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnThreeTupleFuncNull()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnFourTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnFiveTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnSixTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Min(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerMinOnSevenTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      sut.Min(nullFuncInteger);
    }
  }
}