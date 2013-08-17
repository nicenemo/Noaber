using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    [TestMethod]
    public void IntegerMinOnOneTuple()
    {
      Tuple<int> sut = new Tuple<int>(1);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void IntegerMinOnTwoTuple()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnThreeTuple()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnFourTuple()
    {

      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnFiveTuple()
    {

      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnSixTuple()
    {

      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMinOnSevenTuple()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<int>().Min();
      int actual = sut.Min(x => (int)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
