using System;

public static partial class TupleExtensions
{
  public static T1 LastOrDefault<T1>(this Tuple<T1> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T2 LastOrDefault<T1, T2>(this Tuple<T1, T2> value)
  {
    return value != null ? value.Item2 : default(T2);
  }


  public static T3 LastOrDefault<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    return value != null ? value.Item3 : default(T3);
  }


  public static T4 LastOrDefault<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    return value != null ? value.Item4 : default(T4);
  }


  public static T5 LastOrDefault<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    return value != null ? value.Item5 : default(T5);
  }


  public static T6 LastOrDefault<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    return value != null ? value.Item6 : default(T6);
  }


  public static T7 LastOrDefault<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    return value != null ? value.Item7 : default(T7);
  }
}