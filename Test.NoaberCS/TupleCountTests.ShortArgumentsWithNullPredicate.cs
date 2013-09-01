using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleCountTests
  {
    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnOneTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnOneTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short>(1);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnTwoTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short, short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnTwoTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short, short>(1, 2);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnThreeTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short, short, short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnThreeTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short, short, short>(1, 2, 3);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnFourTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnFourTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnFiveTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnFiveTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnSixTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnSixTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnSevenTupleNullEnumerableWithNullPredicate()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Count(nullPredicate);
    }

    [ExpectedException(typeof (ArgumentNullException))]
    [TestMethod]
    public void ShortCountOnSevenTupleFuncNullWithNullPredicate()
    {
      var sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      sut.Count(nullPredicate);
    }
  }
}