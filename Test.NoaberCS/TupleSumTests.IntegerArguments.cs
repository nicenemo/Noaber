using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleSumTests
  {
    private readonly Func<object, int> nullFuncInteger = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnOneTupleFuncNull()
    {
      Tuple<int> sut = new Tuple<int>(1);
      Func<object, int> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnTwoTupleFuncNull()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);
      Func<object, int> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnThreeTupleFuncNull()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);
      Func<object, int> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFourTupleFuncNull()
    {
      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);
      Func<object, int> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnFiveTupleFuncNull()
    {
      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
      Func<object, int> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSixTupleFuncNull()
    {
      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
      Func<object, int> func = null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Sum(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerSumOnSevenTupleFuncNull()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
      Func<object, int> func = null;
      sut.Sum(func);
    }
  }
}
