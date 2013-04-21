using System;

internal sealed class FourTupleEnumerator<T1, T2, T3, T4> : TupleEnumerator
{
    private readonly Tuple<T1, T2, T3, T4> value;
    public FourTupleEnumerator(Tuple<T1, T2, T3, T4> value)
        : base(4)
    {
        this.value = value;
    }

    public override object Current
    {
        get { return value.Item(index); }
    }

}