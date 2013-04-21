//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics;


//using Microsoft.VisualStudio.TestTools.UnitTesting;

//using Noaber;

//[TestClass()]
//public class ConcatenationTests
//{
//    #region "First Tuple is One Tuple"
//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatTwoOneTuplesFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string> v2 = new Tuple<string>("hello");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatTwoOneTuplesSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatTwoOneTuplesBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTwoOneTuples()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string> v2 = new Tuple<string>("hello");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleTwoTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleTwoTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleTwoTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatOneTupleTwoTuple()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleThreeTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleThreeTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleThreeTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatOneTupleThreeTuple()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleFourTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string, string> v2 = new Tuple<string, string, string, string>("hello", "to", "the", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleFourTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleFourTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatOneTupleFourTuple()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string, string> v2 = new Tuple<string, string, string, string>("hello", "to", "the", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleFiveTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string, string, string> v2 = new Tuple<string, string, string, string, string>("say", "hello", "to", "the", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleFiveTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleFiveTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatOneTupleFiveTuple()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string, string, string> v2 = new Tuple<string, string, string, string, string>("say", "hello", "to", "the", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleSixTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string, string, string, string> v2 = new Tuple<string, string, string, string, string, string>("do", "say", "hello", "to", "the", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleSixTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConCatOneTupleSixTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int> v1 = null;
//        Tuple<string, string, string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatOneTupleSixTuple()
//    {
//        Tuple<int> v1 = new Tuple<int>(42);
//        Tuple<string, string, string, string, string, string> v2 = new Tuple<string, string, string, string, string, string>("do", "say", "hello", "to", "the", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail);
//    }

//    #endregion

//    #region "First Tuple is Two Tuple"
//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleOneTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string> v2 = new Tuple<string>("hello");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleOneTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void CConcatTwoTupleOneTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTwoTupleOneTuple()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string> v2 = new Tuple<string>("hello");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleTwoTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleTwoTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleTwoTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTwoTupleTwoTuple()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleThreeTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleThreeTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleThreeTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTwoTupleThreeTuple()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleFourTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string, string, string> v2 = new Tuple<string, string, string, string>("hello", "to", "the", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleFourTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleFourTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTwoTupleFourTuple()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string, string, string> v2 = new Tuple<string, string, string, string>("hello", "to", "the", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleFiveTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string, string, string, string> v2 = new Tuple<string, string, string, string, string>("say", "hello", "to", "the", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleFiveTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTwoTupleFiveTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int> v1 = null;
//        Tuple<string, string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTwoTupleFiveTuple()
//    {
//        Tuple<int, int> v1 = new Tuple<int, int>(42, 1);
//        Tuple<string, string, string, string, string> v2 = new Tuple<string, string, string, string, string>("say", "hello", "to", "the", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail);
//    }

//    #endregion

//    #region "First Tuple is three Tuple"
//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleOneTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string> v2 = new Tuple<string>("hello");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleOneTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void CConcatTreeTupleOneTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTreeTupleOneTuple()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string> v2 = new Tuple<string>("hello");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleTreeTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleTreeTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleTreeTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTreeTupleTreeTuple()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleThreeTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleThreeTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleThreeTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTreeTupleThreeTuple()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleFourTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string, string, string, string> v2 = new Tuple<string, string, string, string>("hello", "to", "the", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleFourTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatTreeTupleFourTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int> v1 = null;
//        Tuple<string, string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatTreeTupleFourTuple()
//    {
//        Tuple<int, int, int> v1 = new Tuple<int, int, int>(42, 1, 1);
//        Tuple<string, string, string, string> v2 = new Tuple<string, string, string, string>("hello", "to", "the", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail);
//    }

//    #endregion

//    #region "First Tuple is Four Tuple"
//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleOneTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = null;
//        Tuple<string> v2 = new Tuple<string>("hello");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleOneTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = new Tuple<int, int, int, int>(42, 1, 1, 1);
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void CConcatFourTupleOneTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = null;
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatFourTupleOneTuple()
//    {
//        Tuple<int, int, int, int> v1 = new Tuple<int, int, int, int>(42, 1, 1, 1);
//        Tuple<string> v2 = new Tuple<string>("hello");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleTreeTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = null;
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleTreeTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = new Tuple<int, int, int, int>(42, 1, 1, 1);
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleTreeTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = null;
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatFourTupleTwoTuple()
//    {
//        Tuple<int, int, int, int> v1 = new Tuple<int, int, int, int>(42, 1, 1, 1);
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleThreeTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = null;
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleThreeTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = new Tuple<int, int, int, int>(42, 1, 1, 1);
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFourTupleThreeTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int> v1 = null;
//        Tuple<string, string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatFourTupleThreeTuple()
//    {
//        Tuple<int, int, int, int> v1 = new Tuple<int, int, int, int>(42, 1, 1, 1);
//        Tuple<string, string, string> v2 = new Tuple<string, string, string>("hello", "to", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail.Tail);
//    }
//    #endregion

//    #region "First Tuple is five Tuple"
//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFiveTupleOneTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int> v1 = null;
//        Tuple<string> v2 = new Tuple<string>("hello");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFiveTupleOneTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int> v1 = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void CConcatFiveTupleOneTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int> v1 = null;
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatFiveTupleOneTuple()
//    {
//        Tuple<int, int, int, int, int> v1 = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
//        Tuple<string> v2 = new Tuple<string>("hello");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail.Tail.Tail);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFiveTupleTwoTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int> v1 = null;
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFiveTupleTwoTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int> v1 = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatFiveTupleTwoTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int> v1 = null;
//        Tuple<string, string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatFiveTupleTwoTuple()
//    {
//        Tuple<int, int, int, int, int> v1 = new Tuple<int, int, int, int, int>(42, 1, 1, 1, 1);
//        Tuple<string, string> v2 = new Tuple<string, string>("hello", "world");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail.Tail.Tail);
//    }
//    #endregion
//    #region "First Tuple is six Tuple"
//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatSixTupleOneTupleFirstIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int, int> v1 = null;
//        Tuple<string> v2 = new Tuple<string>("hello");
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConcatSixTupleOneTupleSecondIsNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int, int> v1 = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void CConcatSixTupleOneTupleBothAreNullShouldThrowArgumentNullException()
//    {
//        Tuple<int, int, int, int, int, int> v1 = null;
//        Tuple<string> v2 = null;
//        v1.Concat(v2);
//    }

//    [TestMethod()]
//    public void ConcatSixTupleOneTuple()
//    {
//        Tuple<int, int, int, int, int, int> v1 = new Tuple<int, int, int, int, int, int>(42, 1, 1, 1, 1, 1);
//        Tuple<string> v2 = new Tuple<string>("hello");
//        Assert.AreEqual(v2, v1.Concat(v2).Tail.Tail.Tail.Tail.Tail.Tail);
//    }
//    #endregion
//}