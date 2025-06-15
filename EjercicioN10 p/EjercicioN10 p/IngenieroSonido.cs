using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN10_p
{
    public class IngenieroSonido : Empleado
    {
        public string Especialidad { get; set; }
        public int AniosExperiencia { get; set; }

        public bool ValidarEquipoSonido()
        {
            return AniosExperiencia >= 2;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() +
                $"\nEspecialidad: {Especialidad}\nAños de Experiencia: {AniosExperiencia}\nEquipo Validado: {ValidarEquipoSonido()}";
        }
    }

}
