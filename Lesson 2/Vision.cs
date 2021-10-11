using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Vision
    {
        NodeList MyList { get;}

   
        public Vision(NodeList l)
        {
            MyList = l;
        }
                   
        public void PrintList()            
        
        {
            Console.WriteLine(MyList.GetCount());
            Console.WriteLine("-------------------");

            var currentItem = MyList.Head;
            while(currentItem != null)
            {
                Console.WriteLine(currentItem.Value);
                currentItem = currentItem.NextNode;
            }
        }
    }
}
