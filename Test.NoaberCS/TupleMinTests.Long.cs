using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    [TestMethod]
    public void LongMinOnOneTuple()
    {
      Tuple<long> sut = new Tuple<long>(1);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void LongMinOnTwoTuple()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnThreeTuple()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnFourTuple()
    {

      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnFiveTuple()
    {

      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnSixTuple()
    {

      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMinOnSevenTuple()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      long expected = sut.AsEnumerable().Cast<long>().Min();
      long actual = sut.Min(x => (long)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
