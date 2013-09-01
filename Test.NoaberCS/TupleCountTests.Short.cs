using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [TestMethod]
    public void ShortCountOnOneTuple()
    {
      var sut = new Tuple<short>(1);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnTwoTuple()
    {
      var sut = new Tuple<short, short>(1, 2);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnThreeTuple()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnFourTuple()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnFiveTuple()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnSixTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnSevenTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}