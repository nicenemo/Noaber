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
    #region "Max of Decimal?"

    public static decimal? Max<T1>(this Tuple<T1> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        return f(value.Item1);
    }

    public static decimal? Max<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        decimal? max = decimal.MinValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            decimal? fValue = f(v);
            if (fValue.HasValue)
            {
                max = System.Math.Max(max.Value, fValue.Value);
            }
        }
        return max;
    }

    public static decimal? Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        decimal? max = decimal.MinValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            decimal? fValue = f(v);
            if (fValue.HasValue)
            {
                max = System.Math.Max(max.Value, fValue.Value);
            }
        }
        return max;
    }

    public static decimal? Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        decimal? max = decimal.MinValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            decimal? fValue = f(v);
            if (fValue.HasValue)
            {
                max = System.Math.Max(max.Value, fValue.Value);
            }
        }
        return max;
    }

    public static decimal? Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        decimal? max = decimal.MinValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            decimal? fValue = f(v);
            if (fValue.HasValue)
            {
                max = System.Math.Max(max.Value, fValue.Value);
            }
        }
        return max;
    }

    public static decimal? Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        decimal? max = decimal.MinValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            decimal? fValue = f(v);
            if (fValue.HasValue)
            {
                max = System.Math.Max(max.Value, fValue.Value);
            }
        }
        return max;
    }

    public static decimal? Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, decimal?> f)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (f == null)
        {
            throw new ArgumentNullException("f", "f is null");
        }
        decimal? max = decimal.MinValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            decimal? fValue = f(v);
            if (fValue.HasValue)
            {
                max = System.Math.Max(max.Value, fValue.Value);
            }
        }
        return max;
    }
    #endregion

}
