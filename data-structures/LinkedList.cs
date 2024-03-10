namespace DataStructures
{
  class LinkedList<T>
  {
    private int _count = 0;
    private Node<T>? _head = default;

    private Node<T>? GetNodeAt(int index)
    {
      if (index < 0 || index >= _count) return null;
      Node<T>? node = _head;
      for (var i = 0; i < index && node != null; i++)
      {
        node = node.Next;
      }
      return node;
    }

    public T? Pop()
    {
      if (Size() == 0) return default;
      return RemoveAt(Size() - 1);
    }

    public void Push(T element)
    {
      var node = new Node<T>(element);

      if (_head == null)
      {
        _head = node;
      }
      else
      {
        var current = _head;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = node;
      }
      _count++;
    }

    public T? RemoveAt(int index)
    {
      T? removed = default;

      if (index < 0 || index >= _count) return removed;
      if (_head == null) return removed;

      if (index == 0)
      {
        removed = _head.Element;
        _head = _head.Next;
      }

      var previous = GetNodeAt(index - 1);

      if (previous?.Next != null)
      {
        removed = previous.Next.Element;
        // skip one node to remove it
        previous.Next = previous.Next.Next;
      }

      if (removed != null)
      {
        _count--;
      }

      return removed;
    }



    public int Size()
    {
      return _count;
    }
  }
}

class Node<T>(T element)
{
  public T Element { get; } = element;
  public Node<T>? Next { get; set; } = default;
}