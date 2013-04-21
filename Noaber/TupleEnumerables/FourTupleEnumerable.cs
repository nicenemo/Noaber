using System;
using System.Collections;

internal sealed class FourTupleEnumerable<T1, T2, T3,T4> : IEnumerable
{
    private readonly Tuple<T1, T2, T3,T4> value;
    public FourTupleEnumerable(Tuple<T1, T2, T3,T4> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new FourTupleEnumerator<T1, T2, T3,T4>(value);
    }
}

