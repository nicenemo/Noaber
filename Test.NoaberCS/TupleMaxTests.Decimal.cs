using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    [TestMethod]
    public void DecimalMaxOnOneTuple()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void DecimalMaxOnTwoTuple()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnThreeTuple()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnFourTuple()
    {

      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnFiveTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnSixTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMaxOnSevenTuple()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Max();
      decimal actual = sut.Max(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
