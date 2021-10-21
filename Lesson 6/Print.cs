using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_6
{
     public class Print
    {
          int Node { get; set; }
         List<int>[] Matrix { get; set; }      

        
        public Print(int node, List<int>[] matrix)
        {
            Node = node;
            Matrix = matrix;
        }
         public void PrintMatrix()
        {
            for (int i = 0; i < Node; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in Matrix[i])
                {
                    s = s + (k + ",");
                }
                s = s + "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }
    }
}
