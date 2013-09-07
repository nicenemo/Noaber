using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections;

/// <summary>
///   Extensions for Tuples
/// </summary>
public static partial class TupleExtensions
{
  //REMARK: AsEnumerable seems to be required for C# because C# demands instance an Instance Method for MoveNext and a Property for Current.
  //VB.NET allows the Use of an extension Method for MoveNext and and Extension Method for Current.
  //And since we implemented AsEnumerable with yield we loose the ability to for each over tuples in VB.NET withouth AsEnumerable too;(
  //This bunch of methods makes it possible to drop the AsEnumerable in VB.NET For Each loops

  public static IEnumerator GetEnumerator<T>(this Tuple<T> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }

  public static IEnumerator GetEnumerator<T1, T2>(this Tuple<T1, T2> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }

  public static IEnumerator GetEnumerator<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }

  public static IEnumerator GetEnumerator<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }


  public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }

  public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }

  public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    return value.AsEnumerable().GetEnumerator();
  }
}
