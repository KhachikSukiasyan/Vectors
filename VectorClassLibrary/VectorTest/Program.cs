using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorClassLibrary;

namespace VectorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2);
            Vector b = new Vector(2, 1);

            Vector c = a + b;
            c.print();

            Vector d = c - 7 * a;
            d.print();

            Console.WriteLine(a * c);
            Console.ReadKey();
        }
    }
}
