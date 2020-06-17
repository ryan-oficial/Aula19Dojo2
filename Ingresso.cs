using System;

namespace Aula19Ingresso
{
    public class Ingresso
    {
        public float Valor{ get; set; }

        public void ImprimirValor(){
            System.Console.WriteLine($"O valor do ingresso comun é {Valor}.");
        }
    }
}