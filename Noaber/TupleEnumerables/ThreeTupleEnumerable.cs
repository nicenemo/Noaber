using System;
using System.Collections;

internal sealed class ThreeTupleEnumerable<T1, T2,T3> : IEnumerable
{
    private readonly Tuple<T1, T2,T3> value;
    public ThreeTupleEnumerable(Tuple<T1, T2,T3> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new ThreeTupleEnumerator<T1, T2,T3>(value);
    }
}
