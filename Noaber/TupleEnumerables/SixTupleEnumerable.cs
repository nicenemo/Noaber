using System;
using System.Collections;

internal sealed class SixTupleEnumerable<T1, T2, T3, T4, T5,T6> : IEnumerable
{
    private readonly Tuple<T1, T2, T3, T4, T5,T6> value;
    public SixTupleEnumerable(Tuple<T1, T2, T3, T4, T5,T6> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new SixTupleEnumerator<T1, T2, T3, T4, T5,T6>(value);
    }
}

