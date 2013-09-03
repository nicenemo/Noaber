using System;
using System.Collections.Generic;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{

  public static IEnumerable<TResult> Select<T, TResult>(this Tuple<T> value, Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }

  public static IEnumerable<TResult> Select<T, TResult>(this Tuple<T> value, Func<object, int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i), i);
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, TResult>(this Tuple<T1, T2> value, Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, TResult>(this Tuple<T1, T2> value, Func<object, int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i), i);
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, TResult>(this Tuple<T1, T2, T3> value, Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, TResult>(this Tuple<T1, T2, T3> value, Func<object, int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i), i);
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, TResult>(this Tuple<T1, T2, T3, T4> value, Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, TResult>(this Tuple<T1, T2, T3, T4> value,
    Func<object, int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i), i);
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, TResult>(this Tuple<T1, T2, T3, T4, T5> value,
    Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, TResult>(this Tuple<T1, T2, T3, T4, T5> value,
    Func<object, int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i), i);
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, TResult>(this Tuple<T1, T2, T3, T4, T5, T6> value,
    Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, TResult>(this Tuple<T1, T2, T3, T4, T5, T6> value,
    Func<object, int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i), i);
    }
  }

  public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, TResult>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i));
    }
  }


  public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, TResult>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object,int, TResult> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      yield return func(value.Item(i),i);
    }
  }
}