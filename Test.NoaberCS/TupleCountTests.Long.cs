using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleCountTests
  {
    [TestMethod]
    public void LongCountOnOneTuple()
    {
      Tuple<long> sut = new Tuple<long>(1);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void LongCountOnTwoTuple()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnThreeTuple()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnFourTuple()
    {
      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnFiveTuple()
    {

      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnSixTuple()
    {

      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongCountOnSevenTuple()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<long>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}
