using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    [TestMethod]
    public void LongMinOnOneTuple()
    {
      var sut = new Tuple<long>(1);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnTwoTuple()
    {
      var sut = new Tuple<long, long>(1, 2);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnThreeTuple()
    {
      var sut = new Tuple<long, long, long>(1, 2, 3);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnFourTuple()
    {
      var sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnFiveTuple()
    {
      var sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnSixTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnSevenTuple()
    {
      var sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long) x);
      Assert.AreEqual(expected, actual);
    }
  }
}