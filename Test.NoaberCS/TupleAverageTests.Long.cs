using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    [TestMethod]
    public void LongAverageOnOneTuple()
    {
      var sut = new Tuple<long>(1);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnTwoTuple()
    {
      var sut = new Tuple<long, long>(1, 2);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnThreeTuple()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnFourTuple()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnFiveTuple()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnSixTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnSevenTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long) x);
      Assert.AreEqual(expected, actual);
    }
  }
}