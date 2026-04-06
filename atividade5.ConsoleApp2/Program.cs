namespace atividade5.ConsoleApp2;

class Calculo
{
    public decimal raio;

    public decimal volume;

    public void Raio()
    {
        Console.Write("Digite o Raio: ");
        raio = Convert.ToDecimal(Console.ReadLine());
    }

    public void CalculoDoVolume()
    {
        volume = (4m / 3m) * (decimal)Math.PI * (decimal)Math.Pow((double)raio, 3);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Calculo cal = new Calculo();

        Console.WriteLine("=============================");
        Console.WriteLine("Calculadora de volume de uma esfera");
        Console.WriteLine("=============================");

        Console.WriteLine(" ");

        cal.Raio();
        cal.CalculoDoVolume();

        Console.WriteLine(" ");

        Console.WriteLine($"O Volume é: {cal.volume:F2}");

    }
}
