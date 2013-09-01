using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    [TestMethod]
    public void ShortAverageOnOneTuple()
    {
      var sut = new Tuple<short>(1);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortAverageOnTwoTuple()
    {
      var sut = new Tuple<short, short>(1, 2);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortAverageOnThreeTuple()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortAverageOnFourTuple()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortAverageOnFiveTuple()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortAverageOnSixTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortAverageOnSevenTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<short>().Average();
      double actual = sut.Average(x => (short) x);
      Assert.AreEqual(expected, actual);
    }
  }
}