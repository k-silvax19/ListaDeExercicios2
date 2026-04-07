using System.Runtime.CompilerServices;

namespace Atividade8.ConsoleApp2;

class LataDeOléo
{
    public decimal diametro;

    public decimal altura;

    public decimal raio;

    public decimal pi;

    public decimal volume;

    public decimal litros;

    public void Diametro()
    {
        Console.Write("Digite o diâmetro (cm): ");
        diametro = Convert.ToDecimal(Console.ReadLine());
    }

    public void Altura()
    {
        Console.Write("Digite a altura (cm): ");
        altura = Convert.ToDecimal(Console.ReadLine());
    }
    public void Raio()
    {
        raio = diametro / 2;
    }
    public void PI()
    {
        pi = 3.14159265358979323846m;
    }

    public void Volume()
    {
        volume = pi * raio * raio * altura;
    }

    public void Litros()
    {
        litros = volume / 1000;
    }
}
class Program
{
    static void Main(string[] args)
    {
        LataDeOléo oleo = new LataDeOléo();

        Console.Clear();
        Console.WriteLine("============================");
        Console.WriteLine("Calcular o volume de uma lata de óleo");
        Console.WriteLine("============================");

        Console.WriteLine(" ");

        oleo.Diametro();
        oleo.Altura();

        oleo.Raio();
        oleo.PI();
        oleo.Volume();
        oleo.Litros();

        Console.WriteLine(" ");

        Console.WriteLine($"Volume: {oleo.volume:F2} cm³");
        Console.WriteLine(" ");
        Console.WriteLine($"Volume em litros: {oleo.litros:F2} L");
    }
}