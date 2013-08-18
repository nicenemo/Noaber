using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerCountOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Count();
    }
  }
}