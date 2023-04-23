using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Final_Robinson
{
    public class Quadrado : Forma
    {
        private double ladoQuadrado;

        public Quadrado(double ladoQuadrado)
        {
            this.ladoQuadrado = ladoQuadrado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(ladoQuadrado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * ladoQuadrado;
        }
    }
}
