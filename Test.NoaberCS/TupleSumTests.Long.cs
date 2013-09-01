using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    [TestMethod]
    public void LongSumOnOneTuple()
    {
      var sut = new Tuple<long>(1);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongSumOnTwoTuple()
    {
      var sut = new Tuple<long, long>(1, 2);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongSumOnThreeTuple()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongSumOnFourTuple()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongSumOnFiveTuple()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongSumOnSixTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongSumOnSevenTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      long expected = sut.AsEnumerable().Cast<long>().Sum();
      long actual = sut.Sum(x => (long) x);
      Assert.AreEqual(expected, actual);
    }
  }
}