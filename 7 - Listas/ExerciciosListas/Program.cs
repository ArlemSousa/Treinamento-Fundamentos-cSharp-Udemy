using System.Collections.Generic;

namespace ExerciciosListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios deseja cadastrar?");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());

            //instanciar empregado
            Empregado empregado = new Empregado();

            //criação das variaveis que serão passadas para a função de cadastar usuario
            int id;
            string? nome;
            double salario;

            //verificar quantos empregados quero cadastar
            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                
                Console.WriteLine("Entre com o id do Funcionario");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Agora entre com o nome do funcionario");
                nome = Console.ReadLine();

                Console.WriteLine("Entre agora com o salario do funcionario");
                salario = double.Parse(Console.ReadLine());

                //adicionar o empregado na lista
                //lista.Add(new Empregado(id, nome, salario));

                //chamar função para gravar os dados
                empregado.AtribuirDados(id, nome, salario);
                //empregado.Mostrar();

                Console.WriteLine(new string('-', 50));
                Console.WriteLine();


            }


            Console.WriteLine("Entre com o id do funcionario que deseja aumentar o salaio");
            int idFuncionario = int.Parse(Console.ReadLine());

            //primeiro verifica se o funcionario existe
            bool encontrou = empregado.PesquisarFuncionario(idFuncionario); 

            if (encontrou == false)
            {
                Console.WriteLine("Funcionario nao encontrado");
            }
            else
            {
                Console.WriteLine("Entre com o percentual que deseja aumentar o salario");
                double percentualAumento = double.Parse(Console.ReadLine());
                empregado.IncrementarSalario(percentualAumento, idFuncionario);
            }

            empregado.Mostrar();

        }
    }
}
