namespace DSLabDotNetCore
{
    public abstract class Graph
    {
        public int NumVertices { get; private set; }
        public bool Directed { get; private set; }

        protected Graph()
        {
        }

        protected Graph(int numVerices, bool directed = false)
        {
            this.NumVertices = numVerices;
            this.Directed = directed;
        }

        protected bool IsValidVertex(int v)
        {
            return v >= 0 && v < this.NumVertices;
        }

        public virtual void AddEdge(int v1, int v2, int weight)
        {
        }

        public virtual int[] GetAdjacentVertices(int v)
        {
            return null;
        }

        public virtual int GetInDegree(int v)
        {
            return 0;
        }

        public virtual int GetEdgeWeight(int v1, int v2)
        {
            return 1;
        }
        public virtual void Display()
        {
        }

    }
}