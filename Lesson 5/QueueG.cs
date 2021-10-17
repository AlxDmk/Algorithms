using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_5
{
    public class QueueG: Enumerate
    {
        public Node Tree { get; set; }

        public QueueG(Node tree)
        {
            Tree = tree;
        }

        override public  IEnumerable<Node> EnumerateTree()
        {
            Queue<Node> q = new();
            q.Enqueue(Tree);

            while (q.Count > 0)
            {
                Tree = q.Dequeue();                

                yield return Tree;

                if (Tree.Left != null)
                {
                    q.Enqueue(Tree.Left);
                }
                if (Tree.Right != null)
                {
                    q.Enqueue(Tree.Right);
                }
            }
        }
        
    }
}
