using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_5
{
    class StackG
    {
        Node Root;
        public StackG( Node node)
        {
            Root = node;  
        }
       
        private IEnumerable<Node> EnumerateTree()
        {
            var stack = new Stack<Node>();
            stack.Push(Root);

            while (stack.Count > 0)
            {
                var n = stack.Pop();
                yield return n;
                if (n.Left != null) stack.Push(n.Left);
                if (n.Right != null) stack.Push(n.Right);
            }
        }

        public void Print()
        {
            EnumerateTree();
            foreach (var n in EnumerateTree())
            Console.Write(n.Data + " ");

        }
    }

}