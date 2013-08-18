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
    public void ShortCountOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Count();
    }
  }
}