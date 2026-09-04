namespace GenericFaces.Collections.Nodes;

#region IBinaryNode

public interface IBinaryNode<out TSelf> : IBinaryNode<TSelf, TSelf, TSelf>
    where TSelf : IBinaryNode<TSelf>, allows ref struct;

public interface IBinaryNode<out TSelf, out TLeft, out TRight>
    where TSelf : IBinaryNode<TSelf, TLeft, TRight>, allows ref struct
    where TLeft : allows ref struct
    where TRight : allows ref struct
{
    public TLeft Left { get; }
    public TRight Right { get; }
}
public interface IBinaryNode<out TSelf, out TLeft, out TRight, out TParent> : IBinaryNode<TSelf, TLeft, TRight>
    where TSelf : IBinaryNode<TSelf, TLeft, TRight, TParent>, allows ref struct
    where TLeft : allows ref struct
    where TRight : allows ref struct
    where TParent : allows ref struct
{
    public TParent Parent { get; }
}

#endregion

#region IDoubleBinaryNode

public interface IDoubleBinaryNode<out TSelf> : IDoubleBinaryNode<TSelf, TSelf>
    where TSelf : IDoubleBinaryNode<TSelf>, allows ref struct;

public interface IDoubleBinaryNode<out TSelf, out TParent> : IBinaryNode<TSelf, TSelf, TSelf, TParent>, IBinaryNode<TSelf>
    where TSelf : IDoubleBinaryNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;

#endregion

#region IBinaryChainNode

public interface IBinaryChainNode
{
    public IBinaryChainNode? Left { get; }
    public IBinaryChainNode? Right { get; }
}

public interface IBinaryChainNode<out TSelf> : IBinaryChainNode<TSelf, TSelf, TSelf>, IBinaryNode<TSelf>
    where TSelf : class, IBinaryChainNode<TSelf>;

public interface IBinaryChainNode<out TSelf, out TLeft, out TRight> : IBinaryNode<TSelf, TLeft?, TRight?>, IBinaryChainNode
    where TSelf : class, IBinaryChainNode<TSelf, TLeft, TRight>
    where TLeft : class, IBinaryChainNode
    where TRight : class, IBinaryChainNode
{
    IBinaryChainNode? IBinaryChainNode.Left => ((IBinaryNode<TSelf, TLeft?, TRight?>)this).Left;
    IBinaryChainNode? IBinaryChainNode.Right => ((IBinaryNode<TSelf, TLeft?, TRight?>)this).Left;
}

public interface IBinaryChainNode<out TSelf, out TLeft, out TRight, out TParent> : IBinaryChainNode<TSelf, TLeft, TRight>, IBinaryNode<TSelf, TLeft?, TRight?, TParent?>, IDoubleBinaryChainNode
    where TSelf : class, IBinaryChainNode<TSelf, TLeft, TRight, TParent>
    where TLeft : class, IBinaryChainNode
    where TRight : class, IBinaryChainNode
    where TParent : class, IBinaryChainNode
{
    IBinaryChainNode? IDoubleBinaryChainNode.Parent => ((IBinaryNode<TSelf, TLeft?, TRight?, TParent?>)this).Parent;
}

#endregion

#region IDoubleBinaryChainNode

public interface IDoubleBinaryChainNode : IBinaryChainNode
{
    public IBinaryChainNode? Parent { get; }
}

public interface IDoubleBinaryChainNode<out TSelf> : IDoubleBinaryChainNode<TSelf, TSelf>, IDoubleBinaryNode<TSelf>
    where TSelf : class, IDoubleBinaryChainNode<TSelf>;

public interface IDoubleBinaryChainNode<out TSelf, out TParent> : IBinaryChainNode<TSelf, TSelf, TSelf, TParent>, IBinaryChainNode<TSelf>, IDoubleBinaryNode<TSelf, TParent>
    where TSelf : class, IDoubleBinaryChainNode<TSelf, TParent>
    where TParent : class, IBinaryChainNode;

#endregion

#region IStrongDoubleBinaryChainNode

public interface IStrongDoubleBinaryChainNode : IDoubleBinaryChainNode
{
    public new IStrongDoubleBinaryChainNode? Left { get; }
    public new IStrongDoubleBinaryChainNode? Right { get; }
    public new IStrongDoubleBinaryChainNode? Parent { get; }

    IBinaryChainNode? IBinaryChainNode.Left => Left;
    IBinaryChainNode? IBinaryChainNode.Right => Right;
    IBinaryChainNode? IDoubleBinaryChainNode.Parent => Parent;
}

public interface IStrongDoubleBinaryChainNode<out TSelf> : IStrongDoubleBinaryChainNode<TSelf, TSelf>
    where TSelf : class, IStrongDoubleBinaryChainNode<TSelf>;

public interface IStrongDoubleBinaryChainNode<out TSelf, out TParent> : IStrongDoubleBinaryChainNode<TSelf, TSelf, TSelf, TParent>
    where TSelf : class, IStrongDoubleBinaryChainNode<TSelf, TParent>
    where TParent : class, IStrongDoubleBinaryChainNode;

public interface IStrongDoubleBinaryChainNode<out TSelf, out TLeft, out TRight, out TParent> : IBinaryChainNode<TSelf, TLeft, TRight, TParent>, IStrongDoubleBinaryChainNode
    where TSelf : class, IStrongDoubleBinaryChainNode<TSelf, TLeft, TRight, TParent>
    where TLeft : class, IStrongDoubleBinaryChainNode
    where TRight : class, IStrongDoubleBinaryChainNode
    where TParent : class, IStrongDoubleBinaryChainNode
{
    IStrongDoubleBinaryChainNode? IStrongDoubleBinaryChainNode.Left => ((IBinaryNode<TSelf, TLeft?, TRight?>)this).Left;
    IStrongDoubleBinaryChainNode? IStrongDoubleBinaryChainNode.Right => ((IBinaryNode<TSelf, TLeft?, TRight?>)this).Right;
    IStrongDoubleBinaryChainNode? IStrongDoubleBinaryChainNode.Parent => ((IBinaryNode<TSelf, TLeft?, TRight?, TParent?>)this).Parent;
}

#endregion