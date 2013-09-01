using System;
using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static int Min<T1>(this Tuple<T1> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    return func(value.Item1);
  }

  public static int Min<T1, T2>(this Tuple<T1, T2> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    int min = int.MaxValue;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      int fValue = func(v);
      min = Math.Min(min, fValue);
    }
    return min;
  }

  public static int Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    int min = int.MaxValue;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      int fValue = func(v);
      min = Math.Min(min, fValue);
    }
    return min;
  }

  public static int Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    int min = int.MaxValue;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      int fValue = func(v);
      min = Math.Min(min, fValue);
    }
    return min;
  }

  public static int Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    int min = int.MaxValue;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      int fValue = func(v);
      min = Math.Min(min, fValue);
    }
    return min;
  }

  public static int Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    int min = int.MaxValue;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      int fValue = func(v);
      min = Math.Min(min, fValue);
    }
    return min;
  }

  public static int Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);

    int min = int.MaxValue;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      int fValue = func(v);
      min = Math.Min(min, fValue);
    }
    return min;
  }
}