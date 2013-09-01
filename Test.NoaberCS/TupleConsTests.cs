//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics;


//using Microsoft.VisualStudio.TestTools.UnitTesting;

//using Noaber;

//[TestClass()]
//public class TupleConsTests
//{

//    #region "Cons Tests"

//    [TestMethod]
//    public void ConsOneTupleWithNull()
//    {
//        Tuple<int> expected = new Tuple<int>(1);
//        string t = null;
//        Tuple<string, int> actual = t.Cons(expected);
//        Assert.AreEqual(expected, actual.Tail);
//        Assert.IsNull(actual.Item1);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConsOnNullOneTupleShouldThrowException()
//    {
//        Tuple<int> t = null;
//        string s = "HelloWorld";
//        s.Cons(t);
//    }

//    [TestMethod]
//    public void ConsOneTuple()
//    {
//        Tuple<int> expected = new Tuple<int>(1);
//        string t = "teststring";
//        Tuple<int> actual = t.Cons(expected).Tail();
//        Assert.AreEqual(expected, actual);
//    }


//    [TestMethod]
//    public void ConsTwoTupleWithNull()
//    {
//        Tuple<int, int> expected = new Tuple<int, int>(1, 2);
//        string t = null;
//        Tuple<string, int, int> actual = t.Cons(expected);
//        Assert.AreEqual(expected, actual.Tail);
//        Assert.IsNull(actual.Item1);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConsOnNullTwoTupleShouldThrowException()
//    {
//        Tuple<int, int> t = null;
//        string s = "HelloWorld";
//        s.Cons(t);
//    }

//    [TestMethod]
//    public void ConsOnTwoTuple()
//    {
//        Tuple<int, int> expected = new Tuple<int, int>(1, 1);
//        string t = "teststring";
//        Tuple<int, int> actual = t.Cons(expected).Tail();
//        Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ConsThreeTupleWithNull()
//    {
//        Tuple<int, int, int> expected = new Tuple<int, int, int>(1, 2, 3);
//        string t = null;
//        Tuple<string, int, int, int> actual = t.Cons(expected);
//        Assert.AreEqual(expected, actual.Tail);
//        Assert.IsNull(actual.Item1);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConsOnNullThreeTupleShouldThrowException()
//    {
//        Tuple<int, int, int> t = null;
//        string s = "HelloWorld";
//        s.Cons(t);
//    }

//    [TestMethod]
//    public void ConsOnThreeTuple()
//    {
//        Tuple<int, int, int> expected = new Tuple<int, int, int>(1, 1, 1);
//        string t = "teststring";
//        Tuple<int, int, int> actual = t.Cons(expected).Tail();
//        Assert.AreEqual(expected, actual);
//    }


//    [TestMethod]
//    public void ConsFourTupleWithNull()
//    {
//        Tuple<int, int, int, int> expected = new Tuple<int, int, int, int>(1, 2, 3, 4);
//        string t = null;
//        Tuple<string, int, int, int, int> actual = t.Cons(expected);
//        Assert.AreEqual(expected, actual.Tail);
//        Assert.IsNull(actual.Item1);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConsOnNullFourTupleShouldThrowException()
//    {
//        Tuple<int, int, int, int> t = null;
//        string s = "HelloWorld";
//        s.Cons(t);
//    }

//    [TestMethod]
//    public void ConsOnFourTuple()
//    {
//        Tuple<int, int, int, int> expected = new Tuple<int, int, int, int>(1, 1, 1, 1);
//        string t = "teststring";
//        Tuple<int, int, int, int> actual = t.Cons(expected).Tail();
//        Assert.AreEqual(expected, actual);
//    }


//    [TestMethod]
//    public void ConsFiveTupleWithNull()
//    {
//        Tuple<int, int, int, int, int> expected = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);
//        string t = null;
//        Tuple<string, int, int, int, int, int> actual = t.Cons(expected);
//        Assert.AreEqual(expected, actual.Tail);
//        Assert.IsNull(actual.Item1);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConsOnNullFiveTupleShouldThrowException()
//    {
//        Tuple<int, int, int, int, int> t = null;
//        string s = "HelloWorld";
//        s.Cons(t);
//    }

//    [TestMethod]
//    public void ConsOnFiveTuple()
//    {
//        Tuple<int, int, int, int, int> expected = new Tuple<int, int, int, int, int>(1, 1, 1, 1, 1);
//        string t = "teststring";
//        Tuple<int, int, int, int, int> actual = t.Cons(expected).Tail();
//        Assert.AreEqual(expected, actual);
//    }

//    [TestMethod]
//    public void ConsSixTupleWithNull()
//    {
//        Tuple<int, int, int, int, int, int> expected = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6);
//        string t = null;
//        Tuple<string, int, int, int, int, int, int> actual = t.Cons(expected);
//        Assert.AreEqual(expected, actual.Tail);
//        Assert.IsNull(actual.Item1);
//    }

//    [TestMethod]
//    [ExpectedException(typeof(ArgumentNullException))]
//    public void ConsOnNullSixTupleShouldThrowException()
//    {
//        Tuple<int, int, int, int, int, int> t = null;
//        string s = "HelloWorld";
//        s.Cons(t);
//    }

//    [TestMethod]
//    public void ConsOnSixTuple()
//    {
//        Tuple<int, int, int, int, int, int> expected = new Tuple<int, int, int, int, int, int>(1, 1, 1, 1, 1, 1);
//        string t = "teststring";
//        Tuple<int, int, int, int, int, int> actual = t.Cons(expected).Tail();
//        Assert.AreEqual(expected, actual);
//    }
//    

//}

