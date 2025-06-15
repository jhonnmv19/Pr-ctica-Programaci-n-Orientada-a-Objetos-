using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN7_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jugador jugador;

        private void BtnCapturarDatos_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumUniforne.Text);
            string nombre = txtNombre.Text;
            int minutos = int.Parse(txtMinJugados.Text);

            if (rbPortero.Checked)
            {
                jugador = new Portero(num, nombre, minutos);
            }
            else
            {
                int goles = int.Parse(txtGolesAnotados.Text);

                if (rbDefensa.Checked)
                    jugador = new Defensa(num, nombre, minutos, goles);
                else if (rbMedio.Checked)
                    jugador = new Medio(num, nombre, minutos, goles);
                else if (rbDelantero.Checked)
                    jugador = new Delantero(num, nombre, minutos, goles);
            }

            MessageBox.Show("Datos capturados correctamente");
        }

        private void btnMostrardatos_Click(object sender, EventArgs e)
        {
            if (jugador != null)
            {
                MessageBox.Show(jugador.Mostrar());
            }
            else
            {
                MessageBox.Show("Primero capture los datos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Deshabilitar goles para portero
        private void rbPortero_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = false;
        }

        private void rbDefensa_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = true;
        }

        private void rbMedio_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = true;
        }

        private void rbDelantero_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
