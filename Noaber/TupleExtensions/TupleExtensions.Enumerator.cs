//using System;
//using System.Collections;
//using System.Diagnostics.Contracts;

///// <summary>
/////   Extensions for Tuples
///// </summary>
//public static partial class TupleExtensions
//{
//  public static IEnumerator GetEnumerator<T>(this Tuple<T> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new OneTupleEnumerator<T>(value);
//  }


//  public static IEnumerator GetEnumerator<T1, T2>(this Tuple<T1, T2> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new TwoTupleEnumerator<T1, T2>(value);
//  }


//  public static IEnumerator GetEnumerator<T1, T2, T3>(this Tuple<T1, T2, T3> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new ThreeTupleEnumerator<T1, T2, T3>(value);
//  }


//  public static IEnumerator GetEnumerator<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new FourTupleEnumerator<T1, T2, T3, T4>(value);
//  }


//  public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new FiveTupleEnumerator<T1, T2, T3, T4, T5>(value);
//  }


//  public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new SixTupleEnumerator<T1, T2, T3, T4, T5, T6>(value);
//  }


//  public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
//  {
//    Contract.Requires<ArgumentNullException>(value != null);
//    return new SevenTupleEnumerator<T1, T2, T3, T4, T5, T6, T7>(value);
//  }
//}