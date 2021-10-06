using System;
using static System.Console;

namespace Algorithms
{
    class Lesson1
    {
        
        ///*Первая часть задания*/
        public class Lesson1_1
        {
            public void CheckNumber()
            {
                WriteLine("Введите число");

                int n = int.Parse(ReadLine());
                int d = 0;
                int i = 2;

                while (i < n)
                {
                    if (n % i == 0)
                    {
                        d++;
                    }

                    i++;
                }

                if (d == 0)
                {
                    WriteLine("Простое");
                }
                else { 
                    WriteLine("Не просто"); 
                }
                WriteLine();
            }
        }
        

        /*Фибоначчи*/

        public class Pisano   
        {
            public void Fibo1(int q)
            {
                WriteLine("Фибоначчи через рекурсию");
                for (int i = 0; i < q; i++)
                {
                     Write(FibbonateThis(i)+" ");
                }
            }

            int FibbonateThis(int data)
            {
                return (data == 1 || data == 0) ? 1 : FibbonateThis(data - 1) + FibbonateThis(data - 2);
            }

            public void Fibo2(int q)
            {
                WriteLine();
                WriteLine("Фибоначчи через цикл");
                int a = 1, b = 1, c, temp;
                Write(a + " "+ b+" ");
                for (int i = 3; i <= q; i++)
                {
                    c = a + b;
                    temp = b;
                    b = c;
                    a = temp;
                    Write(b+" ");
                }
            }
        }
        

        static void Main(string[] args)
        {

            Lesson1_1 a = new();
            a.CheckNumber();

            Pisano p = new ();
            p.Fibo1(10);           
            p.Fibo2(10);
            ReadKey();            

        }
    }
}
