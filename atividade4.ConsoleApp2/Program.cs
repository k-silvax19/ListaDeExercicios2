using System.Net.Http.Headers;

namespace atividade4.ConsoleApp2;

class Calculadora
{
    public decimal raio;

    public decimal altura;

    public decimal pi;

    public decimal baseDoCilindro;

    public decimal resultado;

    public void Raio()
    {
        Console.Write("Digite o Raio: ");
        raio = Convert.ToDecimal(Console.ReadLine());

    }

    public void Altura()
    {
        Console.Write("Digite a Altura: ");
        altura = Convert.ToDecimal(Console.ReadLine());
    }

    public void Pi()
    {
        pi = (decimal)Math.PI;
    }

    public decimal CalcularBase()
    {
        return (decimal)Math.PI * (decimal)Math.Pow((double)raio, 2);
    }

    public decimal CalcularVolume()
    {
        return CalcularBase() * altura;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.Clear();

        Console.WriteLine("----------------------");
        Console.WriteLine("Calculadora de Volume Do Cilindro");
        Console.WriteLine("----------------------");

        Console.WriteLine(" ");

        calc.Raio();
        calc.Altura();

        decimal resultado = calc.CalcularVolume();

        Console.WriteLine(" ");

        Console.WriteLine($"O resultado do volume e: {resultado:F2}");

    }
}
