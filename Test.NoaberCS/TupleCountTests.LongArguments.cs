using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void LongCountOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Count();
    }
  }
}