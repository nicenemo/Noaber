using System;
/// <summary>
/// Extension methods for IComparable
/// </summary>
 public static class ComparableExtensions
 {
     /// <summary>
     /// Returns the Maximum of the two arguments
     /// </summary>
     /// <param name="value">IComparable value to compare an object to</param>
     /// <param name="obj">object to compare to</param>
     /// <returns>value if and only if value.CompareTo(obj) &gt;0, otherwise obj</returns>
      public static object Max(this IComparable value, object obj){
            return value.CompareTo(obj) >0?value:obj;
      }
      /// <summary>
      /// Returns the Minimum of the two arguments
      /// </summary>
      /// <param name="value">Icomparable value to compare an object to</param>
      /// <param name="obj"></param>
      /// <returns>value if and only if value.CompareTo(obj) &lt;0, otherewise obj</returns>
      public static object Min(this IComparable value, object obj){
            return value.CompareTo(obj) >0?value:obj;
      }
      /// <summary>
      /// Returns the Minimum of the two arguments
      /// </summary>
      /// <param name="value">Icomparable value to compare an object to</param>
      /// <param name="obj"></param>
      /// <returns>value if and only if value.CompareTo(obj) &lt;0, otherewise obj</returns>
      public static T Max<T>(this IComparable<T> value, T obj)
      {
          return value.CompareTo(obj)>0? (T) value:obj;
      }
      /// <summary>
      /// Returns the Minimum of the two arguments
      /// </summary>
      /// <param name="value">Icomparable value to compare an object to</param>
      /// <param name="obj"></param>
      /// <returns>value if and only if value.CompareTo(obj) &lt;0, otherewise obj</returns>
      public static T Min<T>(this IComparable<T> value, T obj)
      {
          return value.CompareTo(obj) < 0 ? (T)value : obj;
      }
 }
