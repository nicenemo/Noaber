using System;
using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static Tuple<TResult> Cast<TResult, T1>(this Tuple<T1> value)
    where T1 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult>(value.Item1);
  }

  public static Tuple<TResult, TResult> Cast<TResult, T1, T2>(this Tuple<T1, T2> value)
    where T1 : TResult
    where T2 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult, TResult>(value.Item1, value.Item2);
  }

  public static Tuple<TResult, TResult, TResult> Cast<TResult, T1, T2, T3>(this Tuple<T1, T2, T3> value)
    where T1 : TResult
    where T2 : TResult
    where T3 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult, TResult, TResult>(value.Item1, value.Item2, value.Item3);
  }

  public static Tuple<TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
    where T1 : TResult
    where T2 : TResult
    where T3 : TResult
    where T4 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult, TResult, TResult, TResult>(value.Item1, value.Item2,
      value.Item3, value.Item4);
  }

  public static Tuple<TResult, TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4, T5>(
    this Tuple<T1, T2, T3, T4, T5> value)
    where T1 : TResult
    where T2 : TResult
    where T3 : TResult
    where T4 : TResult
    where T5 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult, TResult, TResult, TResult, TResult>(value.Item1, value.Item2,
      value.Item3, value.Item4, value.Item5);
  }

  public static Tuple<TResult, TResult, TResult, TResult, TResult, TResult> Cast<TResult, T1, T2, T3, T4, T5, T6>(
    this Tuple<T1, T2, T3, T4, T5, T6> value)
    where T1 : TResult
    where T2 : TResult
    where T3 : TResult
    where T4 : TResult
    where T5 : TResult
    where T6 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult, TResult, TResult, TResult, TResult, TResult>(value.Item1, value.Item2,
      value.Item3, value.Item4, value.Item5, value.Item6);
  }

  public static Tuple<TResult, TResult, TResult, TResult, TResult, TResult, TResult> Cast
    <TResult, T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
    where T1 : TResult
    where T2 : TResult
    where T3 : TResult
    where T4 : TResult
    where T5 : TResult
    where T6 : TResult
    where T7 : TResult
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return new Tuple<TResult, TResult, TResult, TResult, TResult, TResult, TResult>(value.Item1,
      value.Item2, value.Item3, value.Item4, value.Item5, value.Item6,
      value.Item7);
  }
}