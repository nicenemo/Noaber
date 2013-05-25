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

    #region "Item Extensions for Tuples"


    public static object Item<T>(this Tuple<T> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            default:
                throw new ArgumentOutOfRangeException("index", "index can only be 0");
        }
    }


    public static object Item<T1, T2>(this Tuple<T1, T2> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            case 1:
                return value.Item2;
            default:
                throw new ArgumentOutOfRangeException("index", "index can only be 0 or 1");
        }
    }


    public static object Item<T1, T2, T3>(this Tuple<T1, T2, T3> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            case 1:
                return value.Item2;
            case 2:
                return value.Item3;
            default:
                throw new ArgumentOutOfRangeException("index", "index must between 0 and  2, inclusive");
        }
    }


    public static object Item<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            case 1:
                return value.Item2;
            case 2:
                return value.Item3;
            case 3:
                return value.Item4;
            default:
                throw new ArgumentOutOfRangeException("index", "index must between 0 and  3, inclusive");
        }
    }


    public static object Item<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            case 1:
                return value.Item2;
            case 2:
                return value.Item3;
            case 3:
                return value.Item4;
            case 4:
                return value.Item5;
            default:
                throw new ArgumentOutOfRangeException("index", "index must between 0 and  4, inclusive");
        }
    }


    public static object Item<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            case 1:
                return value.Item2;
            case 2:
                return value.Item3;
            case 3:
                return value.Item4;
            case 4:
                return value.Item5;
            case 5:
                return value.Item6;
            default:
                throw new ArgumentOutOfRangeException("index", "index must between 0 and  5, inclusive");
        }
    }


    public static object Item<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, int index)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        switch (index)
        {
            case 0:
                return value.Item1;
            case 1:
                return value.Item2;
            case 2:
                return value.Item3;
            case 3:
                return value.Item4;
            case 4:
                return value.Item5;
            case 5:
                return value.Item6;
            case 6:
                return value.Item7;
            default:
                throw new ArgumentOutOfRangeException("index", "index must between 0 and  6, inclusive");
        }
    }
    #endregion

}
