using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  [TestClass]
  public class TupleLengthTests
  {
    [TestMethod]
    public void LengthOnOneTuple()
    {
      const int expected = 1;
      var t = new Tuple<int>(-1);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LengthOnTwoTuple()
    {
      const int expected = 2;
      var t = new Tuple<int, int>(-1, -2);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void LengthOnThreeTuple()
    {
      const int expected = 3;
      var t = new Tuple<int, int, int>(-1, -2, -3);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void LengthOnFourTuple()
    {
      const int expected = 4;
      var t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void LengthOnFiveTuple()
    {
      const int expected = 5;
      var t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void LengthOnSixTuple()
    {
      const int expected = 6;
      var t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LengthOnSevenTuple()
    {
      const int expected = 7;
      var t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
      int actual = t.Length();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnOneTuple()
    {
      const long expected = 1;
      var t = new Tuple<int>(-1);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnTwoTuple()
    {
      const long expected = 2;
      var t = new Tuple<int, int>(-1, -2);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnThreeTuple()
    {
      const long expected = 3;
      var t = new Tuple<int, int, int>(-1, -2, -3);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnFourTuple()
    {
      const long expected = 4;
      var t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnFiveTuple()
    {
      const long expected = 5;
      var t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnSixTuple()
    {
      const long expected = 6;
      var t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LongLengthOnSevenTuple()
    {
      const long expected = 7;
      var t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
      long actual = t.LongLength();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnOneTuple()
    {
      const int expected = 1;
      var t = new Tuple<int>(-1);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnTwoTuple()
    {
      const int expected = 2;
      var t = new Tuple<int, int>(-1, -2);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnThreeTuple()
    {
      const int expected = 3;
      var t = new Tuple<int, int, int>(-1, -2, -3);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnFourTuple()
    {
      const int expected = 4;
      var t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnFiveTuple()
    {
      const int expected = 5;
      var t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnSixTuple()
    {
      const int expected = 6;
      var t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CountOnSevenTuple()
    {
      const int expected = 7;
      var t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
      int actual = t.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}