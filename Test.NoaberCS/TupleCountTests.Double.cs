using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [TestMethod]
    public void DoubleCountOnOneTuple()
    {
      var sut = new Tuple<double>(1);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnTwoTuple()
    {
      var sut = new Tuple<double, double>(1, 2);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnThreeTuple()
    {
      var sut = new Tuple<double, double, double>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnFourTuple()
    {
      var sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnFiveTuple()
    {
      var sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnSixTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnSevenTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}