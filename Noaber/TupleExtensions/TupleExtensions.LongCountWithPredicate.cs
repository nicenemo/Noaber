using System;
using System.Diagnostics.Contracts;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static long LongCount<T1>(this Tuple<T1> value, Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    if (predicate(value.Item1))
    {
      return 1L;
    }
    return 0L;
  }

  public static long LongCount<T1, T2>(this Tuple<T1, T2> value, Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    long LongCount = 0;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      if (predicate(v))
      {
        LongCount++;
      }
    }
    return LongCount;
  }

  public static long LongCount<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    long LongCount = 0;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      if (predicate(v))
      {
        LongCount++;
      }
    }
    return LongCount;
  }

  public static long LongCount<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    long LongCount = 0;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      if (predicate(v))
      {
        LongCount++;
      }
    }
    return LongCount;
  }


  public static long LongCount<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    long LongCount = 0;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      if (predicate(v))
      {
        LongCount++;
      }
    }
    return LongCount;
  }

  public static long LongCount<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value,
    Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    long LongCount = 0;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      if (predicate(v))
      {
        LongCount++;
      }
    }
    return LongCount;
  }

  public static long LongCount<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object, Boolean> predicate)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(predicate != null);

    long LongCount = 0;
    int i = value.Count();
    while (0 < i)
    {
      i--;
      object v = value.Item(i);
      if (predicate(v))
      {
        LongCount++;
      }
    }
    return LongCount;
  }
}