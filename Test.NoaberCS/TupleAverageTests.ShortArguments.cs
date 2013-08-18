using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    private readonly Func<object, short> nullFuncShort = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnOneTupleNullEnumerable()
    {
      Tuple<short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnOneTupleFuncNull()
    {
      Tuple<short> sut = new Tuple<short>(1);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnTwoTupleNullEnumerable()
    {
      Tuple<short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnTwoTupleFuncNull()
    {
      Tuple<short, short> sut = new Tuple<short, short>(1, 2);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnThreeTupleNullEnumerable()
    {
      Tuple<short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnThreeTupleFuncNull()
    {
      Tuple<short, short, short> sut = new Tuple<short, short, short>(1, 2, 3);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFourTupleNullEnumerable()
    {
      Tuple<short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFourTupleFuncNull()
    {
      Tuple<short, short, short, short> sut = new Tuple<short, short, short, short>(1, 2, 3, 4);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFiveTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnFiveTupleFuncNull()
    {
      Tuple<short, short, short, short, short> sut = new Tuple<short, short, short, short, short>(1, 2, 3, 4, 5);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSixTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSixTupleFuncNull()
    {
      Tuple<short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short>(1, 2, 3, 4, 5, 6);
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSevenTupleNullEnumerable()
    {
      Tuple<short, short, short, short, short, short, short> sut = null;
      sut.Average(nullFuncShort);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void ShortAverageOnSevenTupleFuncNull()
    {
      Tuple<short, short, short, short, short, short, short> sut = new Tuple<short, short, short, short, short, short, short>(1, 2, 3, 4, 5, 6, 7);
      sut.Average(nullFuncShort);
    }
  }
}