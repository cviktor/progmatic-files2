using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Test : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("meghívódott a dispose");
        }
    }
}
