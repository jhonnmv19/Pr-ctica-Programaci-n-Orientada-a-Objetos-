using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioN7_p
{
    public class Portero : Jugador
    {
        public Portero(int numUniforme, string nombre, int minJugados)
            : base(numUniforme, nombre, minJugados)
        {
        }

        public override string Mostrar()
        {
            return $"Portero - #{NumUniforme}, Nombre: {Nombre}, Min. Jugados: {MinJugados}";
        }
    }
}
