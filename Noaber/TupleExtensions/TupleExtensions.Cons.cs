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

    #region "Cons functions for tuples"

    public static Tuple<T1, T2> Cons<T1, T2>(this T1 value, Tuple<T2> tuple)
    {
        if (tuple == null)
        {
            throw new ArgumentNullException("tuple", "tuple should not be null");
        }
        return new Tuple<T1, T2>(value, tuple.Item1);
    }


    public static Tuple<T1, T2, T3> Cons<T1, T2, T3>(this T1 value, Tuple<T2, T3> tuple)
    {
        if (tuple == null)
        {
            throw new ArgumentNullException("tuple", "tuple should not be null");
        }
        return new Tuple<T1, T2, T3>(value, tuple.Item1, tuple.Item2);
    }


    public static Tuple<T1, T2, T3, T4> Cons<T1, T2, T3, T4>(this T1 value, Tuple<T2, T3, T4> tuple)
    {
        if (tuple == null)
        {
            throw new ArgumentNullException("tuple", "tuple should not be null");
        }
        return new Tuple<T1, T2, T3, T4>(value, tuple.Item1, tuple.Item2, tuple.Item3);
    }


    public static Tuple<T1, T2, T3, T4, T5> Cons<T1, T2, T3, T4, T5>(this T1 value, Tuple<T2, T3, T4, T5> tuple)
    {
        if (tuple == null)
        {
            throw new ArgumentNullException("tuple", "tuple should not be null");
        }
        return new Tuple<T1, T2, T3, T4, T5>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
    }


    public static Tuple<T1, T2, T3, T4, T5, T6> Cons<T1, T2, T3, T4, T5, T6>(this T1 value, Tuple<T2, T3, T4, T5, T6> tuple)
    {
        if (tuple == null)
        {
            throw new ArgumentNullException("tuple", "tuple should not be null");
        }
        return new Tuple<T1, T2, T3, T4, T5, T6>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
    }


    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Cons<T1, T2, T3, T4, T5, T6, T7>(this T1 value, Tuple<T2, T3, T4, T5, T6, T7> tuple)
    {
        if (tuple == null)
        {
            throw new ArgumentNullException("tuple", "tuple should not be null");
        }
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
    }

    #endregion
}
