using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd=0;
             for(int i=1910; i <=2018; i++){
                 if(i%4==0){
                     Console.WriteLine(i + " -Este ano é Bissexto");
                     qtd++;
                    
                 }
             }
             Console.WriteLine(qtd);
        }
    }
}
