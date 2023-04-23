using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    public class Dependente
    {
        public string Nome { get; set; }
        public string Parentesco { get; set; }

        public Dependente(string nome, string parentesco)
        {
            Nome = nome;
            Parentesco = parentesco;
        }
    }
}
