using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double n1;
            double n2;
            double soma, subtrair, multiplicar, dividir, resto;

            n1=50;
            n2=20;

            soma = n1+n2;
            subtrair = n1-n2;
            multiplicar = n1*n2;
            dividir = n1/n2;
            resto = n1%n2;
            Console.WriteLine(soma);
            Console.WriteLine(subtrair);
            Console.WriteLine(multiplicar);
            Console.WriteLine(dividir);
            Console.WriteLine(resto);
        }
    }
}
