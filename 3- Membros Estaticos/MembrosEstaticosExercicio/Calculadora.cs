using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticosExercicio
{
    public class Calculadora
    {
        public static double Pi = 3.14;

        public static double CalcularCircunferencia(double r)
        {
            return r * Pi * 2.0;
        }
    }
}
