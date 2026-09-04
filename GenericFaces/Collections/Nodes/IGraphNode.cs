namespace GenericFaces.Collections.Nodes;

#region IGraphNode

public interface IGraphNode<out TSelf, out TEnumerable> : IGraphNode<TSelf, TSelf, TEnumerable, TSelf, TEnumerable>
    where TSelf : IGraphNode<TSelf, TEnumerable>, allows ref struct
    where TEnumerable : IEnumerable<TSelf>?, allows ref struct;

public interface IGraphNode<out TSelf, out TNext, out TNextEnumerable>
    where TSelf : IGraphNode<TSelf, TNext, TNextEnumerable>, allows ref struct
    where TNext : allows ref struct
    where TNextEnumerable : IEnumerable<TNext>?, allows ref struct
{
    public TNextEnumerable Next { get; }
}

public interface IGraphNode<out TSelf, out TNext, out TNextEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphNode<TSelf, TNext, TNextEnumerable>
    where TSelf : IGraphNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>, allows ref struct
    where TNext : allows ref struct
    where TNextEnumerable : IEnumerable<TNext>?, allows ref struct
    where TPrevious : allows ref struct
    where TPreviousEnumerable : IEnumerable<TPrevious>?, allows ref struct
{
    public TPreviousEnumerable Previous { get; }
}

#endregion

#region IBoxedGraphNode

public interface IBoxedGraphNode<out TSelf> : IGraphNode<TSelf, IEnumerable<TSelf>>, IBoxedGraphNode<TSelf, TSelf, TSelf>
    where TSelf : IBoxedGraphNode<TSelf>, allows ref struct;

public interface IBoxedGraphNode<out TSelf, out TNext> : IGraphNode<TSelf, TNext, IEnumerable<TNext>>
    where TSelf : IBoxedGraphNode<TSelf, TNext>, allows ref struct
    where TNext : allows ref struct;

public interface IBoxedGraphNode<out TSelf, out TNext, out TPrevious> : IGraphNode<TSelf, TNext, IEnumerable<TNext>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphNode<TSelf, TNext>
    where TSelf : IBoxedGraphNode<TSelf, TNext, TPrevious>, allows ref struct
    where TNext : allows ref struct
    where TPrevious : allows ref struct;

#endregion

#region IDoubleGraphNode

public interface IDoubleGraphNode<out TSelf> : IDoubleGraphNode<TSelf, IEnumerable<TSelf>, TSelf, IEnumerable<TSelf>>, IBoxedGraphNode<TSelf>
    where TSelf : IDoubleGraphNode<TSelf>, allows ref struct;

public interface IDoubleGraphNode<out TSelf, out TPrevious> : IDoubleGraphNode<TSelf, IEnumerable<TSelf>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphNode<TSelf, TSelf, TPrevious>
    where TSelf : IDoubleGraphNode<TSelf, TPrevious>, allows ref struct
    where TPrevious : allows ref struct;

public interface IDoubleGraphNode<out TSelf, out TEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphNode<TSelf, TSelf, TEnumerable, TPrevious, TPreviousEnumerable>
    where TSelf : IDoubleGraphNode<TSelf, TEnumerable, TPrevious, TPreviousEnumerable>, allows ref struct
    where TEnumerable : IEnumerable<TSelf>?, allows ref struct
    where TPrevious : allows ref struct
    where TPreviousEnumerable : IEnumerable<TPrevious>?, allows ref struct;

#endregion

#region IGraphChainNode

public interface IGraphChainNode
{
    public IEnumerable<IGraphChainNode>? Next { get; }
}

public interface IGraphChainNode<out TSelf, out TEnumerable> : IGraphChainNode<TSelf, TSelf, TEnumerable, TSelf, TEnumerable>, IGraphNode<TSelf, TEnumerable?>
    where TSelf : class, IGraphChainNode<TSelf, TEnumerable>
    where TEnumerable : IEnumerable<TSelf>?;

public interface IGraphChainNode<out TSelf, out TNext, out TNextEnumerable> : IGraphNode<TSelf, TNext?, TNextEnumerable?>, IGraphChainNode
    where TSelf : class, IGraphChainNode<TSelf, TNext, TNextEnumerable>
    where TNext : class, IGraphChainNode
    where TNextEnumerable : IEnumerable<TNext>?
{
    IEnumerable<IGraphChainNode>? IGraphChainNode.Next => ((IGraphNode<TSelf, TNext?, TNextEnumerable?>)this).Next;
}

public interface IGraphChainNode<out TSelf, out TNext, out TNextEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphChainNode<TSelf, TNext, TNextEnumerable>, IGraphNode<TSelf, TNext?, TNextEnumerable?, TPrevious?, TPreviousEnumerable?>, IDoubleGraphChainNode
    where TSelf : class, IGraphChainNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>
    where TNext : class, IGraphChainNode
    where TNextEnumerable : IEnumerable<TNext>?
    where TPrevious : class, IGraphChainNode
    where TPreviousEnumerable : IEnumerable<TPrevious>?
{
    IEnumerable<IGraphChainNode>? IDoubleGraphChainNode.Previous => ((IGraphNode<TSelf, TNext?, TNextEnumerable?, TPrevious?, TPreviousEnumerable?>)this).Previous;
}

