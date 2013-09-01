using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    [TestMethod]
    public void DecimalAverageOnOneTuple()
    {
      var sut = new Tuple<decimal>(1);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnTwoTuple()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnThreeTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnFourTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnFiveTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnSixTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnSevenTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }
  }
}