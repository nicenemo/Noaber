using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    [TestMethod]
    public void DecimalSumOnOneTuple()
    {
      var sut = new Tuple<decimal>(1);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalSumOnTwoTuple()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalSumOnThreeTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalSumOnFourTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalSumOnFiveTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalSumOnSixTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalSumOnSevenTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
      decimal actual = sut.Sum(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }
  }
}