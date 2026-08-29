namespace GenericFaces.Patterns;

public interface ISliceable<out TSlice, in TStart>
    where TSlice : allows ref struct
    where TStart : allows ref struct
{
    public TSlice Slice(TStart start);
}
public interface ISliceable<out TSlice, in TStart, in TLength> : ISliceable<TSlice, TStart>
    where TSlice : allows ref struct
    where TStart : allows ref struct
    where TLength : allows ref struct
{
    public TSlice Slice(TStart start, TLength length);
}

public interface ISliceable<out TSlice> : ISliceable<TSlice, int, int>
    where TSlice : allows ref struct;