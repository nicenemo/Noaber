using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;


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
}