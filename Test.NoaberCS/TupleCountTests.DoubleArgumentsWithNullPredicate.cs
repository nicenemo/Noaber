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
    public void DoubleCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnOneTupleFuncNullWithNullPredicate()
    {
      Tuple<double> sut = new Tuple<double>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double, double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnTwoTupleFuncNullWithNullPredicate()
    {
      Tuple<double, double> sut = new Tuple<double, double>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double, double, double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnThreeTupleFuncNullWithNullPredicate()
    {
      Tuple<double, double, double> sut = new Tuple<double, double, double>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double, double, double, double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnFourTupleFuncNullWithNullPredicate()
    {
      Tuple<double, double, double, double> sut = new Tuple<double, double, double, double>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double, double, double, double, double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnFiveTupleFuncNullWithNullPredicate()
    {
      Tuple<double, double, double, double, double> sut = new Tuple<double, double, double, double, double>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double, double, double, double, double, double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnSixTupleFuncNullWithNullPredicate()
    {
      Tuple<double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<double, double, double, double, double, double, double> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DoubleCountOnSevenTupleFuncNullWithNullPredicate()
    {
      Tuple<double, double, double, double, double, double, double> sut = new Tuple<double, double, double, double, double, double, double>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}