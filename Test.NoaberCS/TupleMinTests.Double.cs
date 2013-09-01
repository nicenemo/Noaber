using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    [TestMethod]
    public void DoubleMinOnOneTuple()
    {
      var sut = new Tuple<double>(1);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnTwoTuple()
    {
      var sut = new Tuple<double, double>(1, 2);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnThreeTuple()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnFourTuple()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnFiveTuple()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnSixTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnSevenTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double) x);
      Assert.AreEqual(expected, actual);
    }
  }
}