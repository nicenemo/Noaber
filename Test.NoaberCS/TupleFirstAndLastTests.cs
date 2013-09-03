﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  [TestClass]
  public class TupleFirstAndLastTests
  {
    [TestMethod]
    public void FirstOnOneTuple()
    {
      const int expected = 42;
      var t = new Tuple<int>(42);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstTwoTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int>(42, 1);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOnThreeTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int>(42, 1, 1);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOnFourTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int>(42, 1, 1, 1);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOnFiveTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOnSixTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOnSevenTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int, int>(42, 1, 1, 1, 1, 1, 1);
      int actual = t.First();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultOnNullOneTuple()
    {
      Tuple<int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnNullTwoTuple()
    {
      Tuple<int, int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnNullThreeTuple()
    {
      Tuple<int, int, int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnNullFourTuple()
    {
      Tuple<int, int, int, int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnNullFiveTuple()
    {
      Tuple<int, int, int, int, int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnNullOneSixTuple()
    {
      Tuple<int, int, int, int, int, int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnNullSevenTuple()
    {
      Tuple<int, int, int, int, int, int, int> t = null;
      Assert.AreEqual(0, t.FirstOrDefault());
    }

    [TestMethod]
    public void FirstOrDefaultOnOneTuple()
    {
      const int expected = 42;
      var t = new Tuple<int>(42);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultTwoTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int>(42, 1);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultOnThreeTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int>(42, 1, 1);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultOnFourTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int>(42, 1, 1, 1);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultOnFiveTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultOnSixTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FirstOrDefaultOnSevenTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int, int>(42, 1, 1, 1, 1, 1, 1);
      int actual = t.FirstOrDefault();
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void LastOnOneTuple()
    {
      const int expected = 42;
      var t = new Tuple<int>(42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastTwoTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int>(1, 42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOnThreeTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int>(1, 1, 42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOnFourTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int>(1, 1, 1, 42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOnFiveTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOnSixTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOnSevenTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int, int>(1, 1, 1, 1, 1, 1, 42);
      int actual = t.Last();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultOnNullOneTupleIsNull()
    {
      Tuple<int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnNullTwoTupleIsNull()
    {
      Tuple<int, int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnNullThreeTupleIsNull()
    {
      Tuple<int, int, int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnNullFourTupleIsNull()
    {
      Tuple<int, int, int, int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnNullFiveTupleIsNull()
    {
      Tuple<int, int, int, int, int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnNullOneSixTupleIsNull()
    {
      Tuple<int, int, int, int, int, int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnNullSevenTupleIsNull()
    {
      Tuple<int, int, int, int, int, int, int> t = null;
      Assert.AreEqual(0, t.LastOrDefault());
    }

    [TestMethod]
    public void LastOrDefaultOnOneTuple()
    {
      const int expected = 42;
      var t = new Tuple<int>(42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultTwoTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int>(1, 42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultOnThreeTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int>(1, 1, 42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultOnFourTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int>(1, 1, 1, 42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultOnFiveTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultOnSixTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LastOrDefaultOnSevenTuple()
    {
      const int expected = 42;
      var t = new Tuple<int, int, int, int, int, int, int>(1, 1, 1, 1, 1, 1, 42);
      int actual = t.LastOrDefault();
      Assert.AreEqual(expected, actual);
    }
  }
}