namespace GenericFaces.Collections.Abilities;

public interface IPeekable<T> where T : allows ref struct
{
    public T Peek();
    public bool TryPeek(out T value);
}