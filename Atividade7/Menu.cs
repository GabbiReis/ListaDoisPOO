using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    public class Menu
    {
        public static void Main()
        {
            Console.Write("Digite o nome do empregado: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome do empregado: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite o CPF do empregado(somente números): ");
            string cpf = Console.ReadLine();

            Console.WriteLine("============ MENU ============");
            Console.WriteLine("1 - ASSALARIADO");
            Console.WriteLine("2 - COMISSIONADO");
            Console.WriteLine("3 - HORISTA");
            Console.Write("Digite uma opção de acordo com o cargo o empregado: ");
            int opcao = int.Parse(Console.ReadLine());

            Empregado empregado;

            switch (opcao)
            {
                case 1:
                    empregado = new Assalariado();

                    Console.Write("Digite o salário do empregado: R$ ");
                    double salario = double.Parse(Console.ReadLine());

                    ((Assalariado)empregado).Salario = salario;
                    break;
                case 2:
                    empregado = new Comissionado();

                    Console.Write("Digite o total de vendas do empregado em questão: ");
                    double totalVenda = double.Parse(Console.ReadLine());

                    Console.Write("Digite a porcentagem de comissão do empregado em questão: ");
                    double totalComissao = double.Parse(Console.ReadLine());

                    ((Comissionado)empregado).totalVenda = totalVenda;
                    ((Comissionado)(empregado)).totalComissao = totalComissao;
                    break;
                case 3:
                    empregado = new Horista();

                    Console.Write("Digite o preço por hora do empregado em questão: R$ ");
                    double precoHora = double.Parse(Console.ReadLine());

                    Console.Write("Digite o total de horas trabalhadas do empregado em questão: ");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());

                    ((Horista)empregado).precoHora = precoHora;
                    ((Horista)empregado).horasTrabalhadas = horasTrabalhadas;
                    break;

                default:
                    Console.WriteLine("Opção inválida!! Tente novamente");
                    return;

            }

            Console.Clear();
            empregado.Nome = nome;
            empregado.Sobrenome = sobrenome;
            empregado.CPF = cpf;

            empregado.Vencimento();
            Console.WriteLine("***** DADOS DO EMPREGADO *****");
            Console.WriteLine($"Nome: {nome} {sobrenome}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine("***** VENCIMENTO *****");
            Console.Write($"O vencimento do empregado em questão é: {empregado.Vencimento()}");
            


        }
    }
}
