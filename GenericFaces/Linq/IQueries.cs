namespace GenericFaces.Linq;

public interface ISelectable<TSource, out TResultCollection>
    where TSource : allows ref struct
    where TResultCollection : allows ref struct
{
    TResultCollection Select<TResult>(Func<TSource, TResult> selector)
        where TResult : allows ref struct;
}

public interface IWhereable<TSource, out TResult>
    where TSource : allows ref struct
    where TResult : allows ref struct
{
    TResult Where(Func<TSource, bool> predicate);
}

public interface ISelectManyable<TSource, out TResultCollection>
    where TSource : allows ref struct
    where TResultCollection : allows ref struct
{
    TResultCollection SelectMany<TResult>(
        Func<TSource, IEnumerable<TResult>> selector)
        where TResult : allows ref struct => SelectMany(selector, static (_, element) => element);
    TResultCollection SelectMany<TIntermediate, TResult>(
        Func<TSource, IEnumerable<TIntermediate>> intermediateSelector,
        Func<TSource, TIntermediate, TResult> resultSelector)
        where TIntermediate : allows ref struct
        where TResult : allows ref struct;
}

public interface IJoinable<TSource, out TResultCollection>
    where TSource : allows ref struct
    where TResultCollection : allows ref struct
{
    TResultCollection Join<TInner, TKey, TResult>(
        IEnumerable<TInner> inner,
        Func<TSource, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TSource, TInner, TResult> resultSelector)
        where TInner : allows ref struct
        where TKey : allows ref struct
        where TResult : allows ref struct;
}

public interface IGroupJoinable<TSource, out TResultCollection>
    where TSource : allows ref struct
    where TResultCollection : allows ref struct
{
    TResultCollection GroupJoin<TInner, TKey, TResult>(
        IEnumerable<TInner> inner,
        Func<TSource, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TSource, IEnumerable<TInner>, TResult> resultSelector)
        where TInner : allows ref struct
        where TKey : allows ref struct
        where TResult : allows ref struct;
}

public interface IGroupable<TSource, out TResultCollection>
    where TSource : allows ref struct
    where TResultCollection : allows ref struct
{
    TResultCollection GroupBy<TKey, TElement>(
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector)
        where TKey : allows ref struct
        where TElement : allows ref struct;

    TResultCollection GroupBy<TKey>(
        Func<TSource, TKey> keySelector)
        where TKey : allows ref struct
        => GroupBy(keySelector, static x => x);
}

public interface IOrderable<TSource, out TOrderedCollection>
    where TSource : allows ref struct
    where TOrderedCollection : IThenByOrderable<TSource, TOrderedCollection>, allows ref struct
{
    TOrderedCollection OrderBy<TKey>(Func<TSource, TKey> keySelector)
        where TKey : allows ref struct;

    TOrderedCollection OrderByDescending<TKey>(Func<TSource, TKey> keySelector)
        where TKey : allows ref struct;
}

public interface IThenByOrderable<TSource, out TOrderedCollection>
    where TSource : allows ref struct
    where TOrderedCollection : allows ref struct
{
    TOrderedCollection ThenBy<TKey>(Func<TSource, TKey> keySelector)
        where TKey : allows ref struct;

    TOrderedCollection ThenByDescending<TKey>(Func<TSource, TKey> keySelector)
        where TKey : allows ref struct;
}