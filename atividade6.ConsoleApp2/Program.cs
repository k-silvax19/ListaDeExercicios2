namespace atividade6.ConsoleApp2;

class Converter
{
    public decimal C;

    public decimal F;

    public void GrausC()
    {
        Console.Write("Digite o grau em celsius (°C): ");
        C = Convert.ToDecimal(Console.ReadLine());
    }

    public void Calculo()
    {
        F = (9m / 5m) * C + 32;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter conversor = new Converter();

        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Conversor De Celsius para Fahrenheit");
        Console.WriteLine("================================");

        Console.WriteLine(" ");

        conversor.GrausC();
        conversor.Calculo();

        Console.WriteLine(" ");

        Console.WriteLine($"{conversor.F:F2}°F");
    }
}
