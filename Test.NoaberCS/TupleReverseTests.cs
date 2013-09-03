using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  [TestClass]
  public class TupleReverseTests
  {
    [TestMethod]
    public void ReverseOneTuple()
    {
      var expected = new Tuple<int>(42);
      var t = new Tuple<int>(42);
      Tuple<int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseTwoTuple()
    {
      var expected = new Tuple<int, int>(1, 42);
      var t = new Tuple<int, int>(42, 1);
      Tuple<int, int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseOnThreeTuple()
    {
      var expected = new Tuple<int, int, int>(1, 1, 42);
      var t = new Tuple<int, int, int>(42, 1, 1);
      Tuple<int, int, int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseOnFourTuple()
    {
      var expected = new Tuple<int, int, int, int>(1, 1, 1, 42);
      var t = new Tuple<int, int, int, int>(42, 1, 1, 1);
      Tuple<int, int, int, int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseOnFiveTuple()
    {
      var expected = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 42);
      var t = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
      Tuple<int, int, int, int, int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseOnSixTuple()
    {
      var expected = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 42);
      var t = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
      Tuple<int, int, int, int, int, int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReverseOnSevenTuple()
    {
      var expected = new Tuple<int, int, int, int, int, int, int>(1, 1, 1, 1, 1, 1, 42);
      var t = new Tuple<int, int, int, int, int, int, int>(42, 1, 1, 1, 1, 1, 1);
      Tuple<int, int, int, int, int, int, int> actual = t.Reverse();
      Assert.AreEqual(expected, actual);
    }
  }
}