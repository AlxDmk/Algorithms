using System;

namespace Algorithms.Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixMethod king = new MatrixMethod(8,8); 
            king.Print();

            LineMethod line = new LineMethod(8,8);
            line.Print();
            

        }
    }
}
