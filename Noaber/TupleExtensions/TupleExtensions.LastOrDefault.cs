using System;

public static partial class TupleExtensions
{
  public static T1 LastOrDefault<T1>(this Tuple<T1> value)
  {
    if (value == null)
    {
      T1 res = default(T1);
      return res;
    }
    return value.Item1;
  }


  public static T2 LastOrDefault<T1, T2>(this Tuple<T1, T2> value)
  {
    if (value == null)
    {
      T2 res = default(T2);
      return res;
    }
    return value.Item2;
  }


  public static T3 LastOrDefault<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    if (value == null)
    {
      T3 res = default(T3);
      return res;
    }
    return value.Item3;
  }


  public static T4 LastOrDefault<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    if (value == null)
    {
      T4 res = default(T4);
      return res;
    }
    return value.Item4;
  }


  public static T5 LastOrDefault<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    if (value == null)
    {
      T5 res = default(T5);
      return res;
    }
    return value.Item5;
  }


  public static T6 LastOrDefault<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    if (value == null)
    {
      T6 res = default(T6);
      return res;
    }
    return value.Item6;
  }


  public static T7 LastOrDefault<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    if (value == null)
    {
      T7 res = default(T7);
      return res;
    }
    return value.Item7;
  }
}