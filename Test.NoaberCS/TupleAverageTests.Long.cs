using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleAverageTests
  {
    [TestMethod]
    public void LongAverageOnOneTuple()
    {
      Tuple<long> sut = new Tuple<long>(1);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void LongAverageOnTwoTuple()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnThreeTuple()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnFourTuple()
    {

      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnFiveTuple()
    {

      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnSixTuple()
    {

      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongAverageOnSevenTuple()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<long>().Average();
      double actual = sut.Average(x => (long)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
