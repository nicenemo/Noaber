using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


public static partial class TupleExtensions
{
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

}

