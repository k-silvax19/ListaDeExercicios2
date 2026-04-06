
using System.Reflection.Metadata.Ecma335;

class Caixa
{
    public decimal comprimento;

    public decimal largura;

    public decimal altura;

    public decimal resultado;

    public void ComprimetoDaCaixa()
    {
        Console.Write("Digite o comprimento da caixa: ");
        comprimento = Convert.ToDecimal(Console.ReadLine());
    }

    public void LarguraDaCaixa()
    {
        Console.Write("Digite a largura da caixa: ");
        largura = Convert.ToDecimal(Console.ReadLine());
    }

    public void Altura()
    {
        Console.Write("Digite a altura da caixa: ");
        altura = Convert.ToDecimal(Console.ReadLine());

    }

    public void Resultado()
    {
        resultado = comprimento * largura * altura;
    }
}

class Program
{
    static void Main()
    {
        Caixa caixa = new Caixa();

        Console.Clear();

        Console.WriteLine("==============================");
        Console.WriteLine("Calculadora de Volume de Caixa Retangular");
        Console.WriteLine("==============================");

        Console.WriteLine(" ");

        caixa.ComprimetoDaCaixa();

        Console.WriteLine(" ");

        caixa.LarguraDaCaixa();

        Console.WriteLine(" ");

        caixa.Altura();

        Console.WriteLine(" ");

        caixa.Resultado();

        Console.WriteLine($"O resultado e: {caixa.resultado}");
    }
}