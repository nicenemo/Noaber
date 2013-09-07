﻿using System;
using System.Diagnostics.Contracts;
using System.Linq;
/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static double Norm<T1>(this Tuple<T1> value, Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm<T1, T2>(this Tuple<T1, T2> value, Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object, double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }
}
