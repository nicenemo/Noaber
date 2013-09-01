using System;
using System.Diagnostics.Contracts;

public static partial class TupleExtensions
{
  public static Tuple<T2> Tail<T1, T2>(this Tuple<T1, T2> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2>(value.Item2);
  }


  public static Tuple<T2, T3> Tail<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2, T3>(value.Item2, value.Item3);
  }

  public static Tuple<T2, T3, T4> Tail<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2, T3, T4>(value.Item2, value.Item3, value.Item4);
  }

  public static Tuple<T2, T3, T4, T5> Tail<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2, T3, T4, T5>(value.Item2, value.Item3, value.Item4, value.Item5);
  }

  public static Tuple<T2, T3, T4, T5, T6> Tail<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2, T3, T4, T5, T6>(value.Item2, value.Item3, value.Item4, value.Item5, value.Item6);
  }

  public static Tuple<T2, T3, T4, T5, T6, T7> Tail<T1, T2, T3, T4, T5, T6, T7>(
    this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<T2, T3, T4, T5, T6, T7>(value.Item2, value.Item3, value.Item4, value.Item5, value.Item6,
      value.Item7);
  }

  //TODO: wat de doen met T8 en hoger
}