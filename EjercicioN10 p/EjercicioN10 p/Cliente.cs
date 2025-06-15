using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN10_p
{
    public class Cliente : Persona
    {
        public decimal LimiteCredito { get; set; }
        public List<string> HistorialCompras { get; set; } = new List<string>();

        public bool VerificarCreditoDisponible(decimal monto)
        {
            return monto <= LimiteCredito;
        }

        public override string MostrarDatos()
        {
            string compras = string.Join(", ", HistorialCompras);
            return base.MostrarDatos() +
                $"\nLímite Crédito: {LimiteCredito:C}\nCompras: {compras}";
        }
    }
}
