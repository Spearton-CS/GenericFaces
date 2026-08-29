namespace GenericFaces.Collections;

public interface IEnumerable<out T, out TEnumerator> : IEnumerable<T>
    where T : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct
{
    public new TEnumerator GetEnumerator();
}

public interface IAsyncEnumerable<out T, out TEnumerator> : IAsyncEnumerable<T>
    where T : allows ref struct
    where TEnumerator : IAsyncEnumerator<T>
{
    public new TEnumerator GetAsyncEnumerator(CancellationToken cancellationToken = default);
    IAsyncEnumerator<T> IAsyncEnumerable<T>.GetAsyncEnumerator(CancellationToken cancellationToken) => GetAsyncEnumerator(cancellationToken);
}