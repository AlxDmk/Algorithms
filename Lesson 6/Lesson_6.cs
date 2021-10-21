using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_6
{
    class Lesson_6
    {
        public static void Main( string [] args)
        {
            Graph graph = new Graph(6);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 0);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 1);
            graph.AddEdge(3, 2);
            graph.AddEdge(3, 5);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 2);
            graph.AddEdge(4, 3);
            graph.AddEdge(4, 5);
            graph.AddEdge(5, 3);
            graph.AddEdge(5, 4);
                                   
            graph.PrintMatrix();
            Console.WriteLine();
           
            BFSGraph bfs = new BFSGraph(graph.Nodes, graph.matrix);
            bfs.BFS(1);
            Console.WriteLine();
            DFSGraph dfs = new DFSGraph(graph.Nodes, graph.matrix);
            dfs.Dfs(0);


            

        }


    }

    
}