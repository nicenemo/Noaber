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
    #region "Cast"
    public static Tuple<TResult> Cast<TResult, T1>(this Tuple<T1> value)
        where T1 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult>((TResult)value.Item1);
    }

    public static Tuple<TResult, TResult> Cast<TResult, T1, T2>(this Tuple<T1, T2> value)
        where T1 : TResult
        where T2 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult, TResult>((TResult)value.Item1, (TResult)value.Item2);
    }

    public static Tuple<TResult, TResult, TResult> Cast<TResult, T1, T2, T3>(this Tuple<T1, T2, T3> value)
        where T1 : TResult
        where T2 : TResult
        where T3 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult, TResult, TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3);
    }

    public static Tuple<TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        where T1 : TResult
        where T2 : TResult
        where T3 : TResult
        where T4 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult, TResult, TResult, TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4);
    }

    public static Tuple<TResult, TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        where T1 : TResult
        where T2 : TResult
        where T3 : TResult
        where T4 : TResult
        where T5 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult, TResult, TResult, TResult, TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4, (TResult)value.Item5);
    }

    public static Tuple<TResult, TResult, TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        where T1 : TResult
        where T2 : TResult
        where T3 : TResult
        where T4 : TResult
        where T5 : TResult
        where T6 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult, TResult, TResult, TResult, TResult, TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4, (TResult)value.Item5, (TResult)value.Item6);
    }

    public static Tuple<TResult, TResult, TResult, TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        where T1 : TResult
        where T2 : TResult
        where T3 : TResult
        where T4 : TResult
        where T5 : TResult
        where T6 : TResult
        where T7 : TResult
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        return new Tuple<TResult, TResult, TResult, TResult, TResult, TResult, TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4, (TResult)value.Item5, (TResult)value.Item6, (TResult)value.Item7);
    }

    #endregion

}