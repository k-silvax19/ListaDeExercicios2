using System.Security.Cryptography.X509Certificates;

namespace Atividade10.ConsoleApp2;

class Media
{

    public int QuantidadeDeNotas = 0;
    public decimal mediaHarmonica;
    public decimal notaDigitada;
    public decimal somaInverso;
    public decimal[] notasAlunos;
    public void Notas()
    {
        Console.Write("Quantas notas o aluno tem: ");
        QuantidadeDeNotas = Convert.ToInt32(Console.ReadLine());
        notasAlunos = new decimal[QuantidadeDeNotas];
    }

    public void ContarNotas()
    {
        somaInverso = 0;

        for (int contador = 0; contador < QuantidadeDeNotas; contador++)
        {
            Console.Clear();

            Console.Write($"Digite a nota {contador + 1} do aluno: ");
            notaDigitada = Convert.ToDecimal(Console.ReadLine());

            if (notaDigitada == 0)
            {
                Console.WriteLine("Nota não pode ser 0 na média harmônica!");
                contador--;
                Console.ReadLine();
                continue;
            }
            
            somaInverso += 1 / notaDigitada;
            notasAlunos[contador] = notaDigitada;
        }
    }
    public void CalcularNotas()
    {
        mediaHarmonica = QuantidadeDeNotas / somaInverso;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Media media = new Media();
        media.mediaHarmonica = 0;
        media.notaDigitada = 0;
        media.somaInverso = 0;

        Console.Clear();

        Console.WriteLine("===============================");
        Console.WriteLine("Calculadora de nota media harmonica");
        Console.WriteLine("===============================");

        Console.ReadLine();

        media.Notas();
        media.ContarNotas();
        media.CalcularNotas();

        Console.WriteLine($"A média harmônica é: {media.mediaHarmonica:F2}");

        Console.ReadLine();
    }
}