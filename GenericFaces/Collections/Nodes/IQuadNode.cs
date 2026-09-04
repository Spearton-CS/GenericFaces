namespace GenericFaces.Collections.Nodes;

#region IQuadNode

public interface IQuadNode<out TSelf> : IQuadNode<TSelf, TSelf, TSelf, TSelf, TSelf>
    where TSelf : IQuadNode<TSelf>, allows ref struct;

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

#endregion

#region IDoubleQuadNode

public interface IDoubleQuadNode<out TSelf> : IDoubleQuadNode<TSelf, TSelf>
    where TSelf : IDoubleQuadNode<TSelf>, allows ref struct;

public interface IDoubleQuadNode<out TSelf, out TParent> : IQuadNode<TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IQuadNode<TSelf>
    where TSelf : IDoubleQuadNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;

#endregion

#region IQuadChainNode

public interface IQuadChainNode
{
    public IQuadChainNode? Child0 { get; }
    public IQuadChainNode? Child1 { get; }
    public IQuadChainNode? Child2 { get; }
    public IQuadChainNode? Child3 { get; }
}

public interface IQuadChainNode<out TSelf> : IQuadChainNode<TSelf, TSelf, TSelf, TSelf, TSelf>, IQuadNode<TSelf>
    where TSelf : class, IQuadChainNode<TSelf>;

public interface IQuadChainNode<out TSelf, out T1, out T2, out T3, out T4> : IQuadNode<TSelf, T1?, T2?, T3?, T4?>, IQuadChainNode
    where TSelf : class, IQuadChainNode<TSelf, T1, T2, T3, T4>
    where T1 : class, IQuadChainNode
    where T2 : class, IQuadChainNode
    where T3 : class, IQuadChainNode
    where T4 : class, IQuadChainNode
{
    IQuadChainNode? IQuadChainNode.Child0 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child0;
    IQuadChainNode? IQuadChainNode.Child1 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child1;
    IQuadChainNode? IQuadChainNode.Child2 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child2;
    IQuadChainNode? IQuadChainNode.Child3 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child3;
}

public interface IQuadChainNode<out TSelf, out T1, out T2, out T3, out T4, out TParent> : IQuadChainNode<TSelf, T1, T2, T3, T4>, IQuadNode<TSelf, T1?, T2?, T3?, T4?, TParent?>, IDoubleQuadChainNode
    where TSelf : class, IQuadChainNode<TSelf, T1, T2, T3, T4, TParent>
    where T1 : class, IQuadChainNode
    where T2 : class, IQuadChainNode
    where T3 : class, IQuadChainNode
    where T4 : class, IQuadChainNode
    where TParent : class, IQuadChainNode
{
    IQuadChainNode? IDoubleQuadChainNode.Parent => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?, TParent?>)this).Parent;
}

#endregion

#region IDoubleQuadChainNode

public interface IDoubleQuadChainNode : IQuadChainNode
{
    public IQuadChainNode? Parent { get; }
}

public interface IDoubleQuadChainNode<out TSelf> : IDoubleQuadChainNode<TSelf, TSelf>, IDoubleQuadNode<TSelf>
    where TSelf : class, IDoubleQuadChainNode<TSelf>;

public interface IDoubleQuadChainNode<out TSelf, out TParent> : IQuadChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IQuadChainNode<TSelf>, IDoubleQuadNode<TSelf, TParent>
    where TSelf : class, IDoubleQuadChainNode<TSelf, TParent>
    where TParent : class, IQuadChainNode;

#endregion

#region IStrongDoubleQuadChainNode

public interface IStrongDoubleQuadChainNode : IDoubleQuadChainNode
{
    public IStrongDoubleQuadChainNode? Child0 { get; }
    public IStrongDoubleQuadChainNode? Child1 { get; }
    public IStrongDoubleQuadChainNode? Child2 { get; }
    public IStrongDoubleQuadChainNode? Child3 { get; }
    public IStrongDoubleQuadChainNode? Parent { get; }

    IQuadChainNode? IQuadChainNode.Child0 => Child0;
    IQuadChainNode? IQuadChainNode.Child1 => Child1;
    IQuadChainNode? IQuadChainNode.Child2 => Child2;
    IQuadChainNode? IQuadChainNode.Child3 => Child3;
    IQuadChainNode? IDoubleQuadChainNode.Parent => Parent;
}

public interface IStrongDoubleQuadChainNode<out TSelf> : IStrongDoubleQuadChainNode<TSelf, TSelf>, IDoubleQuadChainNode<TSelf>
    where TSelf : class, IStrongDoubleQuadChainNode<TSelf>;

public interface IStrongDoubleQuadChainNode<out TSelf, out TParent> : IStrongDoubleQuadChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IDoubleQuadChainNode<TSelf, TParent>
    where TSelf : class, IStrongDoubleQuadChainNode<TSelf, TParent>
    where TParent : class, IStrongDoubleQuadChainNode;

public interface IStrongDoubleQuadChainNode<out TSelf, out T1, out T2, out T3, out T4, out TParent> : IQuadChainNode<TSelf, T1, T2, T3, T4, TParent>, IStrongDoubleQuadChainNode
    where TSelf : class, IStrongDoubleQuadChainNode<TSelf, T1, T2, T3, T4, TParent>
    where T1 : class, IStrongDoubleQuadChainNode
    where T2 : class, IStrongDoubleQuadChainNode
    where T3 : class, IStrongDoubleQuadChainNode
    where T4 : class, IStrongDoubleQuadChainNode
    where TParent : class, IStrongDoubleQuadChainNode
{
    IStrongDoubleQuadChainNode? IStrongDoubleQuadChainNode.Child0 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child0;
    IStrongDoubleQuadChainNode? IStrongDoubleQuadChainNode.Child1 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child1;
    IStrongDoubleQuadChainNode? IStrongDoubleQuadChainNode.Child2 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child2;
    IStrongDoubleQuadChainNode? IStrongDoubleQuadChainNode.Child3 => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?>)this).Child3;
    IStrongDoubleQuadChainNode? IStrongDoubleQuadChainNode.Parent => ((IQuadNode<TSelf, T1?, T2?, T3?, T4?, TParent?>)this).Parent;
}
    
#endregion