using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    [TestMethod]
    public void DoubleMaxOnOneTuple()
    {
      var sut = new Tuple<double>(1);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMaxOnTwoTuple()
    {
      var sut = new Tuple<double, double>(1, 2);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMaxOnThreeTuple()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMaxOnFourTuple()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMaxOnFiveTuple()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMaxOnSixTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMaxOnSevenTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<double>().Max();
      double actual = sut.Max(x => (double) x);
      Assert.AreEqual(expected, actual);
    }
  }
}