using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN4_p
{
    public partial class Form1 : Form
    {
        CambioDivisas cambio;

        public Form1()
        {
            InitializeComponent();
            cambio = new CambioDivisas(6.92); 
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double bolivianos = double.Parse(txtPesos.Text);
            cambio.Pesos = bolivianos;

            double dolares = cambio.ConvertirADolares();
            lblResultado.Text = $"USD: {dolares:F2}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
