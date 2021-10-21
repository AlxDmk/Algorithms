using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_6
{
    public class BFSGraph
    {
        List<int>[] Matrix { get; set; }    
        int Nodes { get; set; }
        
        public BFSGraph(int nodes, List<int>[] matrix)
        {
            Nodes = nodes;
            Matrix = matrix;
        }
        public void BFS(int start)
        {
            bool[] visited = new bool[Nodes];


            Queue<int> queue = new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);


            Console.WriteLine($"BFS проход начиная с узла №: {start}");
            while (queue.Count != 0)
            {

                start = queue.Dequeue();
                Console.WriteLine("Узел № " + start);


                foreach (Int32 next in Matrix[start])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }

            }
        }

    }
}
