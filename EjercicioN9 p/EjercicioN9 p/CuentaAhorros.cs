using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN9_p
{
    public class CuentaAhorros : Cuenta
    {
        public DateTime FechaVencimiento { get; set; }
        public double PorcentajeInteresMensual { get; set; }
        public CuentaAhorros(int numero, string nombre, double saldoInicial, DateTime fechaVenc, double interes)
            : base(numero, nombre, saldoInicial)
        {
            FechaVencimiento = fechaVenc;
            PorcentajeInteresMensual = interes;
        }

        public override bool Retirar(double monto)
        {
            if (DateTime.Now.Date == FechaVencimiento.Date && monto > 0 && saldo >= monto)
            {
                saldo -= monto;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DepositarInteres()
        {
            double interes = saldo * PorcentajeInteresMensual;
            saldo += interes;
        }
    }
}
