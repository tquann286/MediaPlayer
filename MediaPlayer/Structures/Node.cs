

namespace MediaPlayer.Structures
{
    public class Node<T>
    {
        private T item { get; set; }
        private Node<T> next { get; set; }
        private Node<T> prev { get; set; }
        public Node(Node<T> _prev, T _item, Node<T> _next)
        {
            item = _item;
            next = _next;
            prev = _prev;
        }
        public T GetItem()
        {
            return item;
        }

        public Node<T> GetNodeNext()
        {
            return next;
        }

        public Node<T> GetNodePrev()
        {
            return prev;
        }

        public void SetItem(T _item)
        {
            item = _item;
        }

        public void SetNodeNext(Node<T> _next)
        {
            next = _next;
        }

        public void SetNodePrev(Node<T> _prev)
        {
            prev = _prev;
        }
    }
}
