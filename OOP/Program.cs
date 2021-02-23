using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square(123);

            Console.WriteLine($"Omkreds: {sqr.CalcPerimeter()}");
            Console.WriteLine($"Areal: {sqr.CalcArea()}");

            Console.ReadKey();
        }
    }
}
