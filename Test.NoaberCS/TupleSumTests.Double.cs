using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    [TestMethod]
    public void DoubleSumOnOneTuple()
    {
      var sut = new Tuple<double>(1);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleSumOnTwoTuple()
    {
      var sut = new Tuple<double, double>(1, 2);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleSumOnThreeTuple()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleSumOnFourTuple()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleSumOnFiveTuple()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleSumOnSixTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleSumOnSevenTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<double>().Sum();
      double actual = sut.Sum(x => (double) x);
      Assert.AreEqual(expected, actual);
    }
  }
}