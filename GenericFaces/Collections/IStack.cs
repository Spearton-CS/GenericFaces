namespace GenericFaces.Collections;

public interface IStack<T, out TCount> : ICountable<TCount>, IEnumerable<T>
    where T : allows ref struct
    where TCount : allows ref struct
{
    public void Push(T value);
    public bool TryPush(T value);

    public T Pop();
    public bool TryPop(out T value);
}
public interface IStack<T> : IStack<T, int>, ICountable where T : allows ref struct;
public interface IStack<T, out TCount, out TEnumerator> : IStack<T, TCount>, IEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct;