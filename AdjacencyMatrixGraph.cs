using System;
using System.Collections.Generic;

namespace DSLabDotNetCore
{
    public class AdjacencyMatrixGraph : Graph
    {
        private int[,] matrix;

        private AdjacencyMatrixGraph()
        {
        }
        public AdjacencyMatrixGraph(int numVerices, bool directed = false) : base(numVerices, directed)
        {
            this.matrix = new int[numVerices,numVerices];
        }

        public override void AddEdge(int v1, int v2, int weight=1)
        {
            if(!IsValidVertex(v1) || !IsValidVertex(v2))
            {
                Console.WriteLine($"One or both of the vertices {v1} & {v2} are not valid");
                return;
            }
            this.matrix[v1,v2] = weight;

            if(this.Directed == false)
            {
                this.matrix[v2,v1] = weight;
            }
        }

        public override int[] GetAdjacentVertices(int v)
        {
            if(!IsValidVertex(v))
            {
                Console.WriteLine("Not a valid vertex");
                return null;
            }
            var adj = new List<int>();
            for (int i = 0; i < this.NumVertices; i++)
            {
                if(this.matrix[v,i] > 0)
                {
                    adj.Add(i);
                }
            }

            return adj.ToArray();
        }

        public override int GetInDegree(int v)
        {
            var inDegree = 0;

            for (int i = 0; i < this.NumVertices; i++)
            {
                if(this.matrix[i,v] > 0)
                {
                    inDegree++;
                }
            }

            return inDegree;
        }

        public override int GetEdgeWeight(int v1, int v2)
        {
            return this.matrix[v1, v2];
        }

        public override void Display()
        {
            for (int i = 0; i < this.NumVertices; i++)
            {
                var adj = this.GetAdjacentVertices(i);
                for (int j = 0; j < adj.Length; j++)
                {
                    Console.WriteLine($"{i} ==> {adj[j]}");
                }
            }
        }
    }
}