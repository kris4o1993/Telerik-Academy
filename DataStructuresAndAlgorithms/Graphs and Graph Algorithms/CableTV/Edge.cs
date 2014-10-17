namespace CableTV
{
    using System;

    public class Edge : IComparable<Edge>
    {
        public Edge(Node start, Node end, int distance)
        {
            this.Start = start;
            this.End = end;
            this.Distance = distance;
        }

        public Node Start { get; private set; }

        public Node End { get; private set; }

        public int Distance { get; private set; }

        public int CompareTo(Edge other)
        {
            return this.Distance.CompareTo(other.Distance);
        }

        public override string ToString()
        {
            return this.Start + " <-> " + this.End + " (" + this.Distance + ")";
        }

        public override int GetHashCode()
        {
            return this.Start.GetHashCode() + this.End.GetHashCode() + this.Distance.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.EqualEdges(this, (Edge)obj);
        }

        private bool EqualEdges(Edge first, Edge second)
        {
            return first.Start.Equals(second.End);
        }
    }
}
