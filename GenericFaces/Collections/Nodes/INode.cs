namespace GenericFaces.Collections.Nodes;

#region INode

public interface INode<out TSelf> : INode<TSelf, TSelf>
    where TSelf : INode<TSelf>, allows ref struct;

public interface INode<out TSelf, out TNext>
    where TSelf : INode<TSelf, TNext>, allows ref struct
    where TNext : allows ref struct
{
    public TNext Next { get; }
}

public interface INode<out TSelf, out TNext, out TPrevious> : INode<TSelf, TNext>
    where TSelf : INode<TSelf, TNext, TPrevious>, allows ref struct
    where TNext : allows ref struct
    where TPrevious : allows ref struct
{
    public TPrevious Previous { get; }
}

#endregion

#region IDoubleNode

public interface IDoubleNode<out TSelf> : IDoubleNode<TSelf, TSelf>
    where TSelf : IDoubleNode<TSelf>, allows ref struct;

public interface IDoubleNode<out TSelf, out TPrevious> : INode<TSelf, TSelf, TPrevious>, INode<TSelf>
    where TSelf : IDoubleNode<TSelf, TPrevious>, allows ref struct
    where TPrevious : allows ref struct;

#endregion

#region IChainNode

public interface IChainNode
{
    public IChainNode? Next { get; }
}

public interface IChainNode<out TSelf> : IChainNode<TSelf, TSelf>
    where TSelf : class, IChainNode<TSelf>;

public interface IChainNode<out TSelf, out TNext> : INode<TSelf, TNext?>, IChainNode
    where TSelf : class, IChainNode<TSelf, TNext>
    where TNext : class, IChainNode
{
    IChainNode? IChainNode.Next => ((INode<TSelf, TNext?>)this).Next;
}
public interface IChainNode<out TSelf, out TNext, out TPrevious> : IChainNode<TSelf, TNext>, INode<TSelf, TNext?, TPrevious?>, IDoubleChainNode
    where TSelf : class, IChainNode<TSelf, TNext, TPrevious>
    where TNext : class, IChainNode
    where TPrevious : class, IChainNode
{
    IChainNode? IDoubleChainNode.Previous => ((INode<TSelf, TNext?, TPrevious?>)this).Previous;
}

#endregion

#region IDoubleChainNode

public interface IDoubleChainNode : IChainNode
{
    public IChainNode? Previous { get; }
}

public interface IDoubleChainNode<out TSelf> : IDoubleChainNode<TSelf, TSelf>, IDoubleNode<TSelf>
    where TSelf : class, IDoubleChainNode<TSelf>;

public interface IDoubleChainNode<out TSelf, out TPrevious> : IChainNode<TSelf, TSelf, TPrevious>, IChainNode<TSelf>, IDoubleNode<TSelf, TPrevious>
    where TSelf : class, IDoubleChainNode<TSelf, TPrevious>
    where TPrevious : class, IChainNode;

#endregion

#region IStrongDoubleChainNode

public interface IStrongDoubleChainNode : IDoubleChainNode
{
    public new IStrongDoubleChainNode? Next { get; }
    public new IStrongDoubleChainNode? Previous { get; }

    IChainNode? IChainNode.Next => Next;
    IChainNode? IDoubleChainNode.Previous => Previous;
}

public interface IStrongDoubleChainNode<out TSelf> : IStrongDoubleChainNode<TSelf, TSelf>, IDoubleChainNode<TSelf>
    where TSelf : class, IStrongDoubleChainNode<TSelf>;

public interface IStrongDoubleChainNode<out TSelf, out TPrevious> : IStrongDoubleChainNode<TSelf, TSelf, TPrevious>, IDoubleChainNode<TSelf, TPrevious>
    where TSelf : class, IStrongDoubleChainNode<TSelf, TPrevious>
    where TPrevious : class, IStrongDoubleChainNode;

public interface IStrongDoubleChainNode<out TSelf, out TNext, out TPrevious> : IChainNode<TSelf, TNext, TPrevious>, IStrongDoubleChainNode
    where TSelf : class, IStrongDoubleChainNode<TSelf, TNext, TPrevious>
    where TNext : class, IStrongDoubleChainNode
    where TPrevious : class, IStrongDoubleChainNode
{
    IStrongDoubleChainNode? IStrongDoubleChainNode.Next => ((INode<TSelf, TNext?>)this).Next;
    IStrongDoubleChainNode? IStrongDoubleChainNode.Previous => ((INode<TSelf, TNext?, TPrevious?>)this).Previous;
}

#endregion