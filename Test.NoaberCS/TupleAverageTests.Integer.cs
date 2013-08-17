using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleAverageTests
  {
    [TestMethod]
    public void IntegerAverageOnOneTuple()
    {
      Tuple<int> sut = new Tuple<int>(1);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void IntegerAverageOnTwoTuple()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerAverageOnThreeTuple()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerAverageOnFourTuple()
    {

      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerAverageOnFiveTuple()
    {

      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerAverageOnSixTuple()
    {

      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerAverageOnSevenTuple()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<int>().Average();
      double actual = sut.Average(x => (int)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
