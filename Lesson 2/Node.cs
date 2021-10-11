using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{ 
    public class Node 
    {
      
        public int Value { get; set; }
        public Node  NextNode { get; set; }
        public Node PrevNode { get; set; }

       
        public Node(int data)
        {
            Value = data;
        }
    }

}

