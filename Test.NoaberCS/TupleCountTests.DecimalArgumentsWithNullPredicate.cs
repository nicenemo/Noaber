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
    public void DecimalCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnOneTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnTwoTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnThreeTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFourTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnFiveTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSixTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalCountOnSevenTupleFuncNullWithNullPredicate()
    {
      Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal> sut = new Tuple<decimal, decimal, decimal, decimal, decimal, decimal, decimal>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}