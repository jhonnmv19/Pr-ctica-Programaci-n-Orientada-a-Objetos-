using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN2_p
{
   
    
        public partial class Form1 : Form
        {
            Rectangulo miRectangulo = new Rectangulo(0, 0);

            public Form1()
            {
                InitializeComponent();
            }

            private void btnModificar_Click(object sender, EventArgs e)
            {
                try
                {
                    miRectangulo.Largo = double.Parse(txtLargo.Text);
                    miRectangulo.Ancho = double.Parse(txtAncho.Text);
                    MessageBox.Show("Dimensiones modificadas correctamente.");
                }
                catch
                {
                    MessageBox.Show("Error: Ingresa valores numéricos válidos.");
                }
            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                double area = miRectangulo.CalcularArea();
                lblResultado.Text = "Área: " + area.ToString("F2");
            }

            private void btnConsultar_Click(object sender, EventArgs e)
            {
                double largo = miRectangulo.Largo;
                double ancho = miRectangulo.Ancho;

                MessageBox.Show($"Largo: {largo}\nAncho: {ancho}");
            }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    

}
