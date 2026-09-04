namespace GenericFaces.Collections.Nodes;

public interface IQuadNode<out TSelf, out T1, out T2, out T3, out T4>
    where TSelf : IQuadNode<TSelf, T1, T2, T3, T4>, allows ref struct
    where T1 : allows ref struct
    where T2 : allows ref struct
    where T3 : allows ref struct
    where T4 : allows ref struct
{
    public T1 Child0 { get; }
    public T2 Child1 { get; }
    public T3 Child2 { get; }
    public T4 Child3 { get; }
}
public interface IQuadNode<out TSelf, out T1, out T2, out T3, out T4, out TParent> : IQuadNode<TSelf, T1, T2, T3, T4>
    where TSelf : IQuadNode<TSelf, T1, T2, T3, T4, TParent>, allows ref struct
    where T1 : allows ref struct
    where T2 : allows ref struct
    where T3 : allows ref struct
    where T4 : allows ref struct
    where TParent : allows ref struct
{
    public TParent Parent { get; }
}

public interface IQuadNode<out TSelf> : IQuadNode<TSelf, TSelf, TSelf, TSelf, TSelf>
    where TSelf : IQuadNode<TSelf>, allows ref struct;
public interface IDoubleQuadNode<out TSelf, out TParent> : IQuadNode<TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IQuadNode<TSelf>
    where TSelf : IDoubleQuadNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;
public interface IDoubleQuadNode<out TSelf> : IDoubleQuadNode<TSelf, TSelf>
    where TSelf : IDoubleQuadNode<TSelf>, allows ref struct;


public interface IQuadChainNode<out TSelf, out T1, out T2, out T3, out T4> : IQuadNode<TSelf, T1, T2, T3, T4>
    where TSelf : class, IQuadChainNode<TSelf, T1, T2, T3, T4>
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class;
public interface IQuadChainNode<out TSelf, out T1, out T2, out T3, out T4, out TParent> : IQuadChainNode<TSelf, T1, T2, T3, T4>, IQuadNode<TSelf, T1, T2, T3, T4, TParent>
    where TSelf : class, IQuadChainNode<TSelf, T1, T2, T3, T4, TParent>
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where TParent : class;

public interface IQuadChainNode<out TSelf> : IQuadChainNode<TSelf, TSelf, TSelf, TSelf, TSelf>, IQuadNode<TSelf>
    where TSelf : class, IQuadChainNode<TSelf>;
public interface IDoubleQuadChainNode<out TSelf, out TParent> : IQuadChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IDoubleQuadNode<TSelf, TParent>
    where TSelf : class, IDoubleQuadChainNode<TSelf, TParent>
    where TParent : class;
public interface IDoubleQuadChainNode<out TSelf> : IDoubleQuadChainNode<TSelf, TSelf>, IDoubleQuadNode<TSelf>
    where TSelf : class, IDoubleQuadChainNode<TSelf>;