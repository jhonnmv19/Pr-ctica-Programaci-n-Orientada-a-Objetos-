using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN7_p
{
    public class Defensa : Jugador
    {
        public int Goles { get; set; }

        public Defensa(int numUniforme, string nombre, int minJugados, int goles)
            : base(numUniforme, nombre, minJugados)
        {
            Goles = goles;
        }

        public override string Mostrar()
        {
            return $"Defensa - #{NumUniforme}, Nombre: {Nombre}, Min. Jugados: {MinJugados}, Goles: {Goles}";
        }
    }
}

