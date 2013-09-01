using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    [TestMethod]
    public void IntegerSumOnOneTuple()
    {
      var sut = new Tuple<int>(1);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerSumOnTwoTuple()
    {
      var sut = new Tuple<int, int>(1, 2);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerSumOnThreeTuple()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerSumOnFourTuple()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerSumOnFiveTuple()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerSumOnSixTuple()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerSumOnSevenTuple()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<int>().Sum();
      int actual = sut.Sum(x => (int) x);
      Assert.AreEqual(expected, actual);
    }
  }
}