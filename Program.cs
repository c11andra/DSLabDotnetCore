using System;

namespace DSLabDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGraphDemo();
        }

        private static void RunGraphDemo()
        {
            var g = new AdjacencyMatrixGraph(4, true);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(2, 3);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"indegree of {i} is {g.GetInDegree(i)}");
            }

            g.Display();
        }
    }
}
