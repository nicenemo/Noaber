using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleAverageTests
  {
    [TestMethod]
    public void DecimalAverageOnOneTuple()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void DecimalAverageOnTwoTuple()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnThreeTuple()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnFourTuple()
    {

      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnFiveTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnSixTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalAverageOnSevenTuple()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Average();
      decimal actual = sut.Average(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
