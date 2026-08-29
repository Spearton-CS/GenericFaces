using System.ComponentModel;

namespace GenericFaces.Patterns;

public interface IReadOnlyFixable<T>
    where T : allows ref struct
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ref readonly T GetPinnableReference();
}

public interface IFixable<T>
    : IReadOnlyFixable<T>
    where T : allows ref struct
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new ref T GetPinnableReference();
    ref readonly T IReadOnlyFixable<T>.GetPinnableReference() => ref GetPinnableReference();
}