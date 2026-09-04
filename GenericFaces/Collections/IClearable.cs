namespace GenericFaces.Collections;

public interface IClearable
{
    public void Clear();
}

public interface IClearable<T> : IClearable where T : allows ref struct
{
    public void Clear(T item);
}