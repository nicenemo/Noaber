using System;

internal class OneTupleEnumerator<T> : TupleEnumerator
{

    private readonly Tuple<T> value;
    public OneTupleEnumerator(Tuple<T> value)
        : base(0)
    {
        this.value = value;
    }

    public override object Current
    {
        get { return value.Item(index); }
    }

}