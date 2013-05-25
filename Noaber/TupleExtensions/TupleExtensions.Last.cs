using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public static partial class TupleExtensions
{
    #region "Tuples Last Extensions"

    public static T1 Last<T1>(this Tuple<T1> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item1;
    }


    public static T2 Last<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item2;
    }


    public static T3 Last<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item3;
    }


    public static T4 Last<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item4;
    }


    public static T5 Last<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item5;
    }


    public static T6 Last<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item6;
    }


    public static T7 Last<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return value.Item7;
    }

    #endregion
}