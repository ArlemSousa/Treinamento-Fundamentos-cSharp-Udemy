using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entities
{
    internal class HourContract
    {
        //criação das proprerties
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //construtor padrao
        public HourContract()
        {
        }

        //contrutor com argumentos
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //metodo calcular valor das horas
        public double totalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
