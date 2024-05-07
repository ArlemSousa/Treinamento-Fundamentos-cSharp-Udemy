using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public string Descricao;
        public int Quantidade;


        //consutrutor padrao
        public Produto() { }

        //construtor obrigando passagem de parametros
        public Produto(string nome, double preco, string descricao, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
        }

        public double ValorTotalEmstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarQtdEstoque(int qte)
        {
            Quantidade = Quantidade + qte;
        }

        public void RemoverQtdEstoque(int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return Nome
                + ", $  "
                + Preco
                + ", "
                + Quantidade
                + " unidades, total: $ "
                + ValorTotalEmstoque();
        }

    }
}
