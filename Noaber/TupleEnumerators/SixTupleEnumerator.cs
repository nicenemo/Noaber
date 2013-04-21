using System;

internal sealed class SixTupleEnumerator<T1, T2, T3, T4, T5, T6> : TupleEnumerator
{

    private readonly Tuple<T1, T2, T3, T4, T5, T6> value;
    public SixTupleEnumerator(Tuple<T1, T2, T3, T4, T5, T6> value)
        : base(6)
    {
        this.value = value;
    }

    public override object Current
    {
        get { return value.Item(index); }
    }

}