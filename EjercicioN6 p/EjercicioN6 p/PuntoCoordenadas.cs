using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN6_p
{
    public class PuntoCoordenadas
    {
        private double x;
        private double y;

        public PuntoCoordenadas()
        {
            x = 0;
            y = 0;
        }

        public PuntoCoordenadas(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void setX(double valor)
        {
            x = valor;
        }

        public double getX()
        {
            return x;
        }

        public void setY(double valor)
        {
            y = valor;
        }

        public double getY()
        {
            return y;
        }

        public double distancia(PuntoCoordenadas otro)
        {
            return Math.Sqrt(Math.Pow(this.x - otro.x, 2) + Math.Pow(this.y - otro.y, 2));
        }
    }
}
