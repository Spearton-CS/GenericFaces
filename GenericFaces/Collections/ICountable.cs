namespace GenericFaces.Collections;

public interface ICountable<out TCount> where TCount : allows ref struct
{
    public TCount Count { get; }
}
public interface ICountable : ICountable<int>;

public interface ILengthable<out TLength> where TLength : allows ref struct
{
    public TLength Length { get; }
}
public interface ILengthable : ILengthable<int>;