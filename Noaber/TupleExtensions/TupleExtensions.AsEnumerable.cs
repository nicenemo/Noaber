﻿using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

/// <summary>
/// Extensions for Tuples
/// </summary>
public static partial class TuplesExtensions
{
    #region "AsEnumerable"
    //REMARK: AsEnumerable seems to be required for C# because C# demands instance an Instance Method for MoveNext and a Property for Current.
    //VB.NET allows the Use of an extension Method for MoveNext and and Extension Method for Current.

    public static IEnumerable AsEnumerable<T>(this Tuple<T> value)
    {
        return new OneTupleEnumerable<T>(value);
    }

    public static IEnumerable AsEnumerable<T1, T2>(this Tuple<T1, T2> value)
    {
        return new TwoTupleEnumerable<T1, T2>(value);
    }

    public static IEnumerable AsEnumerable<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        return new ThreeTupleEnumerable<T1, T2, T3>(value);
    }

    public static IEnumerable AsEnumerable<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        return new FourTupleEnumerable<T1, T2, T3, T4>(value);
    }


    public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        return new FiveTupleEnumerable<T1, T2, T3, T4, T5>(value);
    }

    public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        return new SixTupleEnumerable<T1, T2, T3, T4, T5, T6>(value);
    }

    public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        return new SevenTupleEnumerable<T1, T2, T3, T4, T5, T6, T7>(value);
    }
    #endregion
}
