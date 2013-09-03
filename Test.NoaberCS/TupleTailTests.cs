using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  [TestClass]
  public class TupleTailTests
  {
    [TestMethod]
    public void TailTwoTuple()
    {
      var expected = new Tuple<int>(1);
      var t = new Tuple<int, int>(42, 1);
      Tuple<int> actual = t.Tail();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TailOnThreeTuple()
    {
      var expected = new Tuple<int, int>(1, 1);
      var t = new Tuple<int, int, int>(42, 1, 1);
      Tuple<int, int> actual = t.Tail();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TailOnFourTuple()
    {
      var expected = new Tuple<int, int, int>(1, 1, 1);
      var t = new Tuple<int, int, int, int>(42, 1, 1, 1);
      Tuple<int, int, int> actual = t.Tail();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TailOnFiveTuple()
    {
      var expected = new Tuple<int, int, int, int>(1, 1, 1, 1);
      var t = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
      Tuple<int, int, int, int> actual = t.Tail();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TailOnSixTuple()
    {
      var expected = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 1);
      var t = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
      Tuple<int, int, int, int, int> actual = t.Tail();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TailOnSevenTuple()
    {
      var expected = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 1);
      var t = new Tuple<int, int, int, int, int, int, int>(42, 1, 1, 1, 1, 1, 1);
      Tuple<int, int, int, int, int, int> actual = t.Tail();
      Assert.AreEqual(expected, actual);
    }
  }
}