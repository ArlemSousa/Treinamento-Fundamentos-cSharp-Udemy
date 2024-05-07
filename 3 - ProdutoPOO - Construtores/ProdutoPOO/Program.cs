using System.Globalization;

namespace ProdutoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Entre com os dados do primeiro produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, descricao, quantidade);

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