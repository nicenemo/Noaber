Imports System
Imports System.Collections

Imports Microsoft.VisualStudio.TestTools.UnitTesting


Namespace Tests
    <TestClass()>
    Public Class TupleEnumertatorTests


#Region "Tuple Iteration tests"
        <TestMethod()>
    <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test1TupleIteration()
            Dim t As New Tuple(Of Integer)(-1)
            Const expected As Integer = -1
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub
        <TestMethod()>
        <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test2TupleIteration()
            Dim t As New Tuple(Of Integer, Integer)(-1, -2)
            Const expected As Integer = -3
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub
        <TestMethod()>
        <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test3TupleIteration()
            Dim t As New Tuple(Of Integer, Integer, Integer)(-1, -2, -3)
            Const expected As Integer = -6
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub
        <TestMethod()>
        <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test4TupleIteration()
            Dim t As New Tuple(Of Integer, Integer, Integer, Integer)(-1, -2, -3, -4)
            Const expected As Integer = -7
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub

        <TestMethod()>
        <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test5TupleIteration()
            Dim t As New Tuple(Of Integer, Integer, Integer, Integer, Integer)(-1, -2, -3, -4, -5)
            Const expected As Integer = -14
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub
        <TestMethod()>
        <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test6TupleIteration()
            Dim t As New Tuple(Of Integer, Integer, Integer, Integer, Integer, Integer)(-1, 2, -3, -4, -5, -6)
            Const expected As Integer = -21
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub

        <TestMethod()>
        <ExpectedException(GetType(ArgumentOutOfRangeException))>
        Public Sub Test7TupleIteration()
            Dim t As New Tuple(Of Integer, Integer, Integer, Integer, Integer, Integer, Integer)(-1, -2, -3, -4, -5, -6, -7)
            Const expected As Integer = -28
            Dim actual As Integer = 0
            For Each v As Integer In t
                actual += v
            Next
            Assert.AreEqual(expected, actual)
        End Sub
#End Region

    End Class
End Namespace
