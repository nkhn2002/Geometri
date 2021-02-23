using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Square
    {
        public double A { get; set; }

        public Square(double a)
        {
            this.A = a;
        }
        
        public double CalcPerimeter()
        {
            return 4 * A;
        }

        public double CalcArea()
        {
            return A * A;
        }
    }
}
