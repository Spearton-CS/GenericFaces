namespace GenericFaces.Collections;

public interface IReadOnlyIndexable<in TIndex, out TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public TResult this[TIndex index] { get; }
}
public interface IReadOnlyIndexable<out TResult> : IReadOnlyIndexable<int, TResult> where TResult : allows ref struct;

public interface IIndexable<in TIndex, TResult>
    : IReadOnlyIndexable<TIndex, TResult>
    where TIndex : allows ref struct
    where TResult : allows ref struct
{
    public TResult this[TIndex index] { set; }
}
public interface IIndexable<TResult> : IIndexable<int, TResult>, IReadOnlyIndexable<TResult> where TResult : allows ref struct;