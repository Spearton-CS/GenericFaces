namespace GenericFaces.Patterns;

public interface IDeconstructible<T1>
	where T1 : allows ref struct
{
	public void Deconstruct(out T1 t1);
}

public interface IDeconstructible<T1, T2>
	: IDeconstructible<T1>
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2);
	void IDeconstructible<T1>.Deconstruct(out T1 t1) => Deconstruct(out t1, out _);
}

public interface IDeconstructible<T1, T2, T3>
	: IDeconstructible<T1, T2>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3);
	void IDeconstructible<T1, T2>.Deconstruct(out T1 t1, out T2 t2) => Deconstruct(out t1, out t2, out _);
}

public interface IDeconstructible<T1, T2, T3, T4>
	: IDeconstructible<T1, T2, T3>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4);
	void IDeconstructible<T1, T2, T3>.Deconstruct(out T1 t1, out T2 t2, out T3 t3) => Deconstruct(out t1, out t2, out t3, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5>
	: IDeconstructible<T1, T2, T3, T4>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5);
	void IDeconstructible<T1, T2, T3, T4>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4) => Deconstruct(out t1, out t2, out t3, out t4, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6>
	: IDeconstructible<T1, T2, T3, T4, T5>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6);
	void IDeconstructible<T1, T2, T3, T4, T5>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7>
	: IDeconstructible<T1, T2, T3, T4, T5, T6>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7);
	void IDeconstructible<T1, T2, T3, T4, T5, T6>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out t10, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out t10, out t11, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out t10, out t11, out t12, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
	where T14 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out t10, out t11, out t12, out t13, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
	where T14 : allows ref struct
	where T15 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14, out T15 t15);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out t10, out t11, out t12, out t13, out t14, out _);
}

public interface IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
	: IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
	where T9 : allows ref struct
	where T10 : allows ref struct
	where T11 : allows ref struct
	where T12 : allows ref struct
	where T13 : allows ref struct
	where T14 : allows ref struct
	where T15 : allows ref struct
	where T16 : allows ref struct
{
	public void Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14, out T15 t15, out T16 t16);
	void IDeconstructible<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Deconstruct(out T1 t1, out T2 t2, out T3 t3, out T4 t4, out T5 t5, out T6 t6, out T7 t7, out T8 t8, out T9 t9, out T10 t10, out T11 t11, out T12 t12, out T13 t13, out T14 t14, out T15 t15) => Deconstruct(out t1, out t2, out t3, out t4, out t5, out t6, out t7, out t8, out t9, out t10, out t11, out t12, out t13, out t14, out t15, out _);
}

