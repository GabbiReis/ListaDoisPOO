using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    public class Livro
    {
        public string ISBN { get; set; }
        public string NomeLivro { get; set; }
        public Autor AutorLivro { get; set; }
        public string Idioma { get; set; }
        public int Edicao { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
