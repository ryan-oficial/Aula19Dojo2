namespace Aula19Ingresso
{
    public class IngressoVIP : Ingresso
    {
        public float ValorAdicional { get; set; }
        public void MostrarValorVIP(){
            float resultado = Valor + ValorAdicional;
            System.Console.WriteLine($"Valor do ingresso adicional é R$ {resultado}");
        }

    }
}