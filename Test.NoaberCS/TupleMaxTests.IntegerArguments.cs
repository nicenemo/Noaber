using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMaxTests
  {
    private readonly Func<object, int> nullFuncInteger = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnOneTupleNullEnumerable()
    {
      Tuple<int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnOneTupleFuncNull()
    {
      Tuple<int> sut = new Tuple<int>(1);
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnTwoTupleNullEnumerable()
    {
      Tuple<int, int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnTwoTupleFuncNull()
    {
      Tuple<int, int> sut = new Tuple<int, int>(1, 2);    
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnThreeTupleNullEnumerable()
    {
      Tuple<int, int, int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnThreeTupleFuncNull()
    {
      Tuple<int, int, int> sut = new Tuple<int, int, int>(1, 2, 3);   
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnFourTupleNullEnumerable()
    {
      Tuple<int, int, int, int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnFourTupleFuncNull()
    {
      Tuple<int, int, int, int> sut = new Tuple<int, int, int, int>(1, 2, 3, 4);   
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnFiveTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnFiveTupleFuncNull()
    {
      Tuple<int, int, int, int, int> sut = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);     
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnSixTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnSixTupleFuncNull()
    {
      Tuple<int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);     
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnSevenTupleNullEnumerable()
    {
      Tuple<int, int, int, int, int, int, int> sut = null;
      sut.Max(nullFuncInteger);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void IntegerMaxOnSevenTupleFuncNull()
    {
      Tuple<int, int, int, int, int, int, int> sut = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);  
      sut.Max(nullFuncInteger);
    }
  }
}