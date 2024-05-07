using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    internal class Produto { 
    
        private string _nome;
        private double _preco;
        private string _descricao;
        private int _quantidade;

        //encapsulamento implicito
        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }


        //encapsulamento de forma manual

        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    _nome = nome;
        //}


        //consutrutor padrao
        public Produto() { }

        //construtor obrigando passagem de parametros
        public Produto(string nome, double preco, string descricao, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _descricao = descricao;
            _quantidade = quantidade;
        }

        //sobrecarga
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }


        public double ValorTotalEmstoque() {

            return _preco * _quantidade;
        }

        public void AdicionarQtdEstoque(int qte)
        {
            _quantidade = _quantidade + qte;
        }

        public void RemoverQtdEstoque(int qte)
        {
            _quantidade -= qte;
        }

        public override string ToString()
        {
            return _nome
                + ", $  "
                + _preco
                + ", "
                + _quantidade
                + " unidades, total: $ "
                + ValorTotalEmstoque();
        }

    }
}
