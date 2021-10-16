using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MyHashSet
    {
        public int Size { get; set; }       
       

        public MyHashSet(int size)
        {
            Size = size;
            
        }
          

        public HashSet<string> Fill()
        {
            HashSet<string> SHashSet = new HashSet<string>();

            for (int i = 0; i < Size; i++)
            {
                string v = new Data().ToString();
                string ie = v;
                SHashSet.Add(ie);
            }
            return SHashSet;
        }

        public bool FindItem(int item)
        {
            var x = Fill();
            return x.Contains(item.ToString());
            
        }
    }
}
