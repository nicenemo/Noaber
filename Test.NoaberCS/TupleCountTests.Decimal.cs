using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [TestMethod]
    public void DecimalCountOnOneTuple()
    {
      var sut = new Tuple<decimal>(1);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnTwoTuple()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnThreeTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnFourTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnFiveTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnSixTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnSevenTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}