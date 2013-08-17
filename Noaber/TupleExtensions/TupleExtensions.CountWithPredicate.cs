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
    #region "Count with predicate"

    public static int Count<T1>(this Tuple<T1> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }


        if (predicate(value.Item1))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static int Count<T1, T2>(this Tuple<T1, T2> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }

        int count = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            if (predicate(v))
            {
                count++;
            }
        }
        return count;
    }

    public static int Count<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }

        int count = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            if (predicate(v))
            {
                count++;
            }
        }
        return count;
    }

    public static int Count<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }

        int count = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            if (predicate(v))
            {
                count++;
            }
        }
        return count;
    }


    public static int Count<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }

        int count = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            if (predicate(v))
            {
                count++;
            }
        }
        return count;
    }

    public static int Count<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }
        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }

        int count = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            if (predicate(v))
            {
                count++;
            }
        }
        return count;
    }

    public static int Count<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, Boolean> predicate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value is null");
        }

        if (predicate == null)
        {
            throw new ArgumentNullException("predicate", "predicate is null");
        }

        int count = 0;
        int i = value.Count();
        while (0 < i)
        {
            i--;
            object v = value.Item(i);
            if (predicate(v))
            {
                count++;
            }
        }
        return count;
    }
    #endregion

}
