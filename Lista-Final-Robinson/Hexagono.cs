using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Final_Robinson
{
    public class Hexagono : Forma
    {
        public double lado;

        public Hexagono (double lado)
        {
            this.lado = lado;
        }
        public override double CalcularArea()
        {
            return 3 * Math.Sqrt(3) * lado * lado / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * lado;
        }
    }
}
