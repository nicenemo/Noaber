using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleAverageTests
  {
    private readonly Func<object, long> nullFuncLong = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnOneTupleFuncNull()
    {
      Tuple<long> sut = new Tuple<long>(1);    
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnTwoTupleFuncNull()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2); 
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnThreeTupleFuncNull()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3);  
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnFourTupleFuncNull()
    {
      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);   
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnFiveTupleFuncNull()
    {
      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);   
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnSixTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6);  
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Average(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongAverageOnSevenTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7);   
      sut.Average(nullFuncLong);
    }
  }
}