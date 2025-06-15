using System;
using System.Windows.Forms;

namespace EjercicioN9_p
{
    public partial class Form1 : Form
    {
        private decimal saldo = 0; 

        public Form1()
        {
            InitializeComponent();

            comboBoxTipoCuenta.SelectedIndexChanged += ComboBoxTipoCuenta_SelectedIndexChanged;
            btnCrearCuenta.Click += BtnCrearCuenta_Click;
            btnDepositar.Click += BtnDepositar_Click;
            btnRetirar.Click += BtnRetirar_Click;
      
        }

        private void ComboBoxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoCuenta.SelectedItem.ToString() == "Ahorro")
            {
                groupBoxAhorro.Visible = true;
                groupBoxCheques.Visible = false;
            }
            else if (comboBoxTipoCuenta.SelectedItem.ToString() == "Cheques")
            {
                groupBoxAhorro.Visible = false;
                groupBoxCheques.Visible = true;
            }
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxTipoCuenta.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Seleccione un tipo de cuenta.");
                return;
            }

            if (!decimal.TryParse(txtSaldoInicial.Text, out saldo))
            {
                MessageBox.Show("Saldo inicial inválido.");
                return;
            }

            string datos = $"Cuenta: {txtNumeroCuenta.Text}\r\n" +
                           $"Cliente: {txtNombreCliente.Text}\r\n" +
                           $"Saldo: {saldo:C}\r\n" +
                           $"Tipo: {tipo}\r\n";

            if (tipo == "Ahorro")
            {
                datos += $"Vence: {dateTimePickerVencimiento.Value.ToShortDateString()}\r\n" +
                         $"Interés: {txtInteres.Text}%\r\n";
            }
            else if (tipo == "Cheques")
            {
                datos += $"Com. Uso: {txtComisionUso.Text}\r\n" +
                         $"Com. Insuf.: {txtComisionInsuf.Text}\r\n";
            }

            txtDatos.Text = datos;
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && monto > 0)
            {
                saldo += monto;
                ActualizarDatos();
                MessageBox.Show($"Depósito exitoso. Nuevo saldo: {saldo:C}");
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido en el campo correspondiente.");
            }
        }


        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && monto > 0)
            {
                if (monto <= saldo)
                {
                    saldo -= monto;
                    ActualizarDatos();
                    MessageBox.Show($"Retiro exitoso. Nuevo saldo: {saldo:C}");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido en el campo correspondiente.");
            }
        }


        private void btnDepositarInteres_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtInteres.Text, out decimal interes) && interes > 0)
            {
                decimal ganancia = saldo * (interes / 100);
                saldo += ganancia;
                ActualizarDatos();
                MessageBox.Show($"Interés aplicado: {ganancia:C}\nNuevo saldo: {saldo:C}");
            }
            else
            {
                MessageBox.Show("Ingrese un interés válido en la sección de Ahorro.");
            }
        }

        private void ActualizarDatos()
        {
            string tipo = comboBoxTipoCuenta.SelectedItem?.ToString();

            string datos = $"Cuenta: {txtNumeroCuenta.Text}\r\n" +
                           $"Cliente: {txtNombreCliente.Text}\r\n" +
                           $"Saldo: {saldo:C}\r\n" +
                           $"Tipo: {tipo}\r\n";

            if (tipo == "Ahorro")
            {
                datos += $"Vence: {dateTimePickerVencimiento.Value.ToShortDateString()}\r\n" +
                         $"Interés: {txtInteres.Text}%\r\n";
            }
            else if (tipo == "Cheques")
            {
                datos += $"Com. Uso: {txtComisionUso.Text}\r\n" +
                         $"Com. Insuf.: {txtComisionInsuf.Text}\r\n";
            }

            txtDatos.Text = datos;
        }
    }
}
