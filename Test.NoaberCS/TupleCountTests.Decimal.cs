using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleCountTests
  {
    [TestMethod]
    public void DecimalCountOnOneTuple()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void DecimalCountOnTwoTuple()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnThreeTuple()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnFourTuple()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnFiveTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnSixTuple()
    {

      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
       int expected = sut.AsEnumerable().Cast<decimal>().Count();
       int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecimalCountOnSevenTuple()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<decimal>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}
