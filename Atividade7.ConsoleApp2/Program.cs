using System.Net.NetworkInformation;

namespace Atividade7.ConsoleApp2;

class calcSalario
{
    public decimal salario;

    public decimal vendas;

    public decimal comissao;

    public void Salario()
    {
        Console.Write("Salario Base: ");
        salario = Convert.ToDecimal(Console.ReadLine());
    }

    public void Vendas()
    {
        Console.Write("Total De Vendas: ");
        vendas = Convert.ToDecimal(Console.ReadLine());
    }

    public void Comissao()
    {
        Console.Write("Digite o valor da comissão (%): ");
        comissao = Convert.ToDecimal(Console.ReadLine());
    }

    public decimal CalcularSalarioTotal()
    {
        return salario + (vendas * (comissao / 100));
    }

}
class Program
{
    static void Main(string[] args)
    {
        calcSalario calc = new calcSalario();


        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("Calculadora de Salario");
        Console.WriteLine("========================================");

        Console.WriteLine(" ");

        calc.Salario();
        calc.Vendas();
        calc.Comissao();

        decimal total = calc.CalcularSalarioTotal();

        Console.WriteLine(" ");

        Console.WriteLine($"o salario total e: {total:F2}");

        Console.ReadLine();
    }
}
