using System;
using System.Collections;

internal sealed class OneTupleEnumerable<T> : IEnumerable
{
    private readonly Tuple<T> value;
    public OneTupleEnumerable(Tuple<T> value)
        : base()
    {
        this.value = value;
    }
    public IEnumerator GetEnumerator()
    {
        return new OneTupleEnumerator<T>(value);
    }
}

