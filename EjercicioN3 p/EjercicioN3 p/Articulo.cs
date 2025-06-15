using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN3_p
{
    class Articulo
    {
        private int clave;
        private string descripcion;
        private double precio;
        private int cantidad;

        // Constructor
        public Articulo()
        {
            clave = 0;
            descripcion = "";
            precio = 0;
            cantidad = 0;
        }

        public Articulo(int c, string d, double p, int ca)
        {
            clave = c;
            descripcion = d;
            precio = p;
            cantidad = ca;
        }

        // Métodos get/set
        public void setClave(int c) { clave = c; }
        public int getClave() { return clave; }

        public void setDescripcion(string d) { descripcion = d; }
        public string getDescripcion() { return descripcion; }

        public void setPrecio(double p) { precio = p; }
        public double getPrecio() { return precio; }

        public void setCantidad(int ca) { cantidad = ca; }
        public int getCantidad() { return cantidad; }

        public double CalcularIVA()
        {
            return precio * 0.13;
        }
    }

}
