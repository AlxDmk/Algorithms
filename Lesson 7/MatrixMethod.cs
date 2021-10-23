using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_7
{
    public class MatrixMethod
    {
        public int M { get; set; } 
        public int N { get; set; }
        public MatrixMethod(int n, int m)

        {
            N = n;
            M = m;
        }

         int CountOfAvailableWays()
        {
            int [,] matrix = new int[N, M]; 

            for (int i = 0; i < N; i++)
            {              
                for (int j = 0; j < M; j++)

                    {        
                    
                    if (i == 0)
                        matrix[i, j] = 1;
                    
                    else if (j == 0)
                       matrix[i, j] = 1; 
                    
                     else
                        matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];                        
                    }          
            }

            return matrix[N-1,M-1];
        }
        public void Print()
        {
            int result = CountOfAvailableWays();
            PrintResult.Print(result, "Метод треугольника Паскаля");

        }
    }
}
