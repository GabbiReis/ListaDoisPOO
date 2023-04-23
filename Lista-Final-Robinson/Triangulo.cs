using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Final_Robinson
{
    public class Triangulo : Forma
    {
        private double LadoA, LadoB, LadoC;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        public override double CalcularArea()
        {
            double p = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt (p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
