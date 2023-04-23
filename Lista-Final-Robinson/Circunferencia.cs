using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Final_Robinson
{
    public class Circunferencia : Forma
    {

        private double raio;

        public Circunferencia(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }

    
}
