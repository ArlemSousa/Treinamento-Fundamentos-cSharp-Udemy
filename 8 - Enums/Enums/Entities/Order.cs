using Enums.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        //comando com mensagem de retorno para ser exibida quando imprimir a classe
        public override string ToString()
        {
            return Id +
                ", " +
                Moment +
                ", " +
                Status;
                }

    }
}
