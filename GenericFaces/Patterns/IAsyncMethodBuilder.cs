using System.Runtime.CompilerServices;

namespace GenericFaces.Patterns;

public interface IAsyncMethodBuilder<TStateMachine, out TResultTask>
    where TStateMachine : IAsyncStateMachine
{
    public void Start(ref TStateMachine stateMachine);
    public void SetStateMachine(IAsyncStateMachine stateMachine);

    public void SetResult();
    public void SetException(Exception exception);

    public void AwaitOnCompleted<TAwaiter, TStateMachineInner>(
        ref TAwaiter awaiter,
        ref TStateMachineInner stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachineInner : IAsyncStateMachine;

    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachineInner>(
        ref TAwaiter awaiter,
        ref TStateMachineInner stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachineInner : IAsyncStateMachine;

    public TResultTask Task { get; }
}

public interface IAsyncMethodBuilder<TStateMachine, out TResultTask, in TResult>
    where TStateMachine : IAsyncStateMachine
{
    public void Start(ref TStateMachine stateMachine);
    public void SetStateMachine(IAsyncStateMachine stateMachine);

    public void SetResult(TResult result);
    public void SetException(Exception exception);

    public void AwaitOnCompleted<TAwaiter, TStateMachineInner>(
        ref TAwaiter awaiter,
        ref TStateMachineInner stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachineInner : IAsyncStateMachine;

    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachineInner>(
        ref TAwaiter awaiter,
        ref TStateMachineInner stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachineInner : IAsyncStateMachine;

    public TResultTask Task { get; }
}