using System;
using System.Collections.Generic;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{

  public static IEnumerable<object> Where<T>(this Tuple<T> value, Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if ( func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    
    }
  }

  public static IEnumerable<object> Where<T>(this Tuple<T> value, Func<object, int, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i),i))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2>(this Tuple<T1, T2> value, Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2>(this Tuple<T1, T2> value, Func<object, int, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i), i))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i),i))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value,
    Func<object, int, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i), i))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value,
    Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value,
    Func<object, int, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i), i))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value,
    Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value,
    Func<object, int,bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i),i))
      {
        yield return value.Item(i);
      }
    }
  }

  public static IEnumerable<object> Where<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i)))
      {
        yield return value.Item(i);
      }
    }
  }


  public static IEnumerable<object> Where<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value,
    Func<object, int, bool> func)
  {
    int i = -1;
    while (++i < value.Length())
    {
      if (func(value.Item(i), i))
      {
        yield return value.Item(i);
      }
    }
  }
}