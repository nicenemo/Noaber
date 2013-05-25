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

    #region "Tuples Reverse Extensions"

    public static Tuple<T1> Reverse<T1>(this Tuple<T1> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T1>(value.Item1);
    }


    public static Tuple<T2, T1> Reverse<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2, T1>(value.Item2, value.Item1);
    }


    public static Tuple<T3, T2, T1> Reverse<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }

        return new Tuple<T3, T2, T1>(value.Item3, value.Item2, value.Item1);
    }


    public static Tuple<T4, T3, T2, T1> Reverse<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T4, T3, T2, T1>(value.Item4, value.Item3, value.Item2, value.Item1);
    }


    public static Tuple<T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T5, T4, T3, T2, T1>(value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
    }


    public static Tuple<T6, T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T6, T5, T4, T3, T2, T1>(value.Item6, value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
    }


    public static Tuple<T7, T6, T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T7, T6, T5, T4, T3, T2, T1>(value.Item7, value.Item6, value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
    }

    #endregion
}
