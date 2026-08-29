namespace GenericFaces.Construction;

public interface IFactory<out TResult>
	where TResult : allows ref struct
{
	public TResult Create();
}

public interface IStaticFactory<out TResult>
	where TResult : allows ref struct
{
	public abstract static TResult Create();
}

public interface IAsyncFactory<TResult>
{
	public ValueTask<TResult> CreateAsync();
}

public interface IStaticAsyncFactory<TResult>
{
	public abstract static ValueTask<TResult> CreateAsync();
}

public interface ITryFactory<TResult>
	where TResult : allows ref struct
{
	public bool TryCreate(out TResult result);
}

public interface IStaticTryFactory<TResult>
	where TResult : allows ref struct
{
	public abstract static bool TryCreate(out TResult result);
}

public interface IAsyncTryFactory<TResult>
{
	public ValueTask<bool> TryCreateAsync(out TResult result);
}

public interface IStaticAsyncTryFactory<TResult>
{
	public abstract static ValueTask<bool> TryCreateAsync(out TResult result);
}

public interface IFactory<out TResult, in T1>
	where TResult : allows ref struct
	where T1 : allows ref struct
{
	public TResult Create(T1 t1);
}

public interface IStaticFactory<out TResult, in T1>
	where TResult : allows ref struct
	where T1 : allows ref struct
{
	public abstract static TResult Create(T1 t1);
}

public interface IAsyncFactory<TResult, in T1>
{
	public ValueTask<TResult> CreateAsync(T1 t1);
}

public interface IStaticAsyncFactory<TResult, in T1>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1);
}

public interface ITryFactory<TResult, in T1>
	where TResult : allows ref struct
	where T1 : allows ref struct
{
	public bool TryCreate(T1 t1, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1>
	where TResult : allows ref struct
	where T1 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2);
}

public interface IStaticFactory<out TResult, in T1, in T2>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2);
}

public interface IAsyncFactory<TResult, in T1, in T2>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2);
}

public interface ITryFactory<TResult, in T1, in T2>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2, T3 t3);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3);
}

public interface ITryFactory<TResult, in T1, in T2, in T3>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, T3 t3, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
	where TResult : allows ref struct
	where T1 : allows ref struct
	where T2 : allows ref struct
	where T3 : allows ref struct
	where T4 : allows ref struct
	where T5 : allows ref struct
	where T6 : allows ref struct
	where T7 : allows ref struct
	where T8 : allows ref struct
{
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult result);
}
public interface IFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
	where TResult : allows ref struct
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
	public TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16);
}

public interface IStaticFactory<out TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
	where TResult : allows ref struct
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
	public abstract static TResult Create(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16);
}

public interface IAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
{
	public ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16);
}

public interface IStaticAsyncFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
{
	public abstract static ValueTask<TResult> CreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16);
}

public interface ITryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
	where TResult : allows ref struct
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
	public bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, out TResult result);
}

public interface IStaticTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
	where TResult : allows ref struct
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
	public abstract static bool TryCreate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, out TResult result);
}

public interface IAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
{
	public ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, out TResult result);
}

public interface IStaticAsyncTryFactory<TResult, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>
{
	public abstract static ValueTask<bool> TryCreateAsync(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, out TResult result);
}
