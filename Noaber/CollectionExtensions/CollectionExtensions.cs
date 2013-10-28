using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public static  class CollectionExtensions
{
  public static short Sum(this IEnumerable<short> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Aggregate((acc, v) => (short) (acc + v));
  }

  public static double Average(this IEnumerable<short> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    //TODO:maybe accept null
    var enumerable = value.ToArray();
    return enumerable.Sum()/(double)enumerable.Count();
  }

  public static short? Sum(this IEnumerable<short?> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Aggregate((acc, v) =>(short?) (acc + (v.HasValue ? v.Value : 0)));
  }

  public static double Average(this IEnumerable<short?> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    //TODO: maybe accept null
    var enumerable =  value.ToArray();
    var sum = enumerable.Sum();
    var count = enumerable.Count();
    double res;
    if (sum.HasValue && count != 0)
    {
      res= sum.Value / (double)count;
    }
    else
    {
      res= 0;
    }
    return res;
  }

  public static short? Aggregate(this IEnumerable<short?> value, Func<short?, short?, short?> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    short? acc = 0;
    foreach (short? v in value)
    {
      acc = func(acc, v);
    }
    return acc;
  }

  public static double Norm<T>(this IEnumerable<T> value, Func<T, Double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return Math.Sqrt((from v in value select Math.Pow(func(v), 2.0)).Sum());
  }

  public static double Norm(this System.Collections.IEnumerable value, Func<object, Double> func)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    Contract.Requires<ArgumentNullException>(func != null);
    return value.Cast<object>().Norm(func);
  }
   
   /// <summary>
   /// Returns the maximum element out of an generic IEnumerable using an IComparer.
   /// </summary>
  /// <typeparam name="TSource">Type of the elements in the IEnumerable</typeparam>
   /// <param name="value">enumerable to get the maximum value from</param>
   /// <param name="comparer">comparer to use</param>
   /// <returns>the maximum value from value if any</returns>
  public static TSource Max<TSource>(this IEnumerable<TSource> value, IComparer<TSource> comparer) 
  {
      Contract.Requires<ArgumentNullException>(value != null);
      return value.Aggregate<TSource>((acc, obj) => comparer.Compare(acc, obj) > 0 ? acc : obj);
  }

  /// <summary>
  /// Returns the minimum element out of an generic IEnumerable sing an IComparer.
  /// </summary>
  /// <typeparam name="TSource">Type of the elements in the IEnumerable</typeparam>
  /// <param name="value">enumerable to get the minimum value from</param>
  /// <param name="comparer">comparer to use</param>
  /// <returns>the minimum value from value if any</returns>
  public static TSource Min<TSource>(this IEnumerable<TSource> value, IComparer<TSource> comparer)
  {
      Contract.Requires<ArgumentNullException>(value != null);
      return value.Aggregate<TSource>((acc, obj) => comparer.Compare(acc, obj) < 0 ? acc : obj);
  }
}