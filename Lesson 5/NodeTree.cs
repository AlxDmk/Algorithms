using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_5
{
    public class NodeTree
    {
        public Node Root { get; set; }

        public void Add( int data)
        {                       
            if (Root == null)
            {
                Root = new(data);
                return ;
            }

            Root.Add(data);

            

        }        
        
    }
}
