using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        //construtor padrao
        public Department() { }

        //construtor recebendo name
        public Department(string name)
        {
            Name = name;
        }
    }
}
