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
  //TODO: decide whether to bring for each withouth AsEnumerable  back in VB.NET.

  public static IEnumerable AsEnumerable<T>(this Tuple<T> value)
  {
    for (int i = 0; i < value.Length(); i++ ) yield return value.Item(i);
   }

  public static IEnumerable AsEnumerable<T1, T2>(this Tuple<T1, T2> value)
  {
    for (int i = 0; i < value.Length(); i++) yield return value.Item(i);
  }

  public static IEnumerable AsEnumerable<T1, T2, T3>(this Tuple<T1, T2, T3> value)
  {
    for (int i = 0; i < value.Length(); i++) yield return value.Item(i);
  }

  public static IEnumerable AsEnumerable<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
  {
    for (int i = 0; i < value.Length(); i++ ) yield return value.Item(i);
  }


  public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
  {
    for (int i = 0; i < value.Length(); i++) yield return value.Item(i);
  }

  public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
  {
    for (int i = 0; i < value.Length(); i++) yield return value.Item(i);
  }

  public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
  {
    for (int i = 0; i < value.Length(); i++) yield return value.Item(i);
  }
}