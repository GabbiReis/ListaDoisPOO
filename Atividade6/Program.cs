using Atividade6;

public class Program
{
    static void Main(string[] args)
    {
        Documento documento = new Documento("");
        Impressora impressora = new Impressora(documento);

        impressora.SolicitarTexto();
        impressora.EnviarImpressao();
        impressora.Imprimir();

        Console.Read();
    }
}