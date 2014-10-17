namespace FriendsOfPesho
{
    using System;

    public class Node : IComparable<Node>
    {
        public Node(int index)
        {
            this.Index = index;
        }

        public int Index { get; set; }

        public int DijkstraDistance { get; set; }

        public int CompareTo(Node other)
        {
            return this.DijkstraDistance.CompareTo(other.DijkstraDistance);
        }

        public override string ToString()
        {
            return this.Index.ToString();
        }

        public override int GetHashCode()
        {
            return this.Index.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return EqualNodes(this, (Node)obj);
        }

        private static bool EqualNodes(Node first, Node second)
        {
            return first.Index.Equals(second.Index);
        }
    }
}
