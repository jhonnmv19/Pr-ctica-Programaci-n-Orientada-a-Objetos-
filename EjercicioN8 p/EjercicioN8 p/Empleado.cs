using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN8_p
{
    public class Empleado : Persona
    {
        public double Salario { get; set; }

        public Empleado(string nombre, string domicilio, double salario)
            : base(nombre, domicilio)
        {
            Salario = salario;
        }
    }

}
