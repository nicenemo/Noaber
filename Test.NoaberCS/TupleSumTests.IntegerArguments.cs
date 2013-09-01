using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    private readonly Func<object, int> nullFuncInteger = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnOneTupleFuncNull()
    {
      var sut = new Tuple<int>(1);
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnTwoTupleFuncNull()
    {
      var sut = new Tuple<int, int>(1, 2);
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnThreeTupleFuncNull()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFourTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFiveTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSixTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSevenTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      sut.Sum(nullFuncInteger);
    }
  }
}