using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Restaurante
    {

        public int HamburguesaSencilla { get; set; }
        public int HamburguesaConQueso { get; set; }
        public int HamburguesaEspecial { get; set; }
        public int PapasFritas { get; set; }
        public int Refresco { get; set; }
        public int Postre { get; set; }

        private readonly double precioHsencilla = 15;
        private readonly double precioHconQueso = 18;
        private readonly double precioHespecial = 20;
        private readonly double precioPapas = 8;
        private readonly double precioRefresco = 5;
        private readonly double precioPostre = 6;

        public double CalcularTotal()
        {
            return (HamburguesaSencilla * precioHsencilla) +
                   (HamburguesaConQueso * precioHconQueso) +
                   (HamburguesaEspecial * precioHespecial) +
                   (PapasFritas * precioPapas) +
                   (Refresco * precioRefresco) +
                   (Postre * precioPostre);
        }
    }
}

