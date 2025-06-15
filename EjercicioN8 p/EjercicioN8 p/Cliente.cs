using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN8_p
{
    public class Cliente : Persona
    {
        public double Credito { get; set; }

        public Cliente(string nombre, string domicilio, double credito)
            : base(nombre, domicilio)
        {
            Credito = credito;
        }
    }

}
