namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PriorityQueue<T>
        where T : IComparable<T>
    {
        // Fields
        private const int InitialCapacity = 4;
        private readonly List<T> elements;
        private readonly int orderFactor;

        // Constructors
        public PriorityQueue(string order = "ascending", int capacity = InitialCapacity)
        {
            this.elements = new List<T>(capacity);

            if (order.ToLower() == "ascending")
            {
                this.orderFactor = 1;
            }
            else
            {
                this.orderFactor = -1;
            }
        }

        // Properties
        public int Count
        {
            get { return this.elements.Count; }
        }

        // Methods
        public void Enqueue(T value)
        {
            this.elements.Add(value);
            this.BubbleUp(this.Count - 1);
        }

        public T Dequeue()
        {
            T priorityElementValue = this.elements[0];
            this.elements[0] = this.elements[this.Count - 1];
            this.elements.RemoveAt(this.Count - 1);
            this.TrickleDown(0);
            return priorityElementValue;
        }

        public T Peek()
        {
            T priorityElementValue = this.elements[0];
            return priorityElementValue;
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }

        private void BubbleUp(int currentIndex)
        {
            int parentIndex = (currentIndex - 1) / 2;

            // Do it while the current is greater than the parent (ascending order)
            while (this.Comparer(currentIndex, parentIndex) < 0)
            {
                this.Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = (currentIndex - 1) / 2;
            }
        }

        private void TrickleDown(int currentIndex)
        {
            int leftChildIndex = (currentIndex * 2) + 1;
            int rightChildIndex = leftChildIndex + 1;

            if (leftChildIndex < this.Count)
            {
                int maximalChildIndex = leftChildIndex;

                // If right child exist and it's value is bigger than left child than maximal child is right child
                if (rightChildIndex < this.Count && this.Comparer(leftChildIndex, rightChildIndex) > 0)
                {
                    maximalChildIndex = rightChildIndex;
                }

                // If maximal child is smaller than parent child then no need to make swapping
                if (this.Comparer(currentIndex, maximalChildIndex) <= 0)
                {
                    return;
                }

                this.Swap(currentIndex, maximalChildIndex);
                this.TrickleDown(maximalChildIndex);
            }
        }

        private int Comparer(int firstElementIndex, int secondElementIndex)
        {
            int result = this.elements[firstElementIndex].CompareTo(this.elements[secondElementIndex]);
            return result * this.orderFactor;
        }

        private void Swap(int firstElementIndex, int secondElementIndex)
        {
            T oldElement = this.elements[firstElementIndex];
            this.elements[firstElementIndex] = this.elements[secondElementIndex];
            this.elements[secondElementIndex] = oldElement;
        }
    }
}
