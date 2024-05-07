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
