using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnOneTupleNullEnumerable()
    {
      Tuple<double> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnTwoTupleNullEnumerable()
    {
      Tuple<double, double> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnThreeTupleNullEnumerable()
    {
      Tuple<double, double, double> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnFourTupleNullEnumerable()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnFiveTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnSixTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnSevenTupleNullEnumerable()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Count();
    }
  }
}