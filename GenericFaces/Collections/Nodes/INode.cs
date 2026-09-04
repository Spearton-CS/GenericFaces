namespace GenericFaces.Collections.Nodes;

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

public interface INode<out TSelf> : INode<TSelf, TSelf>
    where TSelf : INode<TSelf>, allows ref struct;
public interface IDoubleNode<out TSelf, out TPrevious> : INode<TSelf, TSelf, TPrevious>, INode<TSelf>
    where TSelf : IDoubleNode<TSelf, TPrevious>, allows ref struct
    where TPrevious : allows ref struct;
public interface IDoubleNode<out TSelf> : IDoubleNode<TSelf, TSelf>
    where TSelf : IDoubleNode<TSelf>, allows ref struct;

public interface IChainNode<out TSelf, out TNext> : INode<TSelf, TNext?>
    where TSelf : class, IChainNode<TSelf, TNext>
    where TNext : class;
public interface IChainNode<out TSelf, out TNext, out TPrevious> : IChainNode<TSelf, TNext>, INode<TSelf, TNext?, TPrevious>
    where TSelf : class, IChainNode<TSelf, TNext, TPrevious>
    where TNext : class
    where TPrevious : class;

public interface IChainNode<out TSelf> : IChainNode<TSelf, TSelf>
    where TSelf : class, IChainNode<TSelf>;
public interface IDoubleChainNode<out TSelf, out TPrevious> : IChainNode<TSelf, TSelf, TPrevious>, IChainNode<TSelf>
    where TSelf : class, IDoubleChainNode<TSelf, TPrevious>
    where TPrevious : class;
public interface IDoubleChainNode<out TSelf> : IDoubleChainNode<TSelf, TSelf>
    where TSelf : class, IDoubleChainNode<TSelf>;