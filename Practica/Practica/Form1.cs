using System;
using System.Windows.Forms;
using Practica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica
{
    public partial class Form1 : Form
    {
  
        Restaurante[] mesas = new Restaurante[5];

        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < mesas.Length; i++)
                mesas[i] = new Restaurante();

            comboBox1.SelectedIndex = 0; 
        }

        private void btnCapturarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceMesa = comboBox1.SelectedIndex;
                if (indiceMesa < 0)
                {
                    MessageBox.Show("Por favor, seleccione una mesa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mesas[indiceMesa].HamburguesaSencilla = int.Parse(txtHsencilla.Text);
                mesas[indiceMesa].HamburguesaConQueso = int.Parse(txtHconQueso.Text);
                mesas[indiceMesa].HamburguesaEspecial = int.Parse(txtHespecial.Text);
                mesas[indiceMesa].PapasFritas = int.Parse(txtPapasFritas.Text);
                mesas[indiceMesa].Refresco = int.Parse(txtRefresco.Text);
                mesas[indiceMesa].Postre = int.Parse(txtPostre.Text);

                MessageBox.Show($"Orden capturada correctamente para {comboBox1.SelectedItem}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Por favor, ingresa solo números enteros válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            int indiceMesa = comboBox1.SelectedIndex;
            if (indiceMesa < 0)
            {
                MessageBox.Show("Por favor, seleccione una mesa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double total = mesas[indiceMesa].CalcularTotal();
            string mesa = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"Total a pagar por {mesa} es: Bs {total:F2}", "Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
