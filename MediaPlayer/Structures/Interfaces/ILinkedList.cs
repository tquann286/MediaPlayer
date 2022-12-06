

namespace MediaPlayer.Structures.Interfaces
{
    public interface ILinkedList<T>
    {
        int GetSize();
        T Get(int index);
        T GetFirst();
        T GetLast();

        void Set(int index, T element);
        void SetFirst(T element);
        void SetLast(T element);

        void Add(int index, T element);
        void AddFirst(T element);
        void AddLast(T element);

        void Remove(int index);
        void RemoveFirst();
        void RemoveLast();

        T FindItem(int index);
        int FindIndex(T element);

        void Clear();
    }
}
