using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN6_p
{
    public partial class Form1 : Form
    {
        PuntoCoordenadas punto1 = new PuntoCoordenadas();
        PuntoCoordenadas punto2 = new PuntoCoordenadas();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturarCoorde_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtCoordeX.Text);
            double y = double.Parse(txtCoordeY.Text);

            if (rbPunto1.Checked == true)
            {
                punto1.setX(x);
                punto1.setY(y);
                MessageBox.Show("Punto 1 capturado: (" + punto1.getX() + ", " + punto1.getY() + ")");
            }
            else if (rbPunto2.Checked == true)
            {
                punto2.setX(x);
                punto2.setY(y);
                MessageBox.Show("Punto 2 capturado: (" + punto2.getX() + ", " + punto2.getY() + ")");
            }
            else
            {
                MessageBox.Show("Seleccione un punto para capturar las coordenadas.");
            }
        }

        private void btnCalcularDistancia_Click(object sender, EventArgs e)
        {
            double d = punto1.distancia(punto2);
            MessageBox.Show("Distancia entre P1 y P2 = " + d.ToString("F2"));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapturarCoorde_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcularDistancia_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
