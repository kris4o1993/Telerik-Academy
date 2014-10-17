namespace CableTV
{
    using System;

    public class Node : IComparable<Node>
    {
        public Node(string name)
        {
            this.Name = name;
            this.Distance = int.MaxValue;
        }

        public string Name { get; set; }

        public int Distance { get; set; }

        public int CompareTo(Node other)
        {
            return this.Distance.CompareTo(other.Distance);
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return EqualNodes(this, (Node)obj);
        }

        private static bool EqualNodes(Node first, Node second)
        {
            return first.Name.Equals(second.Name);
        }
    }
}