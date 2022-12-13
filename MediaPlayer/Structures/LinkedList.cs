using System;
using MediaPlayer.Structures.Interfaces;

namespace MediaPlayer.Structures
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private int size { get; set; }
        private Node<T> first { get; set; }
        private Node<T> last { get; set; }
        public LinkedList()
        {
            size = 0;
            first = null;
            last = null;
        }

        private bool IsEmpty()
        {
            return first == null && last == null && size == 0;
        }
        private bool IsElementIndex(int index)
        {
            return index >= 0 && index < size;
        }
        private bool IsPositionIndex(int index)
        {
            return index >= 0 && index <= size;
        }

        private string OutOfBoundsMsg(int index)
        {
            return $"[Out of Bound] Index: {index}, Size: {size}";
        }
        private void CheckElementIndex(int index)
        {
            if (!IsElementIndex(index))
                throw new Exception(OutOfBoundsMsg(index));
        }
        private void CheckPositionIndex(int index)
        {
            if (!IsPositionIndex(index))
                throw new Exception(OutOfBoundsMsg(index));
        }
        #region Handler
        private void Link(T item, Node<T> _next)
        {
            Node<T> _prev = _next.GetNodePrev();
            Node<T> newNode = new Node<T>(_prev, item, _next);
            _next.SetNodePrev(newNode);
            if (_prev == null)
                first = newNode;
            else
                _prev.SetNodePrev(newNode);
            size++;
        }
        private void LinkFirst(T item)
        {
            Node<T> _first = first;
            Node<T> newNode = new Node<T>(null, item, first);
            first = newNode;
            if (_first == null)
                last = newNode;
            else
                _first.SetNodePrev(newNode);
            size++;
        }
        private void LinkLast(T item)
        {
            Node<T> _last = last;
            Node<T> newNode = new Node<T>(_last, item, null);
            last = newNode;
            if (_last == null)
                first = newNode;
            else
                _last.SetNodeNext(newNode);
            size++;
        }
        private void Unlink(Node<T> item)
        {
            Node<T> _next = item.GetNodeNext();
            Node<T> _prev = item.GetNodePrev();

            if (_prev == null)
            {
                first = _next;
            } else
            {
                _prev.SetNodeNext(_next);
                item.SetNodePrev(null);
            }

            if (_next == null)
            {
                last = _prev;
            }
            else
            {
                _next.SetNodePrev(_prev);
                item.SetNodeNext(null);
            }

            item.SetItem(default);
            size--;
        }
        private void UnlinkFirst()
        {
            Node<T> _first = first;
            Node<T> _next = _first.GetNodeNext();
            _first.SetItem(default);
            first = _next;
            if (_next == null)
                last = null;
            else
            {
                _first.SetNodeNext(null);
                _next.SetNodePrev(null);
            }
            size--;
        }
        private void UnlinkLast()
        {
            Node<T> _last = last;
            Node<T> _prev = _last.GetNodePrev();
            _last.SetItem(default);
            last = _prev;
            if (_prev == null)
                first = null;
            else
            {
                _last.SetNodePrev(null);
                _prev.SetNodeNext(null);
            }
            size--;
        }
        #endregion
        public Node<T> Node(int index)
        {
            Node<T> item = first;
            for (int i = 0; i < index; i++)
                item = item.GetNodeNext();
            return item;
        }
        public int GetSize()
        {
            return this.size;
        }
        public T Get(int index)
        {
            CheckElementIndex(index);

            return Node(index).GetItem();
        }
        public T GetFirst()
        {
            if (first == null)
                return default;
            return first.GetItem();
        }
        public T GetLast()
        {
            if (last == null)
                return default;
            return last.GetItem();
        }
        public void Set(int index, T element)
        {
            CheckElementIndex(index);

            Node(index).SetItem(element);
        }
        public void SetFirst(T element)
        {
            if (first == null)
                return;

            first.SetItem(element);
        }
        public void SetLast(T element)
        {
            if (last == null)
                return;

            last.SetItem(element);
        }
        public void Add(int index, T element)
        {
            CheckPositionIndex(index);

            if (index == size)
                LinkLast(element);
            else
                Link(element, Node(index));
        }
        public void AddFirst(T element)
        {
            LinkFirst(element);
        }
        public void AddLast(T element)
        {
            LinkLast(element);
        }
        public void Remove(int index)
        {
            CheckElementIndex(index);
            Unlink(Node(index));
        }

        public void RemoveFirst()
        {
            if (first != null)
                UnlinkFirst();
        }

        public void RemoveLast()
        {
            if (last != null)
                UnlinkLast();
        }
        public T FindItem(int index)
        {
            CheckElementIndex(index);

            return Node(index).GetItem();
        }
        public int FindIndex(T element)
        {
            Node<T> item = first;
            for (int i = 0; i < size; i++)
            {
                if (item.GetItem().Equals(element))
                    return i;

                item = item.GetNodeNext();
            }
            return default;
        }

        public void Clear()
        {
            Node<T> item = first;
            while (item != null)
            {
                Node<T> _next = item.GetNodeNext();
                item.SetItem(default(T));
                item.SetNodeNext(null);
                item.SetNodePrev(null);
                item = _next;
            }
            first = last = null;
            size = 0;
        }
    }
}