using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Final_Robinson
{
    public class GerarForma
    {
        public static Forma SolicitarForma()
        {
            do
            {
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1 - Gerar formato Circunferência");
                Console.WriteLine("2 - Gerar formato Triângulo");
                Console.WriteLine("3 - Gerar formato Quadrado");
                Console.WriteLine("4 - Gerar formato Hexágono");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Digite o número que corresponde a forma que deseja gerar: ");
                int tipo = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==================== CIRCUNFERÊNCIA ====================");
                        Console.WriteLine("Digite o valor do raio para calcular a circunferência: ");
                        double raio = double.Parse(Console.ReadLine());
                        Circunferencia circunferencia = new Circunferencia(raio);
                        Console.WriteLine($"Area: {circunferencia.CalcularArea()}");
                        Console.WriteLine($"Perimetro: {circunferencia.CalcularPerimetro()}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("========================== TRIÂNGULO ==========================");
                        Console.WriteLine("Digite o valor dos lados para realizar os calculos do triangulo");
                        Console.Write("Lado A: ");
                        double ladoA = double.Parse(Console.ReadLine());
                        Console.Write("Lado B: ");
                        double ladoB = double.Parse(Console.ReadLine());
                        Console.Write("Lado C: ");
                        double ladoC = double.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
                        Console.WriteLine($"Area: {triangulo.CalcularArea()}");
                        Console.WriteLine($"Perimetro: {triangulo.CalcularPerimetro()}");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("========================= QUADRADO ========================");
                        Console.WriteLine("Digite o valor do lado para realizar o calculo do quadrado: ");
                        Console.Write("Lado do Quadrado: ");
                        double ladoQuadrado = double.Parse(Console.ReadLine());
                        Quadrado quadrado = new Quadrado(ladoQuadrado);
                        Console.WriteLine($"Area: {quadrado.CalcularArea()}");
                        Console.WriteLine($"Perimetro: {quadrado.CalcularPerimetro()}");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("================ HEXAGONO ================");
                        Console.WriteLine("Digite o valor do lado para realizar o calculo: ");
                        double lado = double.Parse(Console.ReadLine());
                        Hexagono hexagono = new Hexagono(lado);
                        Console.WriteLine($"Area: {hexagono.CalcularArea()}");
                        Console.WriteLine($"Perimetro: {hexagono.CalcularPerimetro()}");
                        break;
                    case 5:
                        Console.WriteLine("Encerrando...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente Novamente");
                        break;
                }
            } while (true);
        }
    }
}
