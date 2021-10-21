using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_6
{
    public class Graph
    {
        public int Nodes { get; set; }

        public List<int>[] matrix;

        public Graph(int v)
        {
            Nodes = v;
            matrix = new List<int>[v];

            for (int i = 0; i < v; i++)
            {
                matrix[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            matrix[v].Add(w);
        }
        public void PrintMatrix()
        {
            Print print = new Print(Nodes, matrix);
            print.PrintMatrix();

        }

    }
}
