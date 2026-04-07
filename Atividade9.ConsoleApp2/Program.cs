namespace Atividade9.ConsoleApp2;

class Calculadora
{
    public int quantidade;
    public decimal somaInversos;
    public decimal mediaHarmonica;

    public void QuantidadeNotas()
    {
        Console.Write("Quantas notas você quer informar? ");
        quantidade = Convert.ToInt32(Console.ReadLine());
    }
    public void LerNotas()
    {
        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write($"Digite a nota {i}: ");
            decimal nota = Convert.ToDecimal(Console.ReadLine());

            if (nota == 0)
            {
                Console.WriteLine("Nota não pode ser 0 (divisão por zero).");
                i--;
                continue;
            }

            somaInversos += 1 / nota;
        }
    }

    public void CalcMediaHarmonica()
    {
        mediaHarmonica = quantidade / somaInversos;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        calc.somaInversos = 0;

        Console.WriteLine("===========================================");
        Console.WriteLine("Calculadora De Notas com media harmonica");
        Console.WriteLine("===========================================");

        Console.WriteLine(" ");

        calc.QuantidadeNotas();
        calc.LerNotas();
        calc.CalcMediaHarmonica();

        Console.WriteLine($"\nA Nota com média Harmônica: {calc.mediaHarmonica:F2}");
    }
}

