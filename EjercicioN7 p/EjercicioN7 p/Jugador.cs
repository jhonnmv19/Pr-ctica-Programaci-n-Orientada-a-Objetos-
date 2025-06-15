using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN7_p
{
    public abstract class Jugador
    {
        public int NumUniforme { get; set; }
        public string Nombre { get; set; }
        public int MinJugados { get; set; }

        public Jugador(int numUniforme, string nombre, int minJugados)
        {
            NumUniforme = numUniforme;
            Nombre = nombre;
            MinJugados = minJugados;
        }

        public abstract string Mostrar();
    }
}

