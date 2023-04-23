using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    public class Funcionario
    {

        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public List<Dependente> Dependentes { get; set; }

        public Funcionario(int iD, string nome, decimal salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;

            Dependentes = new List<Dependente>();
        }
        public void AdicionarDependente(Dependente dependente)
        {
            Dependentes.Add(dependente);
        }

        public void ExibirDependentes()
        {
            Console.WriteLine("Dependentes:");
            foreach (var dependente in Dependentes)
            {
                Console.WriteLine(dependente.Nome);
            }
        }
    }
}
