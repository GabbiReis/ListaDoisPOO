using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    public class Impressora
    {
        private Documento documento;
        public int qtdeCopia;

        public Impressora(Documento doc)
        {
            documento = doc;
            qtdeCopia = 1;
        }

        public void Imprimir()
        {
            for (int i = 0; i < qtdeCopia; i++)
            {
                Console.WriteLine(documento.Texto);
            }
        }
        public void SolicitarTexto()
        {
            Console.WriteLine("========== IMPRESSORA ==========");
            Console.WriteLine("Digite o texto a ser impresso: ");
            documento.Texto = Console.ReadLine();
        }

        public void EnviarImpressao()
        {
            Console.WriteLine("Digite a quantidade de cópias a serem impressas: ");
            qtdeCopia = int.Parse(Console.ReadLine());
            Console.WriteLine("===================================================");
        }
    }
}
