using System;

namespace ProgramaComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorMeta, perComissao, valorVenda, valorComissao;

            Console.Clear();
            Console.WriteLine("Digite o valor da meta");
            valorMeta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de comissão");
            perComissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da venda");
            valorVenda= double.Parse(Console.ReadLine());

            if(valorVenda>=valorMeta)
                valorComissao = valorVenda*(perComissao/100);
            else
                valorComissao = 0;
            Console.WriteLine("O valor da comissão é:" + valorComissao);    
        }
    }
}
