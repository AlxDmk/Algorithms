using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Data
    {
        public Guid MyData { get; set; }

        public Data()
        {
            MyData = Guid.NewGuid();
        }
    }
}
