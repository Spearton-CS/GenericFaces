namespace GenericFaces.Collections.Kinds;

public interface IDeque<T, out TCount, out TEnumerator> : IDeque<T, TCount>, IQueue<T, TCount, TEnumerator>, IStack<T, TCount, TEnumerator>
    where T : allows ref struct
    where TCount : allows ref struct
    where TEnumerator : IEnumerator<T>, allows ref struct;
public interface IDeque<T, out TCount> : IQueue<T, TCount>, IStack<T, TCount>
    where T : allows ref struct
    where TCount : allows ref struct;
public interface IDeque<T> : IDeque<T, int>, IQueue<T>, IStack<T>
    where T : allows ref struct;