#endregion

#region IBoxedGraphChainNode

public interface IBoxedGraphChainNode<out TSelf> : IGraphChainNode<TSelf, IEnumerable<TSelf>>, IBoxedGraphChainNode<TSelf, TSelf>
    where TSelf : class, IBoxedGraphChainNode<TSelf>;

public interface IBoxedGraphChainNode<out TSelf, out TNext> : IGraphChainNode<TSelf, TNext, IEnumerable<TNext>>, IBoxedGraphNode<TSelf, TNext?>
    where TSelf : class, IBoxedGraphChainNode<TSelf, TNext>
    where TNext : class, IGraphChainNode;

public interface IBoxedGraphChainNode<out TSelf, out TNext, out TPrevious> : IGraphChainNode<TSelf, TNext, IEnumerable<TNext>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphChainNode<TSelf, TNext>, IBoxedGraphNode<TSelf, TNext?, TPrevious?>
    where TSelf : class, IBoxedGraphChainNode<TSelf, TNext, TPrevious>
    where TNext : class, IGraphChainNode
    where TPrevious : class, IGraphChainNode;

#endregion

#region IDoubleGraphChainNode

public interface IDoubleGraphChainNode : IGraphChainNode
{
    public IEnumerable<IGraphChainNode>? Previous { get; }
}

public interface IDoubleGraphChainNode<out TSelf> : IDoubleGraphChainNode<TSelf, IEnumerable<TSelf>, TSelf, IEnumerable<TSelf>>, IBoxedGraphChainNode<TSelf>, IDoubleGraphNode<TSelf>
    where TSelf : class, IDoubleGraphChainNode<TSelf>;

public interface IDoubleGraphChainNode<out TSelf, out TPrevious> : IDoubleGraphChainNode<TSelf, IEnumerable<TSelf>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphChainNode<TSelf, TSelf, TPrevious>, IDoubleGraphNode<TSelf, TPrevious>
    where TSelf : class, IDoubleGraphChainNode<TSelf, TPrevious>
    where TPrevious : class, IGraphChainNode;

public interface IDoubleGraphChainNode<out TSelf, out TEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphChainNode<TSelf, TSelf, TEnumerable, TPrevious, TPreviousEnumerable>, IDoubleGraphNode<TSelf, TEnumerable?, TPrevious?, TPreviousEnumerable?>
    where TSelf : class, IDoubleGraphChainNode<TSelf, TEnumerable, TPrevious, TPreviousEnumerable>
    where TEnumerable : IEnumerable<TSelf>?
    where TPrevious : class, IGraphChainNode
    where TPreviousEnumerable : IEnumerable<TPrevious>?;

#endregion

#region IStrongDoubleGraphChainNode

public interface IStrongDoubleGraphChainNode : IDoubleGraphChainNode
{
    public new IEnumerable<IStrongDoubleGraphChainNode>? Next { get; }
    public new IEnumerable<IStrongDoubleGraphChainNode>? Previous { get; }

    IEnumerable<IGraphChainNode>? IGraphChainNode.Next => Next;
    IEnumerable<IGraphChainNode>? IDoubleGraphChainNode.Previous => Previous;
}

public interface IStrongDoubleGraphChainNode<out TSelf> : IStrongDoubleGraphChainNode<TSelf, IEnumerable<TSelf>>, IDoubleGraphChainNode<TSelf>
    where TSelf : class, IStrongDoubleGraphChainNode<TSelf>;

public interface IStrongDoubleGraphChainNode<out TSelf, out TEnumerable> : IStrongDoubleGraphChainNode<TSelf, TSelf, TEnumerable, TSelf, TEnumerable>, IGraphChainNode<TSelf, TEnumerable>
    where TSelf : class, IStrongDoubleGraphChainNode<TSelf, TEnumerable>
    where TEnumerable : IEnumerable<TSelf>?;

public interface IStrongDoubleGraphChainNode<out TSelf, out TNext, out TNextEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphChainNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>, IStrongDoubleGraphChainNode
    where TSelf : class, IStrongDoubleGraphChainNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>
    where TNext : class, IStrongDoubleGraphChainNode
    where TNextEnumerable : IEnumerable<TNext>?
    where TPrevious : class, IStrongDoubleGraphChainNode
    where TPreviousEnumerable : IEnumerable<TPrevious>?
{
    IEnumerable<IStrongDoubleGraphChainNode>? IStrongDoubleGraphChainNode.Next => ((IGraphNode<TSelf, TNext?, TNextEnumerable?>)this).Next;
    IEnumerable<IStrongDoubleGraphChainNode>? IStrongDoubleGraphChainNode.Previous => ((IGraphNode<TSelf, TNext?, TNextEnumerable?, TPrevious?, TPreviousEnumerable?>)this).Previous;
}

#endregion