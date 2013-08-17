using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

/// <summary>
/// Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{

    #region "Enumerator Extensions"

    public static IEnumerator GetEnumerator<T>(this Tuple<T> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new OneTupleEnumerator<T>(value);
    }


    public static IEnumerator GetEnumerator<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new TwoTupleEnumerator<T1, T2>(value);
    }


    public static IEnumerator GetEnumerator<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new ThreeTupleEnumerator<T1, T2, T3>(value);
    }


    public static IEnumerator GetEnumerator<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new FourTupleEnumerator<T1, T2, T3, T4>(value);
    }


    public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new FiveTupleEnumerator<T1, T2, T3, T4, T5>(value);
    }


    public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new SixTupleEnumerator<T1, T2, T3, T4, T5, T6>(value);
    }


    public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
            throw new ArgumentNullException("value", "value is null");
        return new SevenTupleEnumerator<T1, T2, T3, T4, T5, T6, T7>(value);
    }
    #endregion

}
