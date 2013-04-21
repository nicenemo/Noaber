using System;
using System.Collections;

internal sealed class FiveTupleEnumerable<T1, T2, T3, T4,T5> : IEnumerable
{
    private readonly Tuple<T1, T2, T3, T4,T5> value;
    public FiveTupleEnumerable(Tuple<T1, T2, T3, T4,T5> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new FiveTupleEnumerator<T1, T2, T3, T4,T5>(value);
    }
}

