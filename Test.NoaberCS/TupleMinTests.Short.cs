using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    [TestMethod]
    public void ShortMinOnOneTuple()
    {
      var sut = new Tuple<short>(1);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnTwoTuple()
    {
      var sut = new Tuple<short, short>(1, 2);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnThreeTuple()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnFourTuple()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnFiveTuple()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnSixTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnSevenTuple()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short) x);
      Assert.AreEqual(expected, actual);
    }
  }
}