using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
   
    public partial class TupleSumTests
    {
        [TestMethod]
        public void IntegerSumOnTwoTuple()
        {
            Tuple<int, int> sut = new Tuple<int, int>(1, 2);
            int expected=sut.AsEnumerable().Cast<int>().Sum();
            int actual = sut.Sum(x => (int)x);
            Assert.AreEqual(expected,actual);            
        }
        
        [TestMethod]
        public void IntegerSumOnThreeTuple()
        {
            Tuple<int, int,int> sut = new Tuple<int, int,int>(1, 2, 3);
            int expected=sut.AsEnumerable().Cast<int>().Sum();
            int actual = sut.Sum(x => (int)x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerSumOnFourTuple()
        {
 
            Tuple<int, int, int,int> sut = new Tuple<int, int, int,int>(1, 2, 3, 4);
            int expected=sut.AsEnumerable().Cast<int>().Sum();
            int actual = sut.Sum(x => (int)x);
            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
        public void IntegerSumOnFiveTuple()
        {
 
            Tuple<int, int, int,int,int> sut = new Tuple<int, int, int,int,int>(1, 2, 3, 4, 5);
            int expected=sut.AsEnumerable().Cast<int>().Sum();
            int actual = sut.Sum(x => (int)x);
            Assert.AreEqual(expected, actual);
        }

          [TestMethod]
        public void IntegerSumOnSixTuple()
        {
 
            Tuple<int, int, int,int,int,int> sut = new Tuple<int, int, int,int,int,int>(1, 2, 3, 4, 5, 6);
            int expected=sut.AsEnumerable().Cast<int>().Sum();
            int actual = sut.Sum(x => (int)x);
            Assert.AreEqual(expected, actual);
        }
        
          [TestMethod]
        public void IntegerSumOnSevenTuple()
        {
            Tuple<int, int, int,int,int,int,int> sut = new Tuple<int, int, int,int,int,int,int>(1, 2, 3, 4, 5, 6, 7);
            int expected=sut.AsEnumerable().Cast<int>().Sum();
            int actual = sut.Sum(x => (int)x);
            Assert.AreEqual(expected, actual);
        }

    }
}
