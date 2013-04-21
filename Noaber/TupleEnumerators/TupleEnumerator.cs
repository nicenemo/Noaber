using System;
using System.Collections;

internal abstract class TupleEnumerator : IEnumerator
{

    protected readonly int MaxIndex;
    protected int index = -1;
    private TupleEnumerator()
        : base()
    {
    }
    public TupleEnumerator(int maxIndex)
        : this()
    {
        this.MaxIndex = maxIndex;
    }

    public abstract object Current { get; }

    public virtual bool MoveNext()
    {

        if (index < MaxIndex)
        {
            index += 1;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {
        index = -1;
    }
}