using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    [TestMethod]
    public void DoubleMinOnOneTuple()
    {
      Tuple<double> sut = new Tuple<double>(1);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void DoubleMinOnTwoTuple()
    {
      Tuple<double, double> sut = new Tuple<double, double>(1, 2);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnThreeTuple()
    {
      Tuple<double, double, double> sut = new Tuple<double, double, double>(1, 2, 3);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnFourTuple()
    {

      Tuple<double, double, double, double> sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnFiveTuple()
    {

      Tuple<double, double, double, double, double> sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnSixTuple()
    {

      Tuple<double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleMinOnSevenTuple()
    {
      Tuple<double, double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      double expected = sut.AsEnumerable().Cast<double>().Min();
      double actual = sut.Min(x => (double)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
