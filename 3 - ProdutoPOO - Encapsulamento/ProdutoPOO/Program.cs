using System.Globalization;

namespace ProdutoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 10.00, "televisao de 40 polegada", 5);

            //usado se as propriedades tivessem sido encapsuladas de forma manual
            //p.SetNome("TV zona");

            //Console.WriteLine(p.GetNome());


            //metodo usado dessa forma porque encapsulei as props de forma implicita
            p.Nome = "TV zika";
            Console.WriteLine(p.Nome);


        }
    }
}