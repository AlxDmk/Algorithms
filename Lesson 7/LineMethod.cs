using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_7
{
    public class LineMethod
    {
        private int M { get; set; }
        private int N { get; set; }

        public LineMethod(int m, int n)
        {
            M = m;
            N = n;
        }
        int GetCountOfAvailableWays()
        {
            int count = 0;
            int[] w = new int[M];
            for (int j = 0; j < M; j++)
            {
                w[j] = 1;
            }

            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < M; j++)
                {
                    w[j] = w[j - 1] + w[j];
                }
            }
            count = w[M-1];
            return count;
        }
        public void Print()
        {
            int result = GetCountOfAvailableWays();
            PrintResult.Print(result, "Одномерный массив");

        }


    }
}
