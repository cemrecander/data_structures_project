using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapilari_son_hali
{
    public class Record<T>
    {
        internal Node First = null;
        internal Node Last = null;
        private int size = 0;
        public int Count => size;
        public Record() { }
        public Record(T item) => Add(item);
        public T this[int index]
        {
            get => GetNode(index).Data;
            set => GetNode(index).Data = value;
        }
        public void Add(T item)
        {
            Node node = new Node(item);

            if (First != null)
            {
                Last.Next = node;
                Last = node;
            }
            else
                First = Last = node;
            ++size;
        }
        public bool Remove(T item)
        {
            if (First == null)
                throw new ArgumentOutOfRangeException("Remove");
            bool isFind = false;
            Node traveler = First;
            Node previousNode = null;
            for (; traveler != null; traveler = traveler.Next)
            {
                if (traveler.Data.Equals(item))
                {
                    isFind = true;
                    break;
                }
                previousNode = traveler;
            }
            if (!isFind)
                return false;
            if (First != traveler)
                previousNode.Next = traveler.Next;
            else
                First = First.Next;
            traveler.Next = null;
            --size;
            return true;
        }
        public int Find(T item)
        {
            int position = -1;
            bool isOK = false;
            for (Node traveler = First; traveler != null; traveler = traveler.Next)
            {
                ++position;
                if (traveler.Data.Equals(item))
                {
                    isOK = true;
                    break;
                }
            }
            return (isOK) ? position : -1;
        }
        public void Clear()
        {
            First = Last = null;
            size = 0;
        }
        public IEnumerable<T> GetEnumerator()
        {
            for (Node traveler = First; traveler != null; traveler = traveler.Next)
                yield return traveler.Data;
        }
        private Node GetNode(int index)
        {
            if (Count == 0 || Count <= index)
                throw new IndexOutOfRangeException("");
            int i = 0;
            Node traveler = First;
            while (i++ < index) traveler = traveler.Next;
            return traveler;
        }
        internal class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; } = null;
            public Node(T data) => Data = data;
        }
    }
}
