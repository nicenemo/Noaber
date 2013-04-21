using System;

internal sealed class FiveTupleEnumerator<T1, T2, T3, T4, T5> : TupleEnumerator
{
    private readonly Tuple<T1, T2, T3, T4, T5> value;
    public FiveTupleEnumerator(Tuple<T1, T2, T3, T4, T5> value)
        : base(5)
    {
        this.value = value;
    }

    public override object Current
    {
        get { return value.Item(index); }
    }

}