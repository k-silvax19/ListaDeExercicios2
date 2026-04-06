using System.Security.Cryptography.X509Certificates;

namespace Atividade3.ConsoleApp2;

class Consumo
{
    public decimal kmInicial;

    public decimal kmfinal;

    public decimal ltViagem;

    public decimal distancia;

    public decimal percurso;

    public void KmInicial()
    {
        Console.Write("Quilometragem Inicial: ");
        kmInicial = Convert.ToDecimal(Console.ReadLine());
    }

    public void KmFinal()
    {
        Console.Write("Quilometragem Final: ");
        kmfinal = Convert.ToDecimal(Console.ReadLine());
    }

    public void LtViagem()
    {
        Console.Write("quantidade de combustível consumida durante a viagem (em litros): ");
        ltViagem = Convert.ToDecimal(Console.ReadLine());
    }

    public void Distancia()
    {
        distancia = kmfinal - kmInicial;
    }

    public void Percurso()
    {
        percurso = distancia / ltViagem;
    }

}
class Program
{
    static void Main(string[] args)
    {
        {
            Consumo consumo = new Consumo();

            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("Calculadora De Consumo De Combustivel");
            Console.WriteLine("========================================");

            Console.WriteLine(" ");

            consumo.KmInicial();
            consumo.KmFinal();
            consumo.LtViagem();
            consumo.Distancia();
            consumo.Percurso();

            Console.WriteLine(" ");

            Console.WriteLine($"A distancia percorrida e: {consumo.distancia} km");

            Console.WriteLine($"o consumo e: {consumo.percurso:F2} km/L");

            Console.ReadLine();
        }
    }
}