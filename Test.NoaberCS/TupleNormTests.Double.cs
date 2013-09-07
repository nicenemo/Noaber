using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleSumTests
  {
    [TestMethod]
    public void DoubleNormOnOneTuple()
    {
      var sut = new Tuple<double>(1);
      const double expected = 1;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleNormOnTwoTuple()
    {
      var sut = new Tuple<double, double>(3, 4);
      const double expected = 5.0;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleNormOnThreeTuple()
    {
      var sut = new Tuple<double, double, double>(0,3,4);
      const double expected =5.0;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleNormOnFourTuple()
    {
      var sut = new Tuple<double, double, double, double>(0, 0, 3, 4);
      const double expected = 5.0;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleNormOnFiveTuple()
    {
      var sut = new Tuple<double, double, double, double, double>(0, 0, 0, 3, 4);
      const double expected = 5.0;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleNormOnSixTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double>(0, 0, 0, 0, 3, 4);
      const double expected = 5.0;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DoubleNormOnSevenTuple()
    {
      var sut = new Tuple<double, double, double, double, double, double, double>(0, 0, 0, 0, 0, 3, 4);
      const double expected = 5.0;
      double actual = sut.Norm(x => (double)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
