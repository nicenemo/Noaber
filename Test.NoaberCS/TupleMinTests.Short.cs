using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleMinTests
  {
    [TestMethod]
    public void ShortMinOnOneTuple()
    {
      Tuple<short> sut = new Tuple<short>(1);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ShortMinOnTwoTuple()
    {
      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnThreeTuple()
    {
      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnFourTuple()
    {

      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnFiveTuple()
    {

      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnSixTuple()
    {

      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ShortMinOnSevenTuple()
    {
      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      short expected = sut.AsEnumerable().Cast<short>().Min();
      short actual = sut.Min(x => (short)x);
      Assert.AreEqual(expected, actual);
    }
  }
}
