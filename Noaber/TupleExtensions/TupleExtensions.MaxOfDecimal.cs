﻿using System;
using System.Linq;

using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static decimal Max<T1>(this Tuple<T1> value, Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    return func(value.Item1);
  }

  public static decimal Max<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return (from v in value select func(v)).Max();
  }

  public static decimal Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return (from v in value select func(v)).Max();
  }

  public static decimal Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return (from v in value select func(v)).Max();
  }

  public static decimal Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return (from v in value select func(v)).Max();
  }

  public static decimal Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return (from v in value select func(v)).Max();
  }

  public static decimal Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object, decimal> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return (from v in value select func(v)).Max();
  }
}