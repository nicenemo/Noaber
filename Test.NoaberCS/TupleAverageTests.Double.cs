using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    [TestMethod]
    public void DoubleAverageOnOneTuple()
    {
      var sut = new Tuple<double>(1);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleAverageOnTwoTuple()
    {
      var sut = new Tuple<double, double>(1, 2);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleAverageOnThreeTuple()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleAverageOnFourTuple()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleAverageOnFiveTuple()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleAverageOnSixTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleAverageOnSevenTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<double>().Average();
      double actual = sut.Average(x => (double) x);
      Assert.AreEqual(expected, actual);
    }
  }
}