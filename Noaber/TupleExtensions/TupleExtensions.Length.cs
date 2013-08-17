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

    #region "Length"

    public static int Length<T1>(this Tuple<T1> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 1;
    }


    public static int Length<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 2;
    }


    public static int Length<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 3;
    }


    public static int Length<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 4;
    }


    public static int Length<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 5;
    }


    public static int Length<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 6;
    }


    public static int Length<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return 7;
    }
    #endregion

}
