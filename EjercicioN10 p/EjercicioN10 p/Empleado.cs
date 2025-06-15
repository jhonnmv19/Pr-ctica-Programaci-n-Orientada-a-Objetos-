using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN10_p
{
    public class Empleado : Persona
    {
        public decimal Salario { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() +
                $"\nSalario: {Salario:C}\nFecha Ingreso: {FechaIngreso.ToShortDateString()}\nAntigüedad: {CalcularAntiguedad()} años";
        }
    }
}
