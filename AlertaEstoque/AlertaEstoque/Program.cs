using System;

namespace AlertaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtdMaxima, qtdAtual, resultado;
            string nomeProduto;
            Console.Clear();

            Console.WriteLine("Digite o nome do produto");
            nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade atual do produto");
            qtdAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade máxima do produto");
            qtdMaxima = double.Parse(Console.ReadLine());

            resultado = (qtdAtual / qtdMaxima)*100;

            Console.WriteLine(resultado.ToString("n2")+"%");

            if(resultado <= 12)
                Console.WriteLine("Comprar com Urgência");
            else if(resultado<=20)
                Console.WriteLine("Realizar Compra");
            else
                Console.WriteLine("Ponto de Utilização");
        }
    }
}
