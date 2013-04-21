using System;
using System.Collections;

internal sealed class SevenTupleEnumerable<T1, T2, T3, T4, T5, T6,T7> : IEnumerable
{
    private readonly Tuple<T1, T2, T3, T4, T5, T6, T7> value;
    public SevenTupleEnumerable(Tuple<T1, T2, T3, T4, T5, T6,T7> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new SevenTupleEnumerator<T1, T2, T3, T4, T5, T6,T7>(value);
    }
}
