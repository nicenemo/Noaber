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
    #region "Min of Short"

    public static short Min<T1>(this Tuple<T1> value, Func<object, short> func)
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

    public static short Min<T1, T2>(this Tuple<T1, T2> value, Func<object, short> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        short min = short.MaxValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            short fValue = func(v);
            min = System.Math.Min(min, fValue);
        }
        return min;
    }

    public static short Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        short min = short.MaxValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            short fValue = func(v);
            min = System.Math.Min(min, fValue);
        }
        return min;
    }

    public static short Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        short min = short.MaxValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            short fValue = func(v);
            min = System.Math.Min(min, fValue);
        }
        return min;
    }

    public static short Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        short min = short.MaxValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            short fValue = func(v);
            min = System.Math.Min(min, fValue);
        }
        return min;
    }

    public static short Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        short min = short.MaxValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            short fValue = func(v);
            min = System.Math.Min(min, fValue);
        }
        return min;
    }

    public static short Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short> func)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (func == null)
        {
            throw new ArgumentNullException("func", "func is null");
        }
        short min = short.MaxValue;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            short fValue = func(v);
            min = System.Math.Min(min, fValue);
        }
        return min;
    }
    #endregion
}
