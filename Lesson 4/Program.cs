using System;
using System.Diagnostics;
using System.Threading;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArray mat = new (1000000);
            mat.Filling();

            Stopwatch sw = new Stopwatch();
            sw.Start();            
             mat.FindItem(Guid.NewGuid().ToString());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadKey();

            MyHashSet set = new (1000000);
            set.Fill();

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            set.FindItem(new Data().GetHashCode());
            sw1.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds);

        }
    }
}
