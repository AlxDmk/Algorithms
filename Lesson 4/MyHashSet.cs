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
        HashSet<int> SHashSet { get; set; }
        

        public MyHashSet(int size)
        {
            Size = size;
            
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Fill()
        {
            

            for (int i = 0; i < Size; i++)
            {
                int item = new Data().GetHashCode();
                SHashSet.Add(item);
            }
        }

        public bool FindItem(int item)
        {
            return SHashSet.Contains(item) ?true : false;
            
        }
    }
}
