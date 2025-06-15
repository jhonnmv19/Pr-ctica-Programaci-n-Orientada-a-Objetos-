using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioN4_p
{
    public class CambioDivisas
    {
        private double pesos;
        private double tipoCambio;

        public CambioDivisas(double tc)
        {
            tipoCambio = tc;
        }

        public double Pesos
        {
            get { return pesos; }
            set { pesos = value; }
        }

        public double TipoCambio
        {
            get { return tipoCambio; }
            set { tipoCambio = value; }
        }

        public double ConvertirADolares()
        {
            return pesos / tipoCambio;
        }
    }

}
