using System;

namespace Algorithms. Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {           
            NodeTree t = new();
            t.Add(8);
            t.Add(5);
            t.Add(10);
            t.Add(3);
            t.Add(6);
            t.Add(9);
            t.Add(11);

            QueueG bfs = new(t.Root);
            bfs.Print();
            Console.WriteLine();

            StackG dfs = new(t.Root);
            dfs.Print();
        }
    }
}
