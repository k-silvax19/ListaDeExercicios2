
using System.Runtime.InteropServices;

class Conversor
{
    public decimal F;

    public decimal resultado;

    public void Fahrenheit()
    {
        Console.Write("Digite o Fahrenheit (F): ");
        F = Convert.ToDecimal(Console.ReadLine());
    }

    public void Calculo()
    {
        resultado = (5m / 9m) * (F - 32);
    }

}

class Program
{
    static void Main()
    {
        Conversor converter = new Conversor();

        Console.Clear();
        Console.WriteLine("================================================");
        Console.WriteLine("Conversor de Fahrenheit (F) para Celsius (C)");
        Console.WriteLine("================================================");

        Console.WriteLine(" ");

        converter.Fahrenheit();

        converter.Calculo();

        Console.WriteLine($"{converter.resultado:F2} Graus Celsius");
    }
}


