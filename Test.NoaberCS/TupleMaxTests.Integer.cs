using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    [TestMethod]
    public void IntegerMaxOnOneTuple()
    {
      Tuple<int> sut = new Tuple<int>(1);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void IntegerMaxOnTwoTuple()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnThreeTuple()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnFourTuple()
    {

      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnFiveTuple()
    {

      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnSixTuple()
    {

      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IntegerMaxOnSevenTuple()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<int>().Max();
      int actual = sut.Max(x => (int)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
