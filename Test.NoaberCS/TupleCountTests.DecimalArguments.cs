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
    public void DecimalCountOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnTwoTupleNullEnumerable()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnThreeTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFourTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFiveTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSixTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count();
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSevenTupleNullEnumerable()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count();
    }
  }
}