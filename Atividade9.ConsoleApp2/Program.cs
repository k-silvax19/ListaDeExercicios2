using System;
class MediaPonderada
{
    public decimal nota1;

    public decimal nota2;

    decimal nota3;

    public decimal peso1;

    public decimal peso2;

    public decimal peso3;

    public decimal mediaPonderada;

    public void Notas()
    {
        Console.Write("Digite a nota 1: ");
        nota1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
        nota2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a nota 3: ");
        nota3 = Convert.ToDecimal(Console.ReadLine());
    }

    public void Peso()
    {
        Console.Write("Digite o peso da nota 1: ");
        peso1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o peso da nota 2: ");
        peso2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o peso da nota 3: ");
        peso3 = Convert.ToDecimal(Console.ReadLine());
    }

    public void Calculo()
    {
        mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
    }

}
class Program
{
    static void Main(string[] args)
    {
        MediaPonderada mediaP = new MediaPonderada();

        Console.WriteLine("===========================================");
        Console.WriteLine("Calculadora de Nota com media ponderada");
        Console.WriteLine("==========================================");


        Console.WriteLine(" ");

        mediaP.Notas();

        Console.WriteLine(" ");

        mediaP.Peso();

        mediaP.Calculo();

        Console.WriteLine(" ");

        Console.WriteLine($"\nA média ponderada é: {mediaP.mediaPonderada:F2}");
    }
}