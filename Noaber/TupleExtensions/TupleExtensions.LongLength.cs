using System;
using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static long LongLength<T1>(this Tuple<T1> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 1L;
  }


  public static long LongLength<T1, T2>(this Tuple<T1, T2> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 2L;
  }


  public static long LongLength<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 3L;
  }


  public static long LongLength<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 4L;
  }


  public static long LongLength<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 5L;
  }


  public static long LongLength<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 6L;
  }


  public static long LongLength<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return 7L;
  }
}