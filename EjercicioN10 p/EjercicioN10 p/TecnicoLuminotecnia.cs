using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN10_p
{
    public class TecnicoLuminotecnia : Empleado
    {
        public string AreaAsignada { get; set; }
        public string Turno { get; set; }

        public void AsignarTurno(string turno)
        {
            Turno = turno;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() +
                $"\nÁrea Asignada: {AreaAsignada}\nTurno: {Turno}";
        }
    }
}
