using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Comissionado : Empregado
    {
        public double totalVenda { get; set; }
        public double totalComissao { get; set; }

        public override double Vencimento()
        {
            return totalVenda * (totalComissao /100);
        }
    }
}
