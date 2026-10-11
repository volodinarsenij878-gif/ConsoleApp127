using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program84
{
    internal class Program
    {
        static void Main()
        {
            bool result = (7 > 2 ? 10 : 20) == 10 && (3 < 1 ? 5 : 15) == 15;
            Console.WriteLine(result); // True
        }
    }
}
