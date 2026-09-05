using GenericFaces.Collections.Abilities;

namespace GenericFaces.Collections.Kinds;

public interface IQueue<T> : IQueue<T, int>, ICountable
    where T : allows ref struct;

public interface IQueue<T, out TCount> : ICountable<TCount>, IEnumerable<T>
    where T : allows ref struct
    where TCount : allows ref struct
{
    public void Enqueue(T value);
    public bool TryEnqueue(T value);

    public T Dequeue();
    public bool TryDequeue(out T? value);
}

public interface IQueue<T, out TCount, out TEnumerator> : IQueue<T, TCount>, IEnumerable<T, TEnumerator>
    where T : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct;