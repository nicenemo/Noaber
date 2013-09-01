using System;
using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static Tuple<T1> Reverse<T1>(this Tuple<T1> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T1>(value.Item1);
  }


  public static Tuple<T2, T1> Reverse<T1, T2>(this Tuple<T1, T2> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2, T1>(value.Item2, value.Item1);
  }


  public static Tuple<T3, T2, T1> Reverse<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);

    return new Tuple<T3, T2, T1>(value.Item3, value.Item2, value.Item1);
  }


  public static Tuple<T4, T3, T2, T1> Reverse<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T4, T3, T2, T1>(value.Item4, value.Item3, value.Item2, value.Item1);
  }


  public static Tuple<T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T5, T4, T3, T2, T1>(value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
  }


  public static Tuple<T6, T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T6, T5, T4, T3, T2, T1>(value.Item6, value.Item5, value.Item4, value.Item3, value.Item2,
      value.Item1);
  }


  public static Tuple<T7, T6, T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5, T6, T7>(
    this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T7, T6, T5, T4, T3, T2, T1>(value.Item7, value.Item6, value.Item5, value.Item4, value.Item3,
      value.Item2, value.Item1);
  }
}