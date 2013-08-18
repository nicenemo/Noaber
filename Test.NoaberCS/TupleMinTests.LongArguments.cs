using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
  public partial class TupleMinTests
  {
    private readonly Func<object, long> nullFuncLong = null;
    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnOneTupleNullEnumerable()
    {
      Tuple<long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnOneTupleFuncNull()
    {
      Tuple<long> sut = new Tuple<long>(1);  
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnTwoTupleNullEnumerable()
    {
      Tuple<long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnTwoTupleFuncNull()
    {
      Tuple<long, long> sut = new Tuple<long, long>(1, 2);  
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnThreeTupleNullEnumerable()
    {
      Tuple<long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnThreeTupleFuncNull()
    {
      Tuple<long, long, long> sut = new Tuple<long, long, long>(1, 2, 3); 
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFourTupleNullEnumerable()
    {
      Tuple<long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFourTupleFuncNull()
    {
      Tuple<long, long, long, long> sut = new Tuple<long, long, long, long>(1, 2, 3, 4);
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFiveTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnFiveTupleFuncNull()
    {
      Tuple<long, long, long, long, long> sut = new Tuple<long, long, long, long, long>(1, 2, 3, 4, 5);  
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSixTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSixTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long>(1, 2, 3, 4, 5, 6); 
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSevenTupleNullEnumerable()
    {
      Tuple<long, long, long, long, long, long, long> sut = null;
      sut.Min(nullFuncLong);
    }

    [ExpectedException(typeof(ArgumentNullException))]
    [TestMethod]
    public void LongMinOnSevenTupleFuncNull()
    {
      Tuple<long, long, long, long, long, long, long> sut = new Tuple<long, long, long, long, long, long, long>(1, 2, 3, 4, 5, 6, 7); 
      sut.Min(nullFuncLong);
    }
  }
}