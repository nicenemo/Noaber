using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleCountTests
  {
    [TestMethod]
    public void ShortCountOnOneTuple()
    {
      Tuple<short> sut = new Tuple<short>(1);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ShortCountOnTwoTuple()
    {
      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnThreeTuple()
    {
      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnFourTuple()
    {
      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnFiveTuple()
    {

      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnSixTuple()
    {

      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortCountOnSevenTuple()
    {
      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      int expected = sut.AsEnumerable().Cast<short>().Count();
      int actual = sut.Count();
      Assert.AreEqual(expected, actual);
    }
  }
}
