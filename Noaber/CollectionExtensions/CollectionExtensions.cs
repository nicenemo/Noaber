using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;


public static partial class CollectionExtensions
{
  public static short Sum(this IEnumerable<short> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Aggregate((short acc, short v) => (short) (acc + v));
  }

  public static double Average(this IEnumerable<short> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Sum()/value.Count();
  }

  public static short Sum(this IEnumerable<short?> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);

    return value.Aggregate((short? acc, short? v) =>(short?) (acc + (v.HasValue ? v.Value : 0))).Value;
  }

  public static double Average(this IEnumerable<short?> value)
  {
    Contract.Requires<ArgumentNullException>(value != null);
    return value.Sum()/value.Count();
  }

  public static short? Aggregate(this IEnumerable<short?> value, Func<short?, short?, short?> func)
  {
    short? acc = 0;
    foreach (short? v in value)
    {
      acc = func(acc, v);
    }
    return acc;
  }
}