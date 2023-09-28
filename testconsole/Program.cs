using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            int d = 2 * a - b;

            Console.WriteLine("{0}", a);

            Console.ReadKey();
        }
    }
}
