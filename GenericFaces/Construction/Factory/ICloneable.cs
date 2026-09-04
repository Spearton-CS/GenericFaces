namespace GenericFaces.Construction.Factory;

public interface ICloneable<out TSelf> where TSelf : allows ref struct
{
    public TSelf Clone();
}