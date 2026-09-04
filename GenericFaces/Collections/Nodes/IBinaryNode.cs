namespace GenericFaces.Collections.Nodes;

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

public interface IBinaryNode<out TSelf> : IBinaryNode<TSelf, TSelf, TSelf>
    where TSelf : IBinaryNode<TSelf>, allows ref struct;
public interface IDoubleBinaryNode<out TSelf, out TParent> : IBinaryNode<TSelf, TSelf, TSelf, TParent>, IBinaryNode<TSelf>
    where TSelf : IDoubleBinaryNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;
public interface IDoubleBinaryNode<out TSelf> : IDoubleBinaryNode<TSelf, TSelf>
    where TSelf : IDoubleBinaryNode<TSelf>, allows ref struct;

public interface IBinaryChainNode<out TSelf, out TLeft, out TRight> : IBinaryNode<TSelf, TLeft, TRight>
    where TSelf : class, IBinaryNode<TSelf, TLeft, TRight>
    where TLeft : class
    where TRight : class;
public interface IBinaryChainNode<out TSelf, out TLeft, out TRight, out TParent> : IBinaryChainNode<TSelf, TLeft, TRight>, IBinaryNode<TSelf, TLeft, TRight, TParent>
    where TSelf : class, IBinaryNode<TSelf, TLeft, TRight, TParent>
    where TLeft : class
    where TRight : class
    where TParent : class;

public interface IBinaryChainNode<out TSelf> : IBinaryChainNode<TSelf, TSelf, TSelf>, IBinaryNode<TSelf>
    where TSelf : class, IBinaryChainNode<TSelf>;
public interface IDoubleBinaryChainNode<out TSelf, out TParent> : IBinaryChainNode<TSelf, TSelf, TSelf, TParent>, IDoubleBinaryNode<TSelf, TParent>
    where TSelf : class, IDoubleBinaryChainNode<TSelf, TParent>
    where TParent : class;
public interface IDoubleBinaryChainNode<out TSelf> : IDoubleBinaryChainNode<TSelf, TSelf>, IDoubleBinaryNode<TSelf>
    where TSelf : class, IDoubleBinaryChainNode<TSelf>;