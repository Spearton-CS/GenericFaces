using GenericFaces.Collections.Abilities;

namespace GenericFaces.Collections.Kinds;

public interface IDeque<T> : IDeque<T, int>
    where T : allows ref struct;

public interface IDeque<T, out TCount> : ICountable<TCount>, IEnumerable<T>
    where T : allows ref struct
    where TCount : allows ref struct
{
    public void PushFirst(T value);
    public void PushLast(T value);

    public T PopFirst();
    public T PopLast();

    public bool TryPopFirst(out T? first);
    public bool TryPopLast(out T? last);
}

public interface IDeque<T, out TCount, out TEnumerator> : IDeque<T, TCount>, IEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct;