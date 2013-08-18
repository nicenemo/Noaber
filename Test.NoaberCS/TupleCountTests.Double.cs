using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleCountTests
  {
    [TestMethod]
    public void DoubleCountOnOneTuple()
    {
      Tuple<double> sut = new Tuple<double>(1);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void DoubleCountOnTwoTuple()
    {
      Tuple<double, double> sut = new Tuple<double, double>(1, 2);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnThreeTuple()
    {
      Tuple<double, double, double> sut = new Tuple<double, double, double>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnFourTuple()
    {
      Tuple<double, double, double, double> sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnFiveTuple()
    {

      Tuple<double, double, double, double, double> sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnSixTuple()
    {

      Tuple<double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleCountOnSevenTuple()
    {
      Tuple<double, double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<double>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}
