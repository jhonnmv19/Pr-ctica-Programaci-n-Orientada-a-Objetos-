using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN9_p
{
    public class CuentaCheques : Cuenta
    {
        public double ComisionChequera { get; set; }
        public double ComisionChequeInsuficiente { get; set; }

        public CuentaCheques(int numero, string nombre, double saldoInicial, double comisionChequera, double comisionChequeInsuficiente)
            : base(numero, nombre, saldoInicial)
        {
            ComisionChequera = comisionChequera;
            ComisionChequeInsuficiente = comisionChequeInsuficiente;
        }

        public override bool Retirar(double monto)
        {
            if (monto <= 0) return false;

            if (saldo >= monto)
            {
                saldo -= monto;
                return true;
            }
            else
            {
                saldo -= ComisionChequeInsuficiente;
                return false;
            }
        }
    }
}