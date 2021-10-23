using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lesson_7
{
    public class PrintResult
    {
        

        public static void Print(int result, string method)
        {
            Console.WriteLine("Результат числа комбинаций через {1} : {0}", result, method);
            Console.WriteLine();
        }        

    }
}
