using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN2_p
{
    public class Rectangulo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea()
        {
            return Largo * Ancho;
        }
    }

}
