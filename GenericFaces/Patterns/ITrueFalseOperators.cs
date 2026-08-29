namespace GenericFaces.Patterns;

public interface ITrueFalseOperators<in TSelf>
    where TSelf : ITrueFalseOperators<TSelf>, allows ref struct
{
    public abstract static bool operator true(TSelf self);
    public abstract static bool operator false(TSelf self);
}