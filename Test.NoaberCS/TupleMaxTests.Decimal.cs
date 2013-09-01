using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    [TestMethod]
    public void DecimalMaxOnOneTuple()
    {
      var sut = new Tuple<decimal>(1);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnTwoTuple()
    {
      var sut = new Tuple<decimal, decimal>(1, 2);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnThreeTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnFourTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnFiveTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnSixTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnSevenTuple()
    {
      var sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal) x);
      Assert.AreEqual(expected, actual);
    }
  }
}