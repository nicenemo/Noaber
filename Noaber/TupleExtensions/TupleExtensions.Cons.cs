using System;
using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static Tuple<T1, T2> Cons<T1, T2>(this T1 value, Tuple<T2> tuple)
  {
    Contract.Requires<ArgumentNullException>(tuple != null);
    return new Tuple<T1, T2>(value, tuple.Item1);
  }


  public static Tuple<T1, T2, T3> Cons<T1, T2, T3>(this T1 value, Tuple<T2, T3> tuple)
  {
    Contract.Requires<ArgumentNullException>(tuple != null);
    return new Tuple<T1, T2, T3>(value, tuple.Item1, tuple.Item2);
  }


  public static Tuple<T1, T2, T3, T4> Cons<T1, T2, T3, T4>(this T1 value, Tuple<T2, T3, T4> tuple)
  {
    Contract.Requires<ArgumentNullException>(tuple != null);
    return new Tuple<T1, T2, T3, T4>(value, tuple.Item1, tuple.Item2, tuple.Item3);
  }


  public static Tuple<T1, T2, T3, T4, T5> Cons<T1, T2, T3, T4, T5>(this T1 value, Tuple<T2, T3, T4, T5> tuple)
  {
    Contract.Requires<ArgumentNullException>(tuple != null);
    return new Tuple<T1, T2, T3, T4, T5>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
  }


  public static Tuple<T1, T2, T3, T4, T5, T6> Cons<T1, T2, T3, T4, T5, T6>(this T1 value,
    Tuple<T2, T3, T4, T5, T6> tuple)
  {
    Contract.Requires<ArgumentNullException>(tuple != null);
    return new Tuple<T1, T2, T3, T4, T5, T6>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
  }


  public static Tuple<T1, T2, T3, T4, T5, T6, T7> Cons<T1, T2, T3, T4, T5, T6, T7>(this T1 value,
    Tuple<T2, T3, T4, T5, T6, T7> tuple)
  {
    Contract.Requires<ArgumentNullException>(tuple != null);
    return new Tuple<T1, T2, T3, T4, T5, T6, T7>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5,
      tuple.Item6);
  }
}