using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    [TestMethod]
    public void LongMaxOnOneTuple()
    {
      Tuple<long> sut = new Tuple<long>(1);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void LongMaxOnTwoTuple()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnThreeTuple()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnFourTuple()
    {

      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnFiveTuple()
    {

      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnSixTuple()
    {

      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongMaxOnSevenTuple()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      long expected = sut.AsEnumerable().Cast<long>().Max();
      long actual = sut.Max(x => (long)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
