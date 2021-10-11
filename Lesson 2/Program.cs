using System;

namespace Algorithms
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            NodeList n = new(2);            

            n.AddNode(12);
            n.AddNode(13);
            n.AddNode(14);
            n.AddNode(15);
            n.AddNode(16);
            n.AddNode(17);
            
            Node newNode = new(66);
            n.AddNode(newNode.Value);
                        

           n.RemoveNode(2);
           n.RemoveNode(newNode);

            Vision v = new Vision(n);
            v.PrintList();
         


        }
    }
}
