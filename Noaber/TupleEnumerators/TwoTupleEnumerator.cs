using System;

internal sealed class TwoTupleEnumerator<T1, T2> : TupleEnumerator
{

    private readonly Tuple<T1, T2> value;
    public TwoTupleEnumerator(Tuple<T1, T2> value)
        : base(1)
    {
        this.value = value;
    }

    public override object Current
    {
        get { return value.Item(index); }
    }
}