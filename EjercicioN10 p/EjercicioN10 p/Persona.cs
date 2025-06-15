using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN10_p
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }

        public virtual string MostrarDatos()
        {
            return $"Nombre: {Nombre}\nDomicilio: {Domicilio}\nTeléfono: {Telefono}";
        }
    }
}
