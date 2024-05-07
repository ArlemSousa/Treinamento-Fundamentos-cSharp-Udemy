using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExerciciosListas
{
    internal class Empregado
    {
        //crioacao das props
        private int _id;
        private string? _nome;
        private double _salario;

        //;construtor
        public Empregado(int id, string? nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Empregado()
        {
        }

        //encapusulamento explicito
        public int Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public double Salario { get => _salario; set => _salario = value; }


        public List<Empregado> lista = new List<Empregado>();


        //definir um metodo para atribuir os valores das props
        public void AtribuirDados(int id, string? nome, double salario)
        {

            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;

            lista.Add(new Empregado(this.Id, this.Nome, this.Salario));
        }

        public void Mostrar()
        {
            foreach (Empregado empregado in lista )
            {
                Console.WriteLine("Nome do empregado " + empregado.Nome + " id: " + empregado.Id + "salario: " + empregado.Salario);
            }
        }

        public void IncrementarSalario(double percent, int idFuncionario)
        {
            Empregado emp = lista.Find(x => x.Id == idFuncionario);

            emp.Salario = emp.Salario+= emp.Salario * percent / 100.0; 
        }

        public bool PesquisarFuncionario(int idFuncionario)
        {
            //buscar o id do funcionario na lista de empregados
            Empregado emp = lista.Find(x => x.Id == idFuncionario);

            if (emp != null)
            {
               
                return true;
            }
            else
            {
                return false;
                
            }

           
                
        }


    }
}
