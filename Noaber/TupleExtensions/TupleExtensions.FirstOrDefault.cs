using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public static partial class TupleExtensions
{
    #region "Tuples FirstOrDefault Extensions"
    //TODO: spec er opnalezen

    public static T1 FirstOrDefault<T1>(this Tuple<T1> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }


    public static T1 FirstOrDefault<T1, T2>(this Tuple<T1, T2> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }


    public static T1 FirstOrDefault<T1, T2, T3>(this Tuple<T1, T2, T3> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }


    public static T1 FirstOrDefault<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }


    public static T1 FirstOrDefault<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }


    public static T1 FirstOrDefault<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }


    public static T1 FirstOrDefault<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    {
        if (value == null)
        {
            T1 res = default(T1);
            return res;
        }
        return value.Item1;
    }

    #endregion
}