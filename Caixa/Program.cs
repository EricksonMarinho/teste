using System;
using System.IO;

namespace Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
           string produto;
           double preco;
           bool forma_de_pagamento;
           double resultado;
           double precofinal;

           Console.WriteLine("Digite o nome do produto:");
           produto = Console.ReadLine();
           
           Console.WriteLine("Digite o preço do produto:");
           preco = double.Parse(Console.ReadLine());
           
           Console.WriteLine("O pagamento será em dinheiro");
           forma_de_pagamento = bool.Parse(Console.ReadLine());

           if (forma_de_pagamento==true){
               resultado = preco * 10/100;
               precofinal = preco-resultado;
           }
           else{
               resultado = preco * 5/100;
               precofinal = preco+resultado;
           }

           StreamWriter arquivo = new StreamWriter("dados.txt");
           arquivo.WriteLine("O produto escolhido foi: "+produto);
           arquivo.WriteLine("O preço a vista do produto é: "+preco);
           arquivo.WriteLine("O valor de desconto ou acréscima é: "+resultado);
           arquivo.WriteLine("O preço final do produto é: "+precofinal);
           arquivo.Close();


           Console.WriteLine("O produto escolhido foi: "+produto);
           Console.WriteLine("O preço a vista do produto é: "+preco);
           Console.WriteLine("O valor de desconto ou acréscima é: "+resultado);
           Console.WriteLine("O preço final do produto é: "+precofinal);
        }
    }
}
