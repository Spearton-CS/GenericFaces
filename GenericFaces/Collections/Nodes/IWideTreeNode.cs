namespace GenericFaces.Collections.Nodes;

public interface IWideTreeNode<out TSelf, out TChild, out TNext>
    where TSelf : IWideTreeNode<TSelf, TChild, TNext>, allows ref struct
    where TChild : allows ref struct
    where TNext : allows ref struct
{
    public TChild Child { get; }
    public TNext Next { get; }
}
public interface IWideTreeNode<out TSelf, out TChild, out TNext, out TParent> : IWideTreeNode<TSelf, TChild, TNext>
    where TSelf : IWideTreeNode<TSelf, TChild, TNext, TParent>, allows ref struct
    where TChild : allows ref struct
    where TNext : allows ref struct
    where TParent : allows ref struct
{
    public TParent Parent { get; }
}

public interface IWideTreeNode<out TSelf> : IWideTreeNode<TSelf, TSelf, TSelf>
    where TSelf : IWideTreeNode<TSelf>, allows ref struct;

public interface IDoubleWideTreeNode<out TSelf, out TParent> : IWideTreeNode<TSelf, TSelf, TSelf, TParent>, IWideTreeNode<TSelf>
    where TSelf : IDoubleWideTreeNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;
public interface IDoubleWideTreeNode<out TSelf> : IDoubleWideTreeNode<TSelf, TSelf>
    where TSelf : IDoubleWideTreeNode<TSelf>, allows ref struct;


public interface IWideTreeChainNode<out TSelf, out TChild, out TNext> : IWideTreeNode<TSelf, TChild, TNext>
    where TSelf : IWideTreeChainNode<TSelf, TChild, TNext>, allows ref struct
    where TChild : allows ref struct
    where TNext : allows ref struct;
public interface IWideTreeChainNode<out TSelf, out TChild, out TNext, out TParent> : IWideTreeChainNode<TSelf, TChild, TNext>, IWideTreeNode<TSelf, TChild, TNext, TParent>
    where TSelf : IWideTreeChainNode<TSelf, TChild, TNext, TParent>, allows ref struct
    where TChild : allows ref struct
    where TNext : allows ref struct
    where TParent : allows ref struct;

public interface IWideTreeChainNode<out TSelf> : IWideTreeChainNode<TSelf, TSelf, TSelf>, IWideTreeNode<TSelf>
    where TSelf : IWideTreeChainNode<TSelf>, allows ref struct;

public interface IDoubleWideTreeChainNode<out TSelf, out TParent> : IWideTreeChainNode<TSelf, TSelf, TSelf, TParent>, IWideTreeChainNode<TSelf>, IDoubleWideTreeNode<TSelf, TParent>
    where TSelf : IDoubleWideTreeChainNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;
public interface IDoubleWideTreeChainNode<out TSelf> : IDoubleWideTreeChainNode<TSelf, TSelf>, IDoubleWideTreeNode<TSelf>
    where TSelf : IDoubleWideTreeChainNode<TSelf>, allows ref struct;