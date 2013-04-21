﻿using System;
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
        /// <typeparam name="T1">The type of the 1.</typeparam>
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

    }


