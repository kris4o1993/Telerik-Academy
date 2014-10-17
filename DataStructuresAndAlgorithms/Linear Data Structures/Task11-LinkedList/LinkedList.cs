namespace Task11_LinkedList
{
    using System;
    using System.Collections.Generic;

    public class LinkedListCustom<T> : IEnumerable<T>
    {
        public LinkedListNode<T> Head;

        private LinkedListNode<T> Tail;

        public void Add(T value)
        {
            var newNode = new LinkedListNode<T>
            {
                Value = value
            };

            if (this.Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else 
            {
                this.Tail.Next = newNode;
                newNode.Previous = this.Tail;
                this.Tail = newNode;
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var node = this.Head;

            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
}
