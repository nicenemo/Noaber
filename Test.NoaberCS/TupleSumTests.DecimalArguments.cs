using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

  public partial class TupleSumTests
  {
    private readonly Func<object, decimal> nullFuncDecimal = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnOneTupleNullEnumerable()
    {
      Tuple<decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }
    
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnOneTupleFuncNull()
    {
      Tuple<decimal> sut = new Tuple<decimal>(1);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnTwoTupleNullEnumerable()
    {
      Tuple<decimal,decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }
 
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnTwoTupleFuncNull()
    {
      Tuple<decimal,decimal> sut = new Tuple<decimal,decimal>(1,2);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnThreeTupleNullEnumerable()
    {
      Tuple<decimal,decimal,decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }
    
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnThreeTupleFuncNull()
    {
      Tuple<decimal,decimal,decimal> sut = new Tuple<decimal,decimal,decimal>(1,2,3);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFourTupleNullEnumerable()
    {
      Tuple<decimal,decimal,decimal,decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFourTupleFuncNull()
    {
      Tuple<decimal,decimal,decimal,decimal> sut = new Tuple<decimal,decimal,decimal,decimal>(1,2,3,4);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFiveTupleNullEnumerable()
    {
      Tuple<decimal,decimal,decimal,decimal,decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }
   
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnFiveTupleFuncNull()
    {
      Tuple<decimal,decimal,decimal,decimal,decimal> sut = new Tuple<decimal,decimal,decimal,decimal,decimal>(1,2,3,4,5);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSixTupleNullEnumerable()
    {
      Tuple<decimal,decimal,decimal,decimal,decimal,decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }
   
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSixTupleFuncNull()
    {
      Tuple<decimal,decimal,decimal,decimal,decimal,decimal> sut = new Tuple<decimal,decimal,decimal,decimal,decimal,decimal>(1,2,3,4,5,6);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }

     [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSevenTupleNullEnumerable()
    {
      Tuple<decimal,decimal,decimal,decimal,decimal,decimal,decimal> sut = null;
      sut.Sum(nullFuncDecimal);
    }
   
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void DecimalSumOnSevenTupleFuncNull()
    {
      Tuple<decimal,decimal,decimal,decimal,decimal,decimal,decimal> sut = new Tuple<decimal,decimal,decimal,decimal,decimal,decimal,decimal>(1,2,3,4,5,6,7);
      Func<object,decimal> func=null;
      sut.Sum(func);
    }
  }
}
