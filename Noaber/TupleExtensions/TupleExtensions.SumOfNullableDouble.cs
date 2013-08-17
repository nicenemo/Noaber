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
    #region "Sum of Double?"

    public static double? Sum<T1>(this Tuple<T1> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        return func(value.Item1);
    }

    public static double? Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        double sum = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            double? fValue = func(v);
            if (fValue.HasValue)
            {
                sum += fValue.Value;
            }
        }
        return sum;
    }

    public static double? Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        double? sum = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            double? fValue = func(v);
            if (fValue.HasValue)
            {
                sum += fValue.Value;
            }
        }
        return sum;
    }

    public static double? Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        double? sum = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            double? fValue = func(v);
            if (fValue.HasValue)
            {
                sum += fValue.Value;
            }
        }
        return sum;
    }

    public static double? Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        double? sum = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            double? fValue = func(v);
            if (fValue.HasValue)
            {
                sum += fValue.Value;
            }
        }
        return sum;
    }

    public static double? Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        double? sum = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            double? fValue = func(v);
            if (fValue.HasValue)
            {
                sum += fValue.Value;
            }
        }
        return sum;
    }

    public static double? Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, double?> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        double? sum = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            double? fValue = func(v);
            if (fValue.HasValue)
            {
                sum += fValue.Value;
            }
        }
        return sum;
    }
    #endregion
}