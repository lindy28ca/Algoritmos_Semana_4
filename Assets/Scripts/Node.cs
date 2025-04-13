
public class Node<T>
{
    #region Private
    private T value;
    private Node<T> next = null;
    private Node<T> prev = null;
    #endregion
    #region Getters
    public T Value => value;
    public Node<T> Next => next;
    public Node<T> Prev => prev;
    #endregion
    #region Setter
    public Node(T _value)
    {
        value = _value;
    }

    public void SetNext(Node<T> _next)
    {
        next = _next;
    }
    public void SetPrev(Node<T> _prev)
    {
        prev = _prev;
    }
    #endregion
}
