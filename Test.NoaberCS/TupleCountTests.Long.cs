using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [TestMethod]
    public void LongCountOnOneTuple()
    {
      var sut = new Tuple<long>(1);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnTwoTuple()
    {
      var sut = new Tuple<long, long>(1, 2);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnThreeTuple()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnFourTuple()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnFiveTuple()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnSixTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnSevenTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}