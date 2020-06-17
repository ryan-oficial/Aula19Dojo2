using System;

namespace Aula19Ingresso
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.Valor = 20f;
            bilhete.ValorAdicional = 15.50f;


            bilhete.ImprimirValor();
            bilhete.MostrarValorVIP();

            System.Console.WriteLine($"A diferença entre os valores é de R$ {bilhete.ValorAdicional}");

            

            
        }
    }
}
