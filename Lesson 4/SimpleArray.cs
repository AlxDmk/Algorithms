using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SimpleArray
    {
        

        int Size { get; set; }
        string[] MyArray = new string [0];

        public SimpleArray(int count)
        {
            Size = count;
            Array.Resize(ref MyArray, MyArray.Length + Size);
        }


         public void Filling ()
        {  
           for (int i = 0; i < Size; i++)
            {
                MyArray[i] = new Data().ToString();

            }          
        } 

        public bool FindItem (string item)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i]== item)
                {
                    return true;                    
                }                
            }
            return false;
        }

    }
}
