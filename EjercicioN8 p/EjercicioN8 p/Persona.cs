using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN8_p
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }

        protected Persona(string nombre, string domicilio)
        {
            Nombre = nombre;
            Domicilio = domicilio;
        }
    }

}
