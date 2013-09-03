using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  [TestClass]
  public class TupleEnumertatorTests
  {
    [TestMethod]
    public void Test1TupleIteration()
    {
      var t = new Tuple<int>(-1);
      const int expected = -1;
      int actual = 0;

      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test2TupleIteration()
    {
      var t = new Tuple<int, int>(-1, -2);
      const int expected = -3;
      int actual = 0;
      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test3TupleIteration()
    {
      var t = new Tuple<int, int, int>(-1, -2, -3);
      const int expected = -6;
      int actual = 0;
      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test4TupleIteration()
    {
      var t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
      const int expected = -10;
      int actual = 0;
      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test5TupleIteration()
    {
      var t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
      const int expected = -15;
      int actual = 0;
      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test6TupleIteration()
    {
      var t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
      const int expected = -21;
      int actual = 0;
      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test7TupleIteration()
    {
      var t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
      const int expected = -28;
      int actual = 0;
      foreach (int v in t.AsEnumerable())
      {
        actual += v;
      }
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ItemOnOneTuple()
    {
      var t = new Tuple<int>(-1);
      Assert.AreEqual(t.Item1, t.Item(0));
    }

    [TestMethod]
    public void ItemOnTwoTuple()
    {
      var t = new Tuple<int, int>(-1, -2);
      Assert.AreEqual(t.Item1, t.Item(0));
      Assert.AreEqual(t.Item2, t.Item(1));
    }

    [TestMethod]
    public void ItemOnThreeTuple()
    {
      var t = new Tuple<int, int, int>(-1, -2, -3);
      Assert.AreEqual(t.Item1, t.Item(0));
      Assert.AreEqual(t.Item2, t.Item(1));
      Assert.AreEqual(t.Item3, t.Item(2));
    }

    [TestMethod]
    public void ItemOnFourTuple()
    {
      var t = new Tuple<int, int, int, int>(-1, -2, -3, -4);
      Assert.AreEqual(t.Item1, t.Item(0));
      Assert.AreEqual(t.Item2, t.Item(1));
      Assert.AreEqual(t.Item3, t.Item(2));
      Assert.AreEqual(t.Item4, t.Item(3));
    }

    [TestMethod]
    public void ItemOnFiveTuple()
    {
      var t = new Tuple<int, int, int, int, int>(-1, -2, -3, -4, -5);
      Assert.AreEqual(t.Item1, t.Item(0));
      Assert.AreEqual(t.Item2, t.Item(1));
      Assert.AreEqual(t.Item3, t.Item(2));
      Assert.AreEqual(t.Item4, t.Item(3));
      Assert.AreEqual(t.Item5, t.Item(4));
    }

    [TestMethod]
    public void ItemOnSixTuple()
    {
      var t = new Tuple<int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6);
      Assert.AreEqual(t.Item1, t.Item(0));
      Assert.AreEqual(t.Item2, t.Item(1));
      Assert.AreEqual(t.Item3, t.Item(2));
      Assert.AreEqual(t.Item4, t.Item(3));
      Assert.AreEqual(t.Item5, t.Item(4));
      Assert.AreEqual(t.Item6, t.Item(5));
    }

    [TestMethod]
    public void ItemOnSevenTuple()
    {
      var t = new Tuple<int, int, int, int, int, int, int>(-1, -2, -3, -4, -5, -6, -7);
      Assert.AreEqual(t.Item1, t.Item(0));
      Assert.AreEqual(t.Item2, t.Item(1));
      Assert.AreEqual(t.Item3, t.Item(2));
      Assert.AreEqual(t.Item4, t.Item(3));
      Assert.AreEqual(t.Item5, t.Item(4));
      Assert.AreEqual(t.Item6, t.Item(5));
      Assert.AreEqual(t.Item7, t.Item(6));
    }
  }
}