using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    [TestMethod]
    public void IntegerMaxOnOneTuple()
    {
      var sut = new Tuple<int>(1);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnTwoTuple()
    {
      var sut = new Tuple<int, int>(1, 2);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnThreeTuple()
    {
      var sut = new Tuple<int, int, int>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnFourTuple()
    {
      var sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnFiveTuple()
    {
      var sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnSixTuple()
    {
      var sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnSevenTuple()
    {
      var sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int) x);
      Assert.AreEqual(expected, actual);
    }
  }
}