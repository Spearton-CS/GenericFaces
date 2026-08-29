namespace GenericFaces.Construction;

#region Implicit

public interface IImplicitFromOperators<TSelf, TOther>
    where TSelf : IImplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static implicit operator TSelf(TOther other);
}

public interface IImplicitToOperators<TSelf, TOther>
    where TSelf : IImplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static implicit operator TOther(TSelf other);
}

public interface IImplicitOperators<TSelf, TOther>
    : IImplicitFromOperators<TSelf, TOther>, IImplicitToOperators<TSelf, TOther>
    where TSelf : IImplicitOperators<TSelf, TOther>
    where TOther : allows ref struct;

#endregion

#region Explicit

public interface IExplicitFromOperators<TSelf, TOther>
    where TSelf : IExplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TSelf(TOther other);
}

public interface IExplicitToOperators<TSelf, TOther>
    where TSelf : IExplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TOther(TSelf other);
}

public interface IExplicitOperators<TSelf, TOther>
    : IExplicitFromOperators<TSelf, TOther>, IExplicitToOperators<TSelf, TOther>
    where TSelf : IExplicitOperators<TSelf, TOther>
    where TOther : allows ref struct;

#endregion