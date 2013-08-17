using System;

internal sealed class SevenTupleEnumerator<T1, T2, T3, T4, T5, T6, T7> : TupleEnumerator
{

	private readonly Tuple<T1, T2, T3, T4, T5, T6, T7> value;
	public SevenTupleEnumerator(Tuple<T1, T2, T3, T4, T5, T6, T7> value) : base(6)
	{
		this.value = value;
	}

	public override object Current {
		get { return value.Item(index); }
	}

}