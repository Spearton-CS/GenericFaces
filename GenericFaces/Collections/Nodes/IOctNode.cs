namespace GenericFaces.Collections.Nodes;

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

public interface IOctNode<out TSelf> : IOctNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf>
    where TSelf : IOctNode<TSelf>, allows ref struct;
public interface IDoubleOctNode<out TSelf, out TParent> : IOctNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IOctNode<TSelf>
    where TSelf : IDoubleOctNode<TSelf, TParent>, allows ref struct
    where TParent : allows ref struct;
public interface IDoubleOctNode<out TSelf> : IDoubleOctNode<TSelf, TSelf>
    where TSelf : IDoubleOctNode<TSelf>, allows ref struct;


public interface IOctChainNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8> : IOctNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>
    where TSelf : class, IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
    where T6 : class
    where T7 : class
    where T8 : class;
public interface IOctChainNode<out TSelf, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out TParent> : IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8>, IOctNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8, TParent>
    where TSelf : class, IOctChainNode<TSelf, T1, T2, T3, T4, T5, T6, T7, T8, TParent>
    where T1 : class
    where T2 : class
    where T3 : class
    where T4 : class
    where T5 : class
    where T6 : class
    where T7 : class
    where T8 : class
    where TParent : class;

public interface IOctChainNode<out TSelf> : IOctChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf>, IOctNode<TSelf>
    where TSelf : class, IOctChainNode<TSelf>;
public interface IDoubleOctChainNode<out TSelf, out TParent> : IOctChainNode<TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TSelf, TParent>, IDoubleOctNode<TSelf, TParent>
    where TSelf : class, IDoubleOctChainNode<TSelf, TParent>
    where TParent : class;
public interface IDoubleOctChainNode<out TSelf> : IDoubleOctChainNode<TSelf, TSelf>, IDoubleOctNode<TSelf>
    where TSelf : class, IDoubleOctChainNode<TSelf>;