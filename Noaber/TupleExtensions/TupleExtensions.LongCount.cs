using System;
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
    #region "LongCount"

    public static long LongCount<T1>(this Tuple<T1> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 1L;
    }


    public static long LongCount<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 2L;
    }


    public static long LongCount<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 3L;
    }


    public static long LongCount<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 4L;
    }


    public static long LongCount<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 5L;
    }


    public static long LongCount<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 6L;
    }


    public static long LongCount<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 7L;
    }
    #endregion
}
