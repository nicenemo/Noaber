using System;

internal sealed class ThreeTupleEnumerator<T1, T2, T3> : TupleEnumerator
{

    private readonly Tuple<T1, T2, T3> value;
    public ThreeTupleEnumerator(Tuple<T1, T2, T3> value)
        : base(3)
    {
        this.value = value;
    }

    public override object Current
    {
        get { return value.Item(index); }
    }

}