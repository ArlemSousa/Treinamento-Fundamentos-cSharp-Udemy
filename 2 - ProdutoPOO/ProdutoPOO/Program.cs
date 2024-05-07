using System.Globalization;

namespace ProdutoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();



            Console.WriteLine("Entre com os dados do primeiro produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.Write("Descrição: ");
            p.Descricao = Console.ReadLine();

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite a quantidade de produtos que deseja adicionar: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarQtdEstoque(qte);

            //Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite a quantidade de produtos que deseja adicionar: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverQtdEstoque(qte);

            Console.WriteLine("Dados do produto: " + p);


        }
    }
}