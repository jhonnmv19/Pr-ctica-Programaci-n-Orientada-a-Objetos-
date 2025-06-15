using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioN7_p
{
    public class Medio : Jugador
    {
        public int Goles { get; set; }

        public Medio(int numUniforme, string nombre, int minJugados, int goles)
            : base(numUniforme, nombre, minJugados)
        {
            Goles = goles;
        }

        public override string Mostrar()
        {
            return $"Medio - #{NumUniforme}, Nombre: {Nombre}, Min. Jugados: {MinJugados}, Goles: {Goles}";
        }
    }
}

