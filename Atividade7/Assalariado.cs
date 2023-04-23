using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Assalariado : Empregado
    {
        public double Salario { get; set; }

        public override double Vencimento()
        {
            return Salario;
        }
    }
}
