using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

/// <summary>
/// Extensions for Tuples
/// </summary>
    public static class TuplesExtensions
    {

        #region "Tuples tail Extensions"
        public static Tuple<T2> Tail<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2>(value.Item2);
        }


        public static Tuple<T2, T3> Tail<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2, T3>(value.Item2, value.Item3);
        }

        public static Tuple<T2, T3, T4> Tail<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2, T3, T4>(value.Item2, value.Item3, value.Item4);
        }

        public static Tuple<T2, T3, T4, T5> Tail<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2, T3, T4, T5>(value.Item2, value.Item3, value.Item4, value.Item5);
        }

        public static Tuple<T2, T3, T4, T5, T6> Tail<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2, T3, T4, T5, T6>(value.Item2, value.Item3, value.Item4, value.Item5, value.Item6);
        }

        public static Tuple<T2, T3, T4, T5, T6, T7> Tail<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2, T3, T4, T5, T6, T7>(value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7);
        }

        //TODO: wat de doen met T8 en hoger

        #endregion

        #region "Tuples First Extensions"
        /// <summary>
        /// Firsts element of a Tuple, alias of <c>Item1</c> property of the Tuple
        /// <para><b>PRECONDITION:</b>value is not null</para>
        /// </summary>
        /// <typeparam name="T1">The type of the the first element of the Tuple</typeparam>
        /// <param name="value">tuple to get the first element from</param>
        /// <returns>The value of of Item1</returns>
        /// <exception cref="System.ArgumentNullException">value;value should not be null</exception>
        public static T1 First<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T1 First<T1, T2>(this  Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T1 First<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T1 First<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T1 First<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T1 First<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T1 First<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }

        #endregion

        #region "Tuples FirstOrDefault Extensions"
        //TODO: spec er opnalezen

        public static T1 FirstOrDefault<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T1 FirstOrDefault<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T1 FirstOrDefault<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T1 FirstOrDefault<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T1 FirstOrDefault<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T1 FirstOrDefault<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T1 FirstOrDefault<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }

        #endregion

        #region "Tuples Last Extensions"

        public static T1 Last<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item1;
        }


        public static T2 Last<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item2;
        }


        public static T3 Last<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item3;
        }


        public static T4 Last<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item4;
        }


        public static T5 Last<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item5;
        }


        public static T6 Last<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item6;
        }


        public static T7 Last<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return value.Item7;
        }

        #endregion

        #region "Tuples LastOrDefault Extensions"

        public static T1 LastOrDefault<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                T1 res = default(T1);
                return res;
            }
            return value.Item1;
        }


        public static T2 LastOrDefault<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                T2 res = default(T2);
                return res;
            }
            return value.Item2;
        }


        public static T3 LastOrDefault<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                T3 res = default(T3);
                return res;
            }
            return value.Item3;
        }


        public static T4 LastOrDefault<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                T4 res = default(T4);
                return res;
            }
            return value.Item4;
        }


        public static T5 LastOrDefault<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                T5 res = default(T5);
                return res;
            }
            return value.Item5;
        }


        public static T6 LastOrDefault<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                T6 res = default(T6);
                return res;
            }
            return value.Item6;
        }


        public static T7 LastOrDefault<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                T7 res = default(T7);
                return res;
            }
            return value.Item7;
        }

        #endregion

        #region "Cons functions for tuples"

        public static Tuple<T1, T2> Cons<T1, T2>(this T1 value, Tuple<T2> tuple)
        {
            if (tuple == null)
            {
                throw new ArgumentNullException("tuple", "tuple should not be null");
            }
            return new Tuple<T1, T2>(value, tuple.Item1);
        }


        public static Tuple<T1, T2, T3> Cons<T1, T2, T3>(this T1 value, Tuple<T2, T3> tuple)
        {
            if (tuple == null)
            {
                throw new ArgumentNullException("tuple", "tuple should not be null");
            }
            return new Tuple<T1, T2, T3>(value, tuple.Item1, tuple.Item2);
        }


        public static Tuple<T1, T2, T3, T4> Cons<T1, T2, T3, T4>(this T1 value, Tuple<T2, T3, T4> tuple)
        {
            if (tuple == null)
            {
                throw new ArgumentNullException("tuple", "tuple should not be null");
            }
            return new Tuple<T1, T2, T3, T4>(value, tuple.Item1, tuple.Item2, tuple.Item3);
        }


        public static Tuple<T1, T2, T3, T4, T5> Cons<T1, T2, T3, T4, T5>(this T1 value, Tuple<T2, T3, T4, T5> tuple)
        {
            if (tuple == null)
            {
                throw new ArgumentNullException("tuple", "tuple should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6> Cons<T1, T2, T3, T4, T5, T6>(this T1 value, Tuple<T2, T3, T4, T5, T6> tuple)
        {
            if (tuple == null)
            {
                throw new ArgumentNullException("tuple", "tuple should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Cons<T1, T2, T3, T4, T5, T6, T7>(this T1 value, Tuple<T2, T3, T4, T5, T6, T7> tuple)
        {
            if (tuple == null)
            {
                throw new ArgumentNullException("tuple", "tuple should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(value, tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        #endregion

        #region "Tuples Reverse Extensions"

        public static Tuple<T1> Reverse<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T1>(value.Item1);
        }


        public static Tuple<T2, T1> Reverse<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T2, T1>(value.Item2, value.Item1);
        }


        public static Tuple<T3, T2, T1> Reverse<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }

            return new Tuple<T3, T2, T1>(value.Item3, value.Item2, value.Item1);
        }


        public static Tuple<T4, T3, T2, T1> Reverse<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T4, T3, T2, T1>(value.Item4, value.Item3, value.Item2, value.Item1);
        }


        public static Tuple<T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T5, T4, T3, T2, T1>(value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
        }


        public static Tuple<T6, T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T6, T5, T4, T3, T2, T1>(value.Item6, value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
        }


        public static Tuple<T7, T6, T5, T4, T3, T2, T1> Reverse<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return new Tuple<T7, T6, T5, T4, T3, T2, T1>(value.Item7, value.Item6, value.Item5, value.Item4, value.Item3, value.Item2, value.Item1);
        }

        #endregion

        #region "Concat extensions for two tuples with a 1 tuple for the first argument"

        public static Tuple<T1, T2> Concat<T1, T2>(this Tuple<T1> tupleA, Tuple<T2> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2>(tupleA.Item1, tupleB.Item1);
        }


        public static Tuple<T1, T2, T3> Concat<T1, T2, T3>(this Tuple<T1> tupleA, Tuple<T2, T3> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3>(tupleA.Item1, tupleB.Item1, tupleB.Item2);
        }


        public static Tuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this Tuple<T1> tupleA, Tuple<T2, T3, T4> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3);
        }


        public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1> tupleA, Tuple<T2, T3, T4, T5> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(this Tuple<T1> tupleA, Tuple<T2, T3, T4, T5, T6> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1> tupleA, Tuple<T2, T3, T4, T5, T6, T7> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5, tupleB.Item6);
        }
        #endregion

        #region "Concat extensions for two tuples with a 2 "tupleB for the first argument"


        public static Tuple<T1, T2, T3> Concat<T1, T2, T3>(this Tuple<T1, T2> tupleA, Tuple<T3> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3>(tupleA.Item1, tupleA.Item2, tupleB.Item1);
        }


        public static Tuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this Tuple<T1, T2> tupleA, Tuple<T3, T4> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2);
        }


        public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1, T2> tupleA, Tuple<T3, T4, T5> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2> tupleA, Tuple<T3, T4, T5, T6> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2> tupleA, Tuple<T3, T4, T5, T6, T7> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5);
        }
        #endregion

        #region "Concat extensions for two tuples with a 3 tuple for the first argument"


        public static Tuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this Tuple<T1, T2, T3> tupleA, Tuple<T4> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1);
        }


        public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3> tupleA, Tuple<T4, T5> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3> tupleA, Tuple<T4, T5, T6> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2, tupleB.Item3);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3> tupleA, Tuple<T4, T5, T6, T7> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
        }

        #endregion

        #region "Concat extensions for two tuples with a 4 tuple for the first argument"


        public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4> tupleA, Tuple<T5> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4> tupleA, Tuple<T5, T6> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1, tupleB.Item2);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4> tupleA, Tuple<T5, T6, T7> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1, tupleB.Item2, tupleB.Item3);
        }

        #endregion

        #region "Concat extensions for two tuples with a 5 tuple for the first argument"


        public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5> tupleA, Tuple<T6> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleB.Item1);
        }


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5> tupleA, Tuple<T6, T7> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleB.Item1, tupleB.Item2);
        }

        #endregion

        #region "Concat extensions for two tuples with a 6 tuple for the first argument"


        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6> tupleA, Tuple<T7> tupleB)
        {
            if (tupleA == null)
            {
                throw new ArgumentNullException("tupleA", "tupleA should not be null");
            }
            if (tupleB == null)
            {
                throw new ArgumentNullException("tupleB", "tupleB should not be null");
            }
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleA.Item6, tupleB.Item1);
        }

        #endregion

        #region "Item Extensions for Tuples"


        public static object Item<T>(this Tuple<T> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                default:
                    throw new ArgumentOutOfRangeException("index", "index can only be 0");
            }
        }


        public static object Item<T1, T2>(this Tuple<T1, T2> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                case 1:
                    return value.Item2;
                default:
                    throw new ArgumentOutOfRangeException("index", "index can only be 0 or 1");
            }
        }


        public static object Item<T1, T2, T3>(this Tuple<T1, T2, T3> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                case 1:
                    return value.Item2;
                case 2:
                    return value.Item3;
                default:
                    throw new ArgumentOutOfRangeException("index", "index must between 0 and  2, inclusive");
            }
        }


        public static object Item<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                case 1:
                    return value.Item2;
                case 2:
                    return value.Item3;
                case 3:
                    return value.Item4;
                default:
                    throw new ArgumentOutOfRangeException("index", "index must between 0 and  3, inclusive");
            }
        }


        public static object Item<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                case 1:
                    return value.Item2;
                case 2:
                    return value.Item3;
                case 3:
                    return value.Item4;
                case 4:
                    return value.Item5;
                default:
                    throw new ArgumentOutOfRangeException("index", "index must between 0 and  4, inclusive");
            }
        }


        public static object Item<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                case 1:
                    return value.Item2;
                case 2:
                    return value.Item3;
                case 3:
                    return value.Item4;
                case 4:
                    return value.Item5;
                case 5:
                    return value.Item6;
                default:
                    throw new ArgumentOutOfRangeException("index", "index must between 0 and  5, inclusive");
            }
        }


        public static object Item<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, int index)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            switch (index)
            {
                case 0:
                    return value.Item1;
                case 1:
                    return value.Item2;
                case 2:
                    return value.Item3;
                case 3:
                    return value.Item4;
                case 4:
                    return value.Item5;
                case 5:
                    return value.Item6;
                case 6:
                    return value.Item7;
                default:
                    throw new ArgumentOutOfRangeException("index", "index must between 0 and  6, inclusive");
            }
        }
        #endregion
        #region "Length"

        public static int Length<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 1;
        }


        public static int Length<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 2;
        }


        public static int Length<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 3;
        }


        public static int Length<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 4;
        }


        public static int Length<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 5;
        }


        public static int Length<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 6;
        }


        public static int Length<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 7;
        }
        #endregion
      
        #region "LongLength"

        public static long LongLength<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 1L;
        }


        public static long LongLength<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 2L;
        }


        public static long LongLength<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 3L;
        }


        public static long LongLength<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 4L;
        }


        public static long LongLength<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 5L;
        }


        public static long LongLength<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 6L;
        }


        public static long LongLength<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 7L;
        }
        #endregion

        #region "Count"

        public static int Count<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 1;
        }


        public static int Count<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 2;
        }


        public static int Count<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 3;
        }


        public static int Count<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 4;
        }


        public static int Count<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 5;
        }


        public static int Count<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 6;
        }


        public static int Count<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 7;
        }
        #endregion

        #region "LongCount"

        public static long LongCount<T1>(this Tuple<T1> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 1L;
        }


        public static long LongCount<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 2L;
        }


        public static long LongCount<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 3L;
        }


        public static long LongCount<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 4L;
        }


        public static long LongCount<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 5L;
        }


        public static long LongCount<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 6L;
        }


        public static long LongCount<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value should not be null");
            }
            return 7L;
        }
        #endregion

        #region "Count with predicate"

        public static int Count<T1>(this Tuple<T1>value,Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate","predicate is null");
            }


            if (predicate(value.Item1))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int Count<T1,T2>(this Tuple<T1,T2> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            int count=0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    count++;
                }
            }
            return count;
        }

        public static int Count<T1, T2,T3>(this Tuple<T1, T2,T3> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            int count = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    count++;
                }
            }
            return count;
        }

        public static int Count<T1, T2, T3,T4>(this Tuple<T1, T2, T3,T4> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            int count = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    count++;
                }
            }
            return count;
        }


        public static int Count<T1, T2, T3, T4,T5>(this Tuple<T1, T2, T3, T4,T5> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            int count = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    count++;
                }
            }
            return count;
        }

        public static int Count<T1, T2, T3, T4, T5,T6>(this Tuple<T1, T2, T3, T4, T5,T6> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            int count = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    count++;
                }
            }
            return count;
        }

        public static int Count<T1, T2, T3, T4, T5, T6,T7>(this Tuple<T1, T2, T3, T4, T5, T6,T7> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            int count = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

        #region "LongCount with predicate"

        public static long LongCount<T1>(this Tuple<T1> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            if (predicate(value.Item1))
            {
                return 1L;
            }
            else
            {
                return 0L;
            }
        }

        public static long LongCount<T1, T2>(this Tuple<T1, T2> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            long LongCount = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    LongCount++;
                }
            }
            return LongCount;
        }

        public static long LongCount<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            long LongCount = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    LongCount++;
                }
            }
            return LongCount;
        }

        public static long LongCount<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            long LongCount = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    LongCount++;
                }
            }
            return LongCount;
        }


        public static long LongCount<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            long LongCount = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    LongCount++;
                }
            }
            return LongCount;
        }

        public static long LongCount<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            long LongCount = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    LongCount++;
                }
            }
            return LongCount;
        }

        public static long LongCount<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6,T7> value, Func<object, Boolean> predicate)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate is null");
            }

            long LongCount = 0;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                if (predicate(v))
                {
                    LongCount++;
                }
            }
            return LongCount;
        }
        #endregion

        #region "Cast"
        public static Tuple<TResult> Cast<TResult,T1>(this Tuple<T1> value) 
            where T1:TResult
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult>((TResult) value.Item1);   
        }

        public static Tuple<TResult,TResult> Cast<TResult, T1,T2>(this Tuple<T1,T2> value) 
            where T1:TResult 
            where T2:TResult
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult,TResult>((TResult)value.Item1,(TResult) value.Item2);
        }

        public static Tuple<TResult,TResult,TResult> Cast<TResult, T1,T2,T3>(this Tuple<T1,T2,T3> value)
            where T1:TResult 
            where T2:TResult
            where T3:TResult

        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult,TResult,TResult>((TResult)value.Item1,(TResult) value.Item2,(TResult) value.Item3);
        }

        public static Tuple<TResult, TResult, TResult,TResult> Cast<TResult, T1, T2, T3,T4>(this Tuple<T1, T2, T3,T4> value)
            where T1 : TResult
            where T2 : TResult
            where T3 : TResult
            where T4 : TResult
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult, TResult, TResult,TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3,(TResult) value.Item4);
        }

        public static Tuple<TResult, TResult, TResult, TResult,TResult> Cast<TResult, T1, T2, T3, T4,T5>(this Tuple<T1, T2, T3, T4,T5> value)
            where T1 : TResult
            where T2 : TResult
            where T3 : TResult
            where T4 : TResult
            where T5 : TResult
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult, TResult, TResult, TResult,TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4, (TResult) value.Item5);
        }

        public static Tuple<TResult, TResult, TResult, TResult, TResult,TResult> Cast<TResult, T1, T2, T3, T4, T5,T6>(this Tuple<T1, T2, T3, T4, T5,T6> value)
            where T1 : TResult
            where T2 : TResult
            where T3 : TResult
            where T4 : TResult
            where T5 : TResult
            where T6 : TResult
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult, TResult, TResult, TResult, TResult,TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4, (TResult)value.Item5,(TResult) value.Item6);
        }

        public static Tuple<TResult, TResult, TResult, TResult, TResult, TResult,TResult> Cast<TResult, T1, T2, T3, T4, T5, T6,T7>(this Tuple<T1, T2, T3, T4, T5, T6,T7> value)
            where T1 : TResult
            where T2 : TResult
            where T3 : TResult
            where T4 : TResult
            where T5 : TResult
            where T6 : TResult
            where T7 : TResult
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }
            return new Tuple<TResult, TResult, TResult, TResult, TResult,TResult,TResult>((TResult)value.Item1, (TResult)value.Item2, (TResult)value.Item3, (TResult)value.Item4, (TResult)value.Item5,(TResult) value.Item6,(TResult) value.Item7);
        }


        #endregion

        #region "Enumerator Extensions"

        public static IEnumerator GetEnumerator<T>(this Tuple<T> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new OneTupleEnumerator<T>(value);
        }


        public static IEnumerator GetEnumerator<T1, T2>(this Tuple<T1, T2> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new TwoTupleEnumerator<T1, T2>(value);
        }


        public static IEnumerator GetEnumerator<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new ThreeTupleEnumerator<T1, T2, T3>(value);
        }


        public static IEnumerator GetEnumerator<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new FourTupleEnumerator<T1, T2, T3, T4>(value);
        }


        public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new FiveTupleEnumerator<T1, T2, T3, T4, T5>(value);
        }


        public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new SixTupleEnumerator<T1, T2, T3, T4, T5, T6>(value);
        }


        public static IEnumerator GetEnumerator<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            if (value == null)
                throw new ArgumentNullException("value", "value is null");
            return new SevenTupleEnumerator<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        #endregion

        #region "AsEnumerable"
        //REMARK: AsEnumerable seems to be required for C# because C# demands instance an Instance Method for MoveNext and a Property for Current.
        //VB.NET allows the Use of an extension Method for MoveNext and and Extension Method for Current.

        public static IEnumerable AsEnumerable<T>(this Tuple<T> value)
        {
            return new OneTupleEnumerable<T>(value);
        }

        public static IEnumerable AsEnumerable<T1, T2>(this Tuple<T1, T2> value)
        {
            return new TwoTupleEnumerable<T1, T2>(value);
        }

        public static IEnumerable AsEnumerable<T1, T2, T3>(this Tuple<T1, T2, T3> value)
        {
            return new ThreeTupleEnumerable<T1, T2, T3>(value);
        }

        public static IEnumerable AsEnumerable<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value)
        {
            return new FourTupleEnumerable<T1, T2, T3, T4>(value);
        }


        public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value)
        {
            return new FiveTupleEnumerable<T1, T2, T3, T4, T5>(value);
        }

        public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            return new SixTupleEnumerable<T1, T2, T3, T4, T5, T6>(value);
        }

        public static IEnumerable AsEnumerable<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            return new SevenTupleEnumerable<T1, T2, T3, T4, T5, T6, T7>(value);
        }
        #endregion

        #region "Max of Decimal"

        public static decimal Max<T1>(this Tuple<T1> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }
        
        public static decimal Max<T1,T2>(this Tuple<T1,T2> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static decimal Max<T1,T2,T3>(this Tuple<T1, T2,T3> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static decimal Max<T1, T2, T3,T4>(this Tuple<T1, T2, T3,T4> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static decimal Max<T1, T2, T3, T4,T5>(this Tuple<T1, T2, T3, T4,T5> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static decimal Max<T1, T2, T3, T4, T5,T6>(this Tuple<T1, T2, T3, T4, T5,T6> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static decimal Max<T1, T2, T3, T4, T5, T6,T7>(this Tuple<T1, T2, T3, T4, T5, T6,T7> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }
        #endregion

        #region "Min of Decimal"

        public static decimal Min<T1>(this Tuple<T1> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static decimal Min<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static decimal Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static decimal Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static decimal Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static decimal Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static decimal Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }
        #endregion

        #region "Max of Decimal?"

        public static decimal? Max<T1>(this Tuple<T1> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static decimal? Max<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static decimal? Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static decimal? Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static decimal? Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static decimal? Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static decimal? Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? max = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }
        #endregion

        #region "Min of Decimal?"

        public static decimal? Min<T1>(this Tuple<T1> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static decimal? Min<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static decimal? Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static decimal? Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    if (fValue.HasValue)
                    {
                        min = System.Math.Min(min.Value, fValue.Value);
                    }
                }
            }
            return min;
        }

        public static decimal? Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static decimal? Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static decimal? Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? min = decimal.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }
        #endregion

        #region "Max of Integer"

        public static int Max<T1>(this Tuple<T1> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static int Max<T1, T2>(this Tuple<T1, T2> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static int Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static int Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static int Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static int Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static int Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }
        #endregion

        #region "Min of Integer"

        public static int Min<T1>(this Tuple<T1> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static int Min<T1, T2>(this Tuple<T1, T2> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static int Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static int Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static int Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static int Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static int Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }
        #endregion

        #region "Max of Integer?"

        public static int? Max<T1>(this Tuple<T1> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static int? Max<T1, T2>(this Tuple<T1, T2> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static int? Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static int? Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static int? Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static int? Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static int? Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? max = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }
        #endregion

        #region "Min of Integer?"

        public static int? Min<T1>(this Tuple<T1> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static int? Min<T1, T2>(this Tuple<T1, T2> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static int? Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static int? Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    if (fValue.HasValue)
                    {
                        min = System.Math.Min(min.Value, fValue.Value);
                    }
                }
            }
            return min;
        }

        public static int? Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static int? Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static int? Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? min = int.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }
        #endregion

        #region "Max of Long"

        public static long Max<T1>(this Tuple<T1> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static long Max<T1, T2>(this Tuple<T1, T2> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static long Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static long Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static long Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static long Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static long Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }
        #endregion

        #region "Min of Long"

        public static long Min<T1>(this Tuple<T1> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static long Min<T1, T2>(this Tuple<T1, T2> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static long Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static long Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static long Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static long Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static long Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, long> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }
        #endregion

        #region "Max of Long?"

        public static long? Max<T1>(this Tuple<T1> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static long? Max<T1, T2>(this Tuple<T1, T2> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static long? Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static long? Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static long? Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static long? Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static long? Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? max = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }
        #endregion

        #region "Min of Long?"

        public static long? Min<T1>(this Tuple<T1> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static long? Min<T1, T2>(this Tuple<T1, T2> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static long? Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static long? Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    if (fValue.HasValue)
                    {
                        min = System.Math.Min(min.Value, fValue.Value);
                    }
                }
            }
            return min;
        }

        public static long? Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static long? Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static long? Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? min = long.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }
        #endregion

         #region "Max of Double"

        public static double Max<T1>(this Tuple<T1> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }
        
        public static double Max<T1,T2>(this Tuple<T1,T2> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static double Max<T1,T2,T3>(this Tuple<T1, T2,T3> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static double Max<T1, T2, T3,T4>(this Tuple<T1, T2, T3,T4> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static double Max<T1, T2, T3, T4,T5>(this Tuple<T1, T2, T3, T4,T5> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static double Max<T1, T2, T3, T4, T5,T6>(this Tuple<T1, T2, T3, T4, T5,T6> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static double Max<T1, T2, T3, T4, T5, T6,T7>(this Tuple<T1, T2, T3, T4, T5, T6,T7> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }
        #endregion

        #region "Min of Double"

        public static double Min<T1>(this Tuple<T1> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static double Min<T1, T2>(this Tuple<T1, T2> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static double Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static double Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static double Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static double Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static double Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }
        #endregion

        #region "Max of Double?"

        public static double? Max<T1>(this Tuple<T1> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static double? Max<T1, T2>(this Tuple<T1, T2> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static double? Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static double? Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static double? Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static double? Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static double? Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? max = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }
        #endregion

        #region "Min of Double?"

        public static double? Min<T1>(this Tuple<T1> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static double? Min<T1, T2>(this Tuple<T1, T2> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static double? Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static double? Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    if (fValue.HasValue)
                    {
                        min = System.Math.Min(min.Value, fValue.Value);
                    }
                }
            }
            return min;
        }

        public static double? Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static double? Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static double? Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? min = double.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }
        #endregion

        #region "Max of Short"

        public static short Max<T1>(this Tuple<T1> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static short Max<T1, T2>(this Tuple<T1, T2> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static short Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static short Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static short Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static short Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }

        public static short Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                max = System.Math.Max(max, fValue);
            }
            return max;
        }
        #endregion

        #region "Min of Short"

        public static short Min<T1>(this Tuple<T1> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static short Min<T1, T2>(this Tuple<T1, T2> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static short Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static short Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static short Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static short Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }

        public static short Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
                min = System.Math.Min(min, fValue);
            }
            return min;
        }
        #endregion

        #region "Max of Short?"

        public static short? Max<T1>(this Tuple<T1> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static short? Max<T1, T2>(this Tuple<T1, T2> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static short? Max<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static short? Max<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static short? Max<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static short? Max<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }

        public static short? Max<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? max = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    max = System.Math.Max(max.Value, fValue.Value);
                }
            }
            return max;
        }
        #endregion

        #region "Min of Short?"

        public static short? Min<T1>(this Tuple<T1> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static short? Min<T1, T2>(this Tuple<T1, T2> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static short? Min<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static short? Min<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    if (fValue.HasValue)
                    {
                        min = System.Math.Min(min.Value, fValue.Value);
                    }
                }
            }
            return min;
        }

        public static short? Min<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static short? Min<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }

        public static short? Min<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? min = short.MaxValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    min = System.Math.Min(min.Value, fValue.Value);
                }
            }
            return min;
        }
        #endregion
        //
        #region "Sum of Decimal"

        public static decimal Sum<T1>(this Tuple<T1> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static decimal Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static decimal Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static decimal Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static decimal Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static decimal Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static decimal Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, decimal> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }
        #endregion

        #region "Sum of Decimal?"

        public static decimal? Sum<T1>(this Tuple<T1> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static decimal? Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static decimal? Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static decimal? Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static decimal? Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static decimal? Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static decimal? Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, decimal?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            decimal? sum = decimal.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                decimal? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }
        #endregion

        #region "Sum of Integer"

        public static int Sum<T1>(this Tuple<T1> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static int Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static int Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static int Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static int Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static int Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static int Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }
        #endregion

        #region "Sum of Integer?"

        public static int? Sum<T1>(this Tuple<T1> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static int? Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static int? Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static int? Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static int? Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static int? Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static int? Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, int?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            int? sum = int.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                int? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }
        #endregion

        #region "Sum of Long?"

        public static long? Sum<T1>(this Tuple<T1> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static long? Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? sum = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static long? Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? sum = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static long? Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? sum = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static long? Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? sum = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static long? Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? sum = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static long? Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, long?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            long? sum = long.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                long? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }
        #endregion

        #region "Sum of Double"

        public static double Sum<T1>(this Tuple<T1> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static double Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static double Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static double Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static double Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static double Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static double Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, double> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }
        #endregion

        #region "Sum of Double?"

        public static double? Sum<T1>(this Tuple<T1> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static double? Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static double? Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static double? Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static double? Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static double? Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static double? Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, double?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            double? sum = double.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                double? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }
        #endregion

        #region "Sum of Short"

        public static short Sum<T1>(this Tuple<T1> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static short Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static short Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static short Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static short Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static short Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }

        public static short Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short fValue = f(v);
             sum+=fValue;
            }
            return sum;
        }
        #endregion

        #region "Sum of Short?"

        public static short? Sum<T1>(this Tuple<T1> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            return f(value.Item1);
        }

        public static short? Sum<T1, T2>(this Tuple<T1, T2> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static short? Sum<T1, T2, T3>(this Tuple<T1, T2, T3> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static short? Sum<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static short? Sum<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static short? Sum<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }

        public static short? Sum<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, Func<object, short?> f)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "value is null");
            }

            if (f == null)
            {
                throw new ArgumentNullException("f", "f is null");
            }
            short? sum = short.MinValue;
            int i = value.Count();
            while (0 < i)
            {
                i--;
                object v = value.Item(i);
                short? fValue = f(v);
                if (fValue.HasValue)
                {
                    sum += fValue.Value;
                }
            }
            return sum;
        }
        #endregion

    }