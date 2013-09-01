using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    [TestMethod]
    public void LongMaxOnOneTuple()
    {
      var sut = new Tuple<long>(1);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnTwoTuple()
    {
      var sut = new Tuple<long, long>(1, 2);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnThreeTuple()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnFourTuple()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnFiveTuple()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnSixTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnSevenTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long) x);
      Assert.AreEqual(expected, actual);
    }
  }
}