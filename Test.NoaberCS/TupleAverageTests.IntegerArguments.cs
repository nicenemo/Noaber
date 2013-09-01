using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    private readonly Func<object, int> nullFuncInteger = null;

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnOneTupleFuncNull()
    {
      var sut = new Tuple<int>(1);
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnTwoTupleFuncNull()
    {
      var sut = new Tuple<int, int>(1, 2);
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnThreeTupleFuncNull()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFourTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFiveTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSixTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSevenTupleFuncNull()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      sut.Average(nullFuncInteger);
    }
  }
}