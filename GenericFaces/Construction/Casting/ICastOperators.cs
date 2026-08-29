namespace GenericFaces.Construction.Casting;

#region Implicit

public interface IImplicitFromOperators<out TSelf, in TOther>
    where TSelf : IImplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static implicit operator TSelf(TOther other);
}

public interface IImplicitToOperators<in TSelf, out TOther>
    where TSelf : IImplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static implicit operator TOther(TSelf self);
}

public interface IImplicitOperators<TSelf, TOther>
    : IImplicitFromOperators<TSelf, TOther>, IImplicitToOperators<TSelf, TOther>
    where TSelf : IImplicitOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct;

#endregion

#region Explicit

public interface IExplicitFromOperators<out TSelf, in TOther>
    where TSelf : IExplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TSelf(TOther self);
}

public interface IExplicitToOperators<in TSelf, out TOther>
    where TSelf : IExplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TOther(TSelf other);
}

public interface IExplicitOperators<TSelf, TOther>
    : IExplicitFromOperators<TSelf, TOther>, IExplicitToOperators<TSelf, TOther>
    where TSelf : IExplicitOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct;

#endregion

#region Explicit checked

public interface ICheckedExplicitFromOperators<out TSelf, in TOther>
    : IExplicitFromOperators<TSelf, TOther>
    where TSelf : ICheckedExplicitFromOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TSelf(TOther other);
    public abstract static explicit operator checked TSelf(TOther other);
}

public interface ICheckedExplicitToOperators<in TSelf, out TOther>
    : IExplicitToOperators<TSelf, TOther>
    where TSelf : ICheckedExplicitToOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct
{
    public abstract static explicit operator TOther(TSelf self);
    public abstract static explicit operator checked TOther(TSelf self);
}

public interface ICheckedExplicitOperators<TSelf, TOther>
    : ICheckedExplicitFromOperators<TSelf, TOther>, ICheckedExplicitToOperators<TSelf, TOther>
    where TSelf : ICheckedExplicitOperators<TSelf, TOther>, allows ref struct
    where TOther : allows ref struct;

#endregion