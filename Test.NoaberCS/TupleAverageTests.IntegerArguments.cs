using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleAverageTests
  {
    private readonly Func<object, int> nullFuncInteger = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnOneTupleFuncNull()
    {
      Tuple<int> sut = new Tuple<int>(1);
      Func<object, int> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnTwoTupleFuncNull()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      Func<object, int> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnThreeTupleFuncNull()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      Func<object, int> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFourTupleFuncNull()
    {
      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      Func<object, int> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnFiveTupleFuncNull()
    {
      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      Func<object, int> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSixTupleFuncNull()
    {
      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      Func<object, int> func = null;
      sut.Average(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Average(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerAverageOnSevenTupleFuncNull()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      Func<object, int> func = null;
      sut.Average(func);
    }
  }
}
