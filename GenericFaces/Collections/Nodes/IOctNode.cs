namespace GenericFaces.Collections.Nodes;

#region IOctNode

public interface IOctNode<out TSelf> : IOctNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf>
    where TSelf : IOctNode<TSelf>, allows ref struct;

public interface IOctNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>
    where TSelf : IOctNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>, allows ref struct
    where T1 : allows ref struct
    where T2 : allows ref struct
    where T3 : allows ref struct
    where T4 : allows ref struct
    where T5 : allows ref struct
    where T6 : allows ref struct
    where T7 : allows ref struct
    where T8 : allows ref struct
{
    public T1 Child0 { get; }
    public T2 Child1 { get; }
    public T3 Child2 { get; }
    public T4 Child3 { get; }
    public T5 Child4 { get; }
    public T6 Child5 { get; }
    public T7 Child6 { get; }
    public T8 Child7 { get; }
}

public interface IOctNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out TParent> : IOctNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>
    where TSelf : IOctNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8, TParent>, allows ref struct
    where T1 : allows ref struct
    where T2 : allows ref struct
    where T3 : allows ref struct
    where T4 : allows ref struct
    where T5 : allows ref struct
    where T6 : allows ref struct
    where T7 : allows ref struct
    where T8 : allows ref struct
    where TParent : allows ref struct
{
    public TParent Parent { get; }
}

#endregion

#region IDoubleOctNode

public interface IDoubleOctNode<out TSelf> : IDoubleOctNode<TSelf, TSelf>
    where TSelf : IDoubleOctNode<TSelf>, allows ref struct;

public interface IDoubleOctNode<out TSelf, out TParent> : IOctNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IOctNode<TSelf>
    where TSelf : IDoubleOctNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;

#endregion

#region IOctChainNode

public interface IOctChainNode
{
    public IOctChainNode? Child0 { get; }
    public IOctChainNode? Child1 { get; }
    public IOctChainNode? Child2 { get; }
    public IOctChainNode? Child3 { get; }
    public IOctChainNode? Child4 { get; }
    public IOctChainNode? Child5 { get; }
    public IOctChainNode? Child6 { get; }
    public IOctChainNode? Child7 { get; }
}

public interface IOctChainNode<out TSelf> : IOctChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf>, IOctNode<TSelf>
    where TSelf : class, IOctChainNode<TSelf>;

public interface IOctChainNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8> : IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>, IOctChainNode
    where TSelf : class, IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>
    where T1 : class, IOctChainNode
    where T2 : class, IOctChainNode
    where T3 : class, IOctChainNode
    where T4 : class, IOctChainNode
    where T5 : class, IOctChainNode
    where T6 : class, IOctChainNode
    where T7 : class, IOctChainNode
    where T8 : class, IOctChainNode
{
    IOctChainNode? IOctChainNode.Child0 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child0;
    IOctChainNode? IOctChainNode.Child1 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child1;
    IOctChainNode? IOctChainNode.Child2 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child2;
    IOctChainNode? IOctChainNode.Child3 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child3;
    IOctChainNode? IOctChainNode.Child4 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child4;
    IOctChainNode? IOctChainNode.Child5 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child5;
    IOctChainNode? IOctChainNode.Child6 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child6;
    IOctChainNode? IOctChainNode.Child7 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child7;
}

public interface IOctChainNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out TParent> : IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>, IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, TParent?>, IDoubleOctChainNode
    where TSelf : class, IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8, TParent>
    where T1 : class, IOctChainNode
    where T2 : class, IOctChainNode
    where T3 : class, IOctChainNode
    where T4 : class, IOctChainNode
    where T5 : class, IOctChainNode
    where T6 : class, IOctChainNode
    where T7 : class, IOctChainNode
    where T8 : class, IOctChainNode
    where TParent : class, IOctChainNode
{
    IOctChainNode? IDoubleOctChainNode.Parent => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, TParent?>)this).Parent;
}

#endregion

#region IDoubleOctChainNode

public interface IDoubleOctChainNode : IOctChainNode
{
    public IOctChainNode? Parent { get; }
}

public interface IDoubleOctChainNode<out TSelf> : IDoubleOctChainNode<TSelf, TSelf>, IDoubleOctNode<TSelf>
    where TSelf : class, IDoubleOctChainNode<TSelf>;

public interface IDoubleOctChainNode<out TSelf, out TParent> : IOctChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IOctChainNode<TSelf>, IDoubleOctNode<TSelf, TParent>
    where TSelf : class, IDoubleOctChainNode<TSelf, TParent>
    where TParent : class, IOctChainNode;

#endregion

#region IStrongDoubleOctChainNode

public interface IStrongDoubleOctChainNode : IDoubleOctChainNode
{
    public new IStrongDoubleOctChainNode? Child0 { get; }
    public new IStrongDoubleOctChainNode? Child1 { get; }
    public new IStrongDoubleOctChainNode? Child2 { get; }
    public new IStrongDoubleOctChainNode? Child3 { get; }
    public new IStrongDoubleOctChainNode? Child4 { get; }
    public new IStrongDoubleOctChainNode? Child5 { get; }
    public new IStrongDoubleOctChainNode? Child6 { get; }
    public new IStrongDoubleOctChainNode? Child7 { get; }
    public new IStrongDoubleOctChainNode? Parent { get; }

    IOctChainNode? IOctChainNode.Child0 => Child0;
    IOctChainNode? IOctChainNode.Child1 => Child1;
    IOctChainNode? IOctChainNode.Child2 => Child2;
    IOctChainNode? IOctChainNode.Child3 => Child3;
    IOctChainNode? IOctChainNode.Child4 => Child4;
    IOctChainNode? IOctChainNode.Child5 => Child5;
    IOctChainNode? IOctChainNode.Child6 => Child6;
    IOctChainNode? IOctChainNode.Child7 => Child7;
    IOctChainNode? IDoubleOctChainNode.Parent => Parent;
}

public interface IStrongDoubleOctChainNode<out TSelf> : IStrongDoubleOctChainNode<TSelf, TSelf>, IDoubleOctChainNode<TSelf>
    where TSelf : class, IStrongDoubleOctChainNode<TSelf>;

public interface IStrongDoubleOctChainNode<out TSelf, out TParent> : IStrongDoubleOctChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IDoubleOctChainNode<TSelf, TParent>
    where TSelf : class, IStrongDoubleOctChainNode<TSelf, TParent>
    where TParent : class, IStrongDoubleOctChainNode;

public interface IStrongDoubleOctChainNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out TParent> : IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8, TParent>, IStrongDoubleOctChainNode
    where TSelf : class, IStrongDoubleOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8, TParent>
    where T1 : class, IStrongDoubleOctChainNode
    where T2 : class, IStrongDoubleOctChainNode
    where T3 : class, IStrongDoubleOctChainNode
    where T4 : class, IStrongDoubleOctChainNode
    where T5 : class, IStrongDoubleOctChainNode
    where T6 : class, IStrongDoubleOctChainNode
    where T7 : class, IStrongDoubleOctChainNode
    where T8 : class, IStrongDoubleOctChainNode
    where TParent : class, IStrongDoubleOctChainNode
{
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child0 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child0;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child1 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child1;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child2 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child2;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child3 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child3;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child4 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child4;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child5 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child5;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child6 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child6;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Child7 => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?>)this).Child7;
    IStrongDoubleOctChainNode? IStrongDoubleOctChainNode.Parent => ((IOctNode<TSelf, T1?, T2?, T3?, T4?, T5?, T6?, T7?, T8?, TParent?>)this).Parent;
}

#endregion