namespace GenericFaces.Construction;

public interface IDefaultConstructible<TSelf> where TSelf : IDefaultConstructible<TSelf>, new(), allows ref struct;