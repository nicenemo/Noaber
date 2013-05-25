using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public static partial  class TupleExtensions
{
    #region "Tuples tail Extensions"
    public static Tuple<T2> Tail<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2>(value.Item2);
    }


    public static Tuple<T2, T3> Tail<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2, T3>(value.Item2, value.Item3);
    }

    public static Tuple<T2, T3, T4> Tail<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2, T3, T4>(value.Item2, value.Item3, value.Item4);
    }

    public static Tuple<T2, T3, T4, T5> Tail<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2, T3, T4, T5>(value.Item2, value.Item3, value.Item4, value.Item5);
    }

    public static Tuple<T2, T3, T4, T5, T6> Tail<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2, T3, T4, T5, T6>(value.Item2, value.Item3, value.Item4, value.Item5, value.Item6);
    }

    public static Tuple<T2, T3, T4, T5, T6, T7> Tail<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value", "value should not be null");
        }
        return new Tuple<T2, T3, T4, T5, T6, T7>(value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7);
    }

    //TODO: wat de doen met T8 en hoger

    #endregion
}