using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_5
{
    public abstract class Enumerate
    {
        public abstract  IEnumerable<Node> EnumerateTree();

        public void Print()
        {
            EnumerateTree();
            foreach (var n in EnumerateTree())
                Console.Write(n.Data + " ");

        }
    }
}
