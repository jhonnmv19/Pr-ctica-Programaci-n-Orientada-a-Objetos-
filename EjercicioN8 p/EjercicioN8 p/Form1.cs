using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN8_p
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        Empleado empleado;

        public Form1()
        {
            InitializeComponent();
            rbCliente.Checked = true;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string domicilio = tbDomicilio.Text;

            if (rbCliente.Checked)
            {
                double credito = double.Parse(tbDatoExtra.Text);
                cliente = new Cliente(nombre, domicilio, credito);
            }
            else
            {
                double salario = double.Parse(tbDatoExtra.Text);
                empleado = new Empleado(nombre, domicilio, salario);
            }

            MessageBox.Show("Datos capturados correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked && cliente != null)
            {
                lbMostrar.Text = $"Cliente:\nNombre: {cliente.Nombre}\nDomicilio: {cliente.Domicilio}\nCrédito: {cliente.Credito}";
            }
            else if (empleado != null)
            {
                lbMostrar.Text = $"Empleado:\nNombre: {empleado.Nombre}\nDomicilio: {empleado.Domicilio}\nSalario: {empleado.Salario}";
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            lblDatoExtra.Text = "Crédito:";
        }

        private void rbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            lblDatoExtra.Text = "Salario:";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
