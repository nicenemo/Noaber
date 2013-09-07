using System;

public static partial class TupleExtensions
{
  //TODO: spec er opnalezen

  public static T1 FirstOrDefault<T1>(this Tuple<T1> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T1 FirstOrDefault<T1, T2>(this Tuple<T1, T2> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T1 FirstOrDefault<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T1 FirstOrDefault<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T1 FirstOrDefault<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T1 FirstOrDefault<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    return value != null ? value.Item1 : default(T1);
  }


  public static T1 FirstOrDefault<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    return value != null ? value.Item1 : default(T1);
  }
}