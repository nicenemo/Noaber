using System;
using System.Diagnostics.Contracts;

public static partial class TupleExtensions
{
  /// <summary>
  ///   Firsts element of a Tuple, alias of <c>Item1</c> property of the Tuple
  ///   <para><b>PRECONDITION:</b>value is not null</para>
  /// </summary>
  /// <typeparam name="T1">The type of the the first element of the Tuple</typeparam>
  /// <param name="value">tuple to get the first element from</param>
  /// <returns>The value of of Item1</returns>
  /// <exception cref="System.ArgumentNullException">value;value should not be null</exception>
  public static T1 First<T1>(this Tuple<T1> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }


  public static T1 First<T1, T2>(this Tuple<T1, T2> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }


  public static T1 First<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }


  public static T1 First<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }


  public static T1 First<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }


  public static T1 First<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }


  public static T1 First<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Item1;
  }
}