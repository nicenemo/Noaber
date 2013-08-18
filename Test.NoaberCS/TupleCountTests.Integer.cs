using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleCountTests
  {
    [TestMethod]
    public void IntegerCountOnOneTuple()
    {
      Tuple<int> sut = new Tuple<int>(1);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void IntegerCountOnTwoTuple()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerCountOnThreeTuple()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerCountOnFourTuple()
    {
      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerCountOnFiveTuple()
    {

      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerCountOnSixTuple()
    {

      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerCountOnSevenTuple()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<int>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}
