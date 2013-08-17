//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests
//{

//  public partial class TupleAverageTests
//  {
//    [TestMethod]
//    public void ShortAverageOnOneTuple()
//    {
//      Tuple<short> sut = new Tuple<short>(1);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }
//    [TestMethod]
//    public void ShortAverageOnTwoTuple()
//    {
//      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ShortAverageOnThreeTuple()
//    {
//      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ShortAverageOnFourTuple()
//    {

//      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ShortAverageOnFiveTuple()
//    {

//      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ShortAverageOnSixTuple()
//    {

//      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ShortAverageOnSevenTuple()
//    {
//      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
//      double expected = sut.AsEnumerable().Cast<short>().Average();
//      double actual = sut.Average(x => (short)x);
//      Assert.AreEqual(expected, actual);
//    }
//  }
//}
