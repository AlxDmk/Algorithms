using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_5
{
    public class StackG:Enumerate
    {
        Node Root;
        public StackG( Node node)
        {
            Root = node;  
        }
       
        override public IEnumerable<Node> EnumerateTree()
        {
            var stack = new Stack<Node>();
            stack.Push(Root);

            while (stack.Count > 0)
            {
                var n = stack.Pop();
                
                yield return n;
                if (n.Right != null) stack.Push(n.Right);
                if (n.Left != null) stack.Push(n.Left);
               
            }
        }        
    }

}