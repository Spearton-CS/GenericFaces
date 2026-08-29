using System.Runtime.CompilerServices;

namespace GenericFaces.Patterns;

public interface IAwaitable
{
    IAwaiter GetAwaiter();
}
public interface IAwaitable<out TAwaiter> : IAwaitable
    where TAwaiter : IAwaiter, allows ref struct
{
    new TAwaiter GetAwaiter();
}
public interface IAwaitable<out TAwaiter, out TResult> : IAwaitable<TAwaiter>
    where TAwaiter : IAwaiter<TResult>, allows ref struct
    where TResult : allows ref struct;

public interface IAwaiter : INotifyCompletion
{
    bool IsCompleted { get; }
    void GetResult();
}
public interface IAwaiter<out TResult> : IAwaiter
    where TResult : allows ref struct
{
    new TResult GetResult();
    void IAwaiter.GetResult() => GetResult();
}