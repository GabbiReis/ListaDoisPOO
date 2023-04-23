using Atividade8;

public class Program
{
    static void Main(string[] args)
    {
        Controle controle = new Controle();

        Funcionario funcionario1 = new Funcionario(1, "João", 5000);
        Dependente dependente1 = new Dependente("Maria", "Filha");
        Dependente dependente2 = new Dependente("Pedro", "Filho");
        funcionario1.AdicionarDependente(dependente1);
        funcionario1.AdicionarDependente(dependente2);
        controle.AdicionarFuncionario(funcionario1);

        Funcionario funcionario2 = new Funcionario(2, "José", 7000);
        Dependente dependente3 = new Dependente("Ana", "Esposa");
        funcionario2.AdicionarDependente(dependente3);
        controle.AdicionarFuncionario(funcionario2);
    }
}