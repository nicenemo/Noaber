using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMaxTests
  {
    [TestMethod]
    public void ShortMaxOnOneTuple()
    {
      Tuple<short> sut = new Tuple<short>(1);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ShortMaxOnTwoTuple()
    {
      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMaxOnThreeTuple()
    {
      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMaxOnFourTuple()
    {

      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMaxOnFiveTuple()
    {

      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMaxOnSixTuple()
    {

      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMaxOnSevenTuple()
    {
      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      short expected = sut.AsEnumerable().Cast<short>().Max();
      short actual = sut.Max(x => (short)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
