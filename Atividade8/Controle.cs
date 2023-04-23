using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    public class Controle
    {
        public List<Funcionario> Funcionarios { get; set; }

        public Controle()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void ExibirDependentesFuncionario(int idFuncionario)
        {
            var funcionario = Funcionarios.Find(f => f.ID == idFuncionario);

            if (funcionario == null)
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            else
            {
                funcionario.ExibirDependentes();
            }
        }
    }
}
