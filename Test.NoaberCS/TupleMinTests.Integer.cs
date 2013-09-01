using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    [TestMethod]
    public void IntegerMinOnOneTuple()
    {
      var sut = new Tuple<int>(1);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnTwoTuple()
    {
      var sut = new Tuple<int, int>(1, 2);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnThreeTuple()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnFourTuple()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnFiveTuple()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnSixTuple()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnSevenTuple()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int) x);
      Assert.AreEqual(expected, actual);
    }
  }
}