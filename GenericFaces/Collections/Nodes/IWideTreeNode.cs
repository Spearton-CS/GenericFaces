namespace GenericFaces.Collections.Nodes;

#region IWideTreeNode

public interface IWideTreeNode<out TSelf> : IWideTreeNode<TSelf, TSelf, TSelf>, INode<TSelf>
    where TSelf : IWideTreeNode<TSelf>, allows ref struct;

public interface IWideTreeNode<out TSelf, out TChild, out TNext> : INode<TSelf, TNext>
    where TSelf : IWideTreeNode<TSelf, TChild, TNext>, allows ref struct
    where TChild : allows ref struct
    where TNext : allows ref struct
{
    public TChild Child { get; }
}

public interface IWideTreeNode<out TSelf, out TChild, out TNext, out TParent> : IWideTreeNode<TSelf, TChild, TNext>, INode<TSelf, TNext, TParent>
    where TSelf : IWideTreeNode<TSelf, TChild, TNext, TParent>, allows ref struct
    where TChild : allows ref struct
    where TNext : allows ref struct
    where TParent : allows ref struct
{
    public TParent Parent { get; }
    TParent INode<TSelf, TNext, TParent>.Previous => Parent;
}

#endregion

#region IDoubleWideTreeNode

public interface IDoubleWideTreeNode<out TSelf> : IDoubleWideTreeNode<TSelf, TSelf>, IDoubleNode<TSelf>
    where TSelf : IDoubleWideTreeNode<TSelf>, allows ref struct;

public interface IDoubleWideTreeNode<out TSelf, out TParent> : IWideTreeNode<TSelf, TSelf, TSelf, TParent>, IWideTreeNode<TSelf>, IDoubleNode<TSelf, TParent>
    where TSelf : IDoubleWideTreeNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;

#endregion

#region IWideTreeChainNode

public interface IWideTreeChainNode : IChainNode
{
    public IWideTreeChainNode? Next { get; }
    public IWideTreeChainNode? Child { get; }
}

public interface IWideTreeChainNode<out TSelf> : IWideTreeChainNode<TSelf, TSelf, TSelf>, IWideTreeNode<TSelf>, IChainNode<TSelf>
    where TSelf : class, IWideTreeChainNode<TSelf>;

public interface IWideTreeChainNode<out TSelf, out TChild, out TNext> : IWideTreeNode<TSelf, TChild?, TNext?>, IChainNode<TSelf, TNext>, IWideTreeChainNode
    where TSelf : class, IWideTreeChainNode<TSelf, TChild, TNext>
    where TChild : class, IWideTreeChainNode
    where TNext : class, IWideTreeChainNode
{
    IWideTreeChainNode? IWideTreeChainNode.Next => ((IWideTreeNode<TSelf, TChild?, TNext?>)this).Next;
    IWideTreeChainNode? IWideTreeChainNode.Child => ((IWideTreeNode<TSelf, TChild?, TNext?>)this).Child;
}

public interface IWideTreeChainNode<out TSelf, out TChild, out TNext, out TParent> : IWideTreeChainNode<TSelf, TChild, TNext>, IWideTreeNode<TSelf, TChild?, TNext?, TParent?>, IChainNode<TSelf, TNext, TParent>, IDoubleWideTreeChainNode
    where TSelf : class, IWideTreeChainNode<TSelf, TChild, TNext, TParent>
    where TChild : class, IWideTreeChainNode
    where TNext : class, IWideTreeChainNode
    where TParent : class, IWideTreeChainNode
{
    IWideTreeChainNode? IDoubleWideTreeChainNode.Parent => ((IWideTreeNode<TSelf, TChild?, TNext?, TParent?>)this).Parent;
}

#endregion

#region IDoubleWideTreeChainNode

public interface IDoubleWideTreeChainNode : IWideTreeChainNode, IDoubleChainNode
{
    public IWideTreeChainNode? Parent { get; }
    IChainNode? IDoubleChainNode.Previous => Parent;
}

public interface IDoubleWideTreeChainNode<out TSelf> : IDoubleWideTreeChainNode<TSelf, TSelf>, IDoubleWideTreeNode<TSelf>, IDoubleChainNode<TSelf>
    where TSelf : class, IDoubleWideTreeChainNode<TSelf>;

public interface IDoubleWideTreeChainNode<out TSelf, out TParent> : IWideTreeChainNode<TSelf, TSelf, TSelf, TParent>, IWideTreeChainNode<TSelf>, IDoubleWideTreeNode<TSelf, TParent>, IDoubleChainNode<TSelf, TParent>
    where TSelf : class, IDoubleWideTreeChainNode<TSelf, TParent>
    where TParent : class, IDoubleWideTreeChainNode;

#endregion

#region IStrongDoubleWideTreeChainNode

public interface IStrongDoubleWideTreeChainNode : IDoubleWideTreeChainNode, IStrongDoubleChainNode
{
    public new IStrongDoubleWideTreeChainNode? Next { get; }
    public new IStrongDoubleWideTreeChainNode? Child { get; }
    public new IStrongDoubleWideTreeChainNode? Parent { get; }

    IWideTreeChainNode? IWideTreeChainNode.Next => Next;
    IWideTreeChainNode? IWideTreeChainNode.Child => Child;
    IWideTreeChainNode? IDoubleWideTreeChainNode.Parent => Parent;
}

public interface IStrongDoubleWideTreeChainNode<out TSelf> : IStrongDoubleWideTreeChainNode<TSelf, TSelf>
    where TSelf : class, IStrongDoubleWideTreeChainNode<TSelf>;

public interface IStrongDoubleWideTreeChainNode<out TSelf, out TParent> : IStrongDoubleWideTreeChainNode<TSelf, TSelf, TSelf, TParent>
    where TSelf : class, IStrongDoubleWideTreeChainNode<TSelf, TParent>
    where TParent : class, IStrongDoubleWideTreeChainNode;

public interface IStrongDoubleWideTreeChainNode<out TSelf, out TChild, out TNext, out TParent> : IWideTreeChainNode<TSelf, TChild, TNext, TParent>, IStrongDoubleWideTreeChainNode
    where TSelf : class, IStrongDoubleWideTreeChainNode<TSelf, TChild, TNext, TParent>
    where TChild : class, IStrongDoubleWideTreeChainNode
    where TNext : class, IStrongDoubleWideTreeChainNode
    where TParent : class, IStrongDoubleWideTreeChainNode
{
    IStrongDoubleWideTreeChainNode? IStrongDoubleWideTreeChainNode.Next => ((IWideTreeNode<TSelf, TChild?, TNext?>)this).Next;
    IStrongDoubleWideTreeChainNode? IStrongDoubleWideTreeChainNode.Child => ((IWideTreeNode<TSelf, TChild?, TNext?>)this).Child;
    IStrongDoubleWideTreeChainNode? IStrongDoubleWideTreeChainNode.Parent => ((IWideTreeNode<TSelf, TChild?, TNext?, TParent?>)this).Parent;
}

#endregion