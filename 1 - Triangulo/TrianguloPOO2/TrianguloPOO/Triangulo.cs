using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace TrianguloPOO
{
    internal class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public double calcularArea()
        {
            double p = (A + B + C) / 2.0 ;
            double raiz = Math.Sqrt(p *  (p- A) * (p- B) * (p- C)) ;
            return raiz;
        }

    }
}
