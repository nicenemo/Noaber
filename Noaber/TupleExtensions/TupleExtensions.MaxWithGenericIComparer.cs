using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;



/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  public static object Max<T1>(this Tuple<T1> value,IComparer<object> comparer)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(comparer != null);
   return (from v in value select v).Max(comparer);
  }

  public static object Max<T1, T2>(this Tuple<T1, T2> value, IComparer<object> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      Contract.Requires<ArgumentNullException>(comparer != null);
      return (from v in value select v).Max(comparer);
  }

  public static object Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, IComparer<object> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      Contract.Requires<ArgumentNullException>(comparer != null);
      return (from v in value select v).Max(comparer);
  }

  public static object Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, IComparer<object> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      Contract.Requires<ArgumentNullException>(comparer != null);
      return (from v in value select v).Max(comparer);
  }

  public static object Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, IComparer<object> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      Contract.Requires<ArgumentNullException>(comparer != null);
      return (from v in value select v).Max(comparer);
  }

  public static object Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, IComparer<object> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      Contract.Requires<ArgumentNullException>(comparer != null);
      return (from v in value select v).Max(comparer);
  }

  public static object Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, IComparer<object> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      Contract.Requires<ArgumentNullException>(comparer != null);
      return (from v in value select v).Max(comparer);
  }
}