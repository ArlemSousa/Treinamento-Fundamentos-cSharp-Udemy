using ExercicioResolvido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    internal class Worker
    {
        public string? Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        //objeto do tipo Departamento
        public Department? Department { get; set; }

        //criar uma lista de contratos
        public List<HourContract>? Contracts { get; set; } = new List<HourContract>();

        //construtor padrao
        public Worker()
        {
        }

        //construtor com argumentos
        public Worker(string? name, WorkerLevel level, double baseSalary, Department? department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;

            //Contracts = new List<HourContract>();
            //lista de contratos nao entra, porque sempre que tem associação para muitos pra muitos, eu não instancio.
            //nao é usual instanciar  uma lista num construtor de objetos, ela vai começar vazia e depois vou populando conforme necessidade/
        }

        //esse metodo recebe um HourContract
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //metodo para remover contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //metodo para calcular ganho
        public double Income(int year, int month)
        {

            //a soma incia´é o salario base do contatado
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                //se o ano e mes do contrato recebido for igual ao item da lista, então o contrato entra na soma
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                    //totalValue() é a operacao que retorna o valor do contrato
                }

            }
            return sum;

        }
    }
}
