using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
   
    public partial class TupleSumTests
    {
        [TestMethod]
        public void DecimalSumOnOneTuple()
        {
            Tuple< decimal> sut = new Tuple<decimal>(1);
            decimal expected = sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecimalSumOnTwoTuple()
        {
            Tuple<decimal, decimal> sut = new Tuple<decimal, decimal>(1, 2);
            decimal expected=sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected,actual);            
        }
        
        [TestMethod]
        public void DecimalSumOnThreeTuple()
        {
            Tuple<decimal, decimal,decimal> sut = new Tuple<decimal, decimal,decimal>(1, 2, 3);
            decimal expected=sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalSumOnFourTuple()
        {
 
            Tuple<decimal, decimal, decimal,decimal> sut = new Tuple<decimal, decimal, decimal,decimal>(1, 2, 3, 4);
            decimal expected=sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
        public void DecimalSumOnFiveTuple()
        {
 
            Tuple<decimal, decimal, decimal,decimal,decimal> sut = new Tuple<decimal, decimal, decimal,decimal,decimal>(1, 2, 3, 4, 5);
            decimal expected=sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected, actual);
        }

          [TestMethod]
        public void DecimalSumOnSixTuple()
        {
 
            Tuple<decimal, decimal, decimal,decimal,decimal,decimal> sut = new Tuple<decimal, decimal, decimal,decimal,decimal,decimal>(1, 2, 3, 4, 5, 6);
            decimal expected=sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected, actual);
        }
        
          [TestMethod]
        public void DecimalSumOnSevenTuple()
        {
            Tuple<decimal, decimal, decimal,decimal,decimal,decimal,decimal> sut = new Tuple<decimal, decimal, decimal,decimal,decimal,decimal,decimal>(1, 2, 3, 4, 5, 6, 7);
            decimal expected=sut.AsEnumerable().Cast<decimal>().Sum();
            decimal actual = sut.Sum(x => (decimal)x);
            Assert.AreEqual(expected, actual);
        }

    }
}
