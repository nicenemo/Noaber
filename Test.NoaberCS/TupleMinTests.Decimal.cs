using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    [TestMethod]
    public void DecimalMinOnOneTuple()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void DecimalMinOnTwoTuple()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMinOnThreeTuple()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMinOnFourTuple()
    {

      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMinOnFiveTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMinOnSixTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalMinOnSevenTuple()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      decimal expected = sut.AsEnumerable().Cast<decimal>().Min();
      decimal actual = sut.Min(x => (decimal)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
