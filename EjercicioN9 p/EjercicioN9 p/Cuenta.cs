using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN9_p
{
    public abstract class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public string NombreCliente { get; set; }
        protected double saldo;

        public Cuenta(int numero, string nombre, double saldoInicial)
        {
            NumeroCuenta = numero;
            NombreCliente = nombre;
            saldo = saldoInicial;
        }

        public double Saldo => saldo;

        public virtual void Depositar(double monto)
        {
            if (monto > 0)
                saldo += monto;
        }

        public abstract bool Retirar(double monto);

        public override string ToString()
        {
            return $"Cuenta: {NumeroCuenta}, Cliente: {NombreCliente}, Saldo: {saldo:C2}";
        }
    }

}
