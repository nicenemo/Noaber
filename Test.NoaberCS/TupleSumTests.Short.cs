using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    [TestMethod]
    public void ShortSumOnOneTuple()
    {
      var sut = new Tuple<short>(1);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortSumOnTwoTuple()
    {
      var sut = new Tuple<short, short>(1, 2);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortSumOnThreeTuple()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortSumOnFourTuple()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortSumOnFiveTuple()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortSumOnSixTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortSumOnSevenTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      short expected = sut.AsEnumerable().Cast<short>().Sum();
      short actual = sut.Sum(x => (short) x);
      Assert.AreEqual(expected, actual);
    }
  }
}