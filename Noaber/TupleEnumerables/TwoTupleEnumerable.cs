using System;
using System.Collections;

internal sealed class TwoTupleEnumerable<T1,T2> : IEnumerable
{
    private readonly Tuple<T1,T2> value;
    public TwoTupleEnumerable(Tuple<T1,T2> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new TwoTupleEnumerator<T1,T2>(value);
    }
}