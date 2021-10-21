using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_6
{
    public class DFSGraph
    {
        List<int>[] Matrix { get; set; }
        int Nodes { get; set; }
       
        public DFSGraph(int nodes, List<int>[] matrix)
        {
            Nodes = nodes;
            Matrix = matrix;
        }
        public void Dfs(int start)
        {
            bool[] visited = new bool[Nodes];


            Stack<int> stack = new Stack<int>();
            visited[start] = true;
            stack.Push(start);
            Console.WriteLine($"DFS проход начиная с узла №: {start}");

            while (stack.Count != 0)
            {
                start = stack.Pop();
                Console.WriteLine("Узел № " + start);
                foreach (int i in Matrix[start])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
    }
}
