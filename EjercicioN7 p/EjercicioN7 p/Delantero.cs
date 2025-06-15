using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioN7_p

{
    public class Delantero : Jugador
    {
        public int Goles { get; set; }

        public Delantero(int numUniforme, string nombre, int minJugados, int goles)
            : base(numUniforme, nombre, minJugados)
        {
            Goles = goles;
        }

        public override string Mostrar()
        {
            return $"Delantero - #{NumUniforme}, Nombre: {Nombre}, Min. Jugados: {MinJugados}, Goles: {Goles}";
        }
    }
}
