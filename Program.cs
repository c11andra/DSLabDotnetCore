using System;

namespace DSLabDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunGraphDemo();
            RunBSTDemo();
        }

        private static void RunBSTDemo()
        {
            var bst = new BST();
            bst.Insert(10);
            bst.Insert(11);
            bst.Insert(1);
            bst.Insert(2);

            if(bst.Find(1))
            {
                Console.WriteLine("Found 1");
            }
            else
            {
                Console.WriteLine("Could not find 1");
            }

            if(bst.Find(100))
            {
                Console.WriteLine("Found 100");
            }
            else
            {
                Console.WriteLine("Could Not find 100");
            }

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
