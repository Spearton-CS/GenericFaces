namespace GenericFaces.Collections.Nodes;

public interface IGraphNode<out TSelf, out TNext, out TNextEnumerable>
    where TSelf : IGraphNode<TSelf, TNext, TNextEnumerable>, allows ref struct
    where TNext : allows ref struct
    where TNextEnumerable : IEnumerable<TNext>, allows ref struct
{
    public TNextEnumerable Next { get; }
}
public interface IGraphNode<out TSelf, out TNext, out TNextEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphNode<TSelf, TNext, TNextEnumerable>
    where TSelf : IGraphNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>, allows ref struct
    where TNext : allows ref struct
    where TNextEnumerable : IEnumerable<TNext>, allows ref struct
    where TPrevious : allows ref struct
    where TPreviousEnumerable : IEnumerable<TPrevious>, allows ref struct
{
    public TPreviousEnumerable Previous { get; }
}

public interface IGraphNode<out TSelf, out TEnumerable> : IGraphNode<TSelf, TSelf, TEnumerable, TSelf, TEnumerable>
    where TSelf : IGraphNode<TSelf, TEnumerable>, allows ref struct
    where TEnumerable : IEnumerable<TSelf>, allows ref struct;

public interface IBoxedGraphNode<out TSelf> : IGraphNode<TSelf, IEnumerable<TSelf>>, IBoxedGraphNode<TSelf, TSelf, TSelf>
    where TSelf : IBoxedGraphNode<TSelf>, allows ref struct;
public interface IBoxedGraphNode<out TSelf, out TNext> : IGraphNode<TSelf, TNext, IEnumerable<TNext>>
    where TSelf : IBoxedGraphNode<TSelf, TNext>, allows ref struct
    where TNext : allows ref struct;
public interface IBoxedGraphNode<out TSelf, out TNext, out TPrevious> : IGraphNode<TSelf, TNext, IEnumerable<TNext>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphNode<TSelf, TNext>
    where TSelf : IBoxedGraphNode<TSelf, TNext, TPrevious>, allows ref struct
    where TNext : allows ref struct
    where TPrevious : allows ref struct;

public interface IDoubleGraphNode<out TSelf, out TEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphNode<TSelf, TSelf, TEnumerable, TPrevious, TPreviousEnumerable>
    where TSelf : IDoubleGraphNode<TSelf, TEnumerable, TPrevious, TPreviousEnumerable>, allows ref struct
    where TEnumerable : IEnumerable<TSelf>, allows ref struct
    where TPrevious : allows ref struct
    where TPreviousEnumerable : IEnumerable<TPrevious>, allows ref struct;
public interface IDoubleGraphNode<out TSelf, out TPrevious> : IDoubleGraphNode<TSelf, IEnumerable<TSelf>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphNode<TSelf, TSelf, TPrevious>
    where TSelf : IDoubleGraphNode<TSelf, TPrevious>, allows ref struct
    where TPrevious : allows ref struct;
public interface IDoubleGraphNode<out TSelf> : IDoubleGraphNode<TSelf, IEnumerable<TSelf>, TSelf, IEnumerable<TSelf>>, IBoxedGraphNode<TSelf>
    where TSelf : IDoubleGraphNode<TSelf>, allows ref struct;


public interface IGraphChainNode<out TSelf, out TNext, out TNextEnumerable> : IGraphNode<TSelf, TNext, TNextEnumerable>
    where TSelf : class, IGraphChainNode<TSelf, TNext, TNextEnumerable>
    where TNext : class
    where TNextEnumerable : IEnumerable<TNext>, allows ref struct;
public interface IGraphChainNode<out TSelf, out TNext, out TNextEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphChainNode<TSelf, TNext, TNextEnumerable>, IGraphNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>
    where TSelf : class, IGraphChainNode<TSelf, TNext, TNextEnumerable, TPrevious, TPreviousEnumerable>
    where TNext : class
    where TNextEnumerable : IEnumerable<TNext>, allows ref struct
    where TPrevious : class
    where TPreviousEnumerable : IEnumerable<TPrevious>, allows ref struct;

public interface IGraphChainNode<out TSelf, out TEnumerable> : IGraphChainNode<TSelf, TSelf, TEnumerable, TSelf, TEnumerable>, IGraphNode<TSelf, TEnumerable>
    where TSelf : class, IGraphChainNode<TSelf, TEnumerable>
    where TEnumerable : IEnumerable<TSelf>, allows ref struct;

public interface IBoxedGraphChainNode<out TSelf> : IGraphChainNode<TSelf, IEnumerable<TSelf>>, IBoxedGraphChainNode<TSelf, TSelf, TSelf>, IBoxedGraphNode<TSelf>
    where TSelf : class, IBoxedGraphChainNode<TSelf>;
public interface IBoxedGraphChainNode<out TSelf, out TNext> : IGraphChainNode<TSelf, TNext, IEnumerable<TNext>>, IBoxedGraphNode<TSelf, TNext>
    where TSelf : class, IBoxedGraphChainNode<TSelf, TNext>
    where TNext : class;
public interface IBoxedGraphChainNode<out TSelf, out TNext, out TPrevious> : IGraphChainNode<TSelf, TNext, IEnumerable<TNext>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphChainNode<TSelf, TNext>, IBoxedGraphNode<TSelf, TNext, TPrevious>
    where TSelf : class, IBoxedGraphChainNode<TSelf, TNext, TPrevious>
    where TNext : class
    where TPrevious : class;

public interface IDoubleGraphChainNode<out TSelf, out TEnumerable, out TPrevious, out TPreviousEnumerable> : IGraphChainNode<TSelf, TSelf, TEnumerable, TPrevious, TPreviousEnumerable>, IDoubleGraphNode<TSelf, TEnumerable, TPrevious, TPreviousEnumerable>
    where TSelf : class, IDoubleGraphChainNode<TSelf, TEnumerable, TPrevious, TPreviousEnumerable>
    where TEnumerable : IEnumerable<TSelf>, allows ref struct
    where TPrevious : class
    where TPreviousEnumerable : IEnumerable<TPrevious>, allows ref struct;
public interface IDoubleGraphChainNode<out TSelf, out TPrevious> : IDoubleGraphChainNode<TSelf, IEnumerable<TSelf>, TPrevious, IEnumerable<TPrevious>>, IBoxedGraphChainNode<TSelf, TSelf, TPrevious>, IDoubleGraphNode<TSelf, TPrevious>
    where TSelf : class, IDoubleGraphChainNode<TSelf, TPrevious>
    where TPrevious : class;
public interface IDoubleGraphChainMode<out TSelf> : IDoubleGraphChainNode<TSelf, IEnumerable<TSelf>, TSelf, IEnumerable<TSelf>>, IBoxedGraphChainNode<TSelf>, IDoubleGraphNode<TSelf>
    where TSelf : class, IDoubleGraphChainMode<TSelf>;