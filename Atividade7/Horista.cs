using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Horista : Empregado
    {
        public double precoHora { get; set; }
        public double horasTrabalhadas { get; set; }

        public override double Vencimento()
        {
            return precoHora * horasTrabalhadas;
        }
    }
}
