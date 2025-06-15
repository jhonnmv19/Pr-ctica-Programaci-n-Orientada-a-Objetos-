using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EjercicioN10_p
{
    public partial class Form1 : Form
    {
        Persona personaActual;

        public Form1()
        {
            InitializeComponent();

            cbTipoPersona.SelectedIndex = 0; // Cliente por defecto
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;

            string tipo = cbTipoPersona.SelectedItem.ToString();

            if (tipo == "Cliente")
            {
                decimal limiteCredito;
                if (!decimal.TryParse(txtLimiteCredito.Text, out limiteCredito))
                {
                    MessageBox.Show("Límite de crédito inválido.");
                    return;
                }

                List<string> historial = new List<string>(txtHistorialCompras.Text.Split(','));

                Cliente cliente = new Cliente
                {
                    Nombre = nombre,
                    Domicilio = domicilio,
                    Telefono = telefono,
                    LimiteCredito = limiteCredito,
                    HistorialCompras = historial
                };

                personaActual = cliente;
            }
            else if (tipo == "IngenieroSonido")
            {
                decimal salario;
                int aniosExp;

                if (!decimal.TryParse(txtSalario.Text, out salario) || !int.TryParse(txtAniosExperiencia.Text, out aniosExp))
                {
                    MessageBox.Show("Datos inválidos para Ingeniero.");
                    return;
                }

                IngenieroSonido ing = new IngenieroSonido
                {
                    Nombre = nombre,
                    Domicilio = domicilio,
                    Telefono = telefono,
                    Salario = salario,
                    FechaIngreso = dtpFechaIngreso.Value,
                    Especialidad = txtEspecialidad.Text,
                    AniosExperiencia = aniosExp
                };

                personaActual = ing;
            }
            else if (tipo == "TecnicoLuminotecnia")
            {
                decimal salario;

                if (!decimal.TryParse(txtSalario.Text, out salario))
                {
                    MessageBox.Show("Salario inválido.");
                    return;
                }

                TecnicoLuminotecnia tecnico = new TecnicoLuminotecnia
                {
                    Nombre = nombre,
                    Domicilio = domicilio,
                    Telefono = telefono,
                    Salario = salario,
                    FechaIngreso = dtpFechaIngreso.Value,
                    AreaAsignada = txtAreaAsignada.Text,
                    Turno = txtTurno.Text
                };

                personaActual = tecnico;
            }

            MessageBox.Show("Datos capturados correctamente.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (personaActual != null)
            {
                txtSalida.Text = personaActual.MostrarDatos();
            }
            else
            {
                MessageBox.Show("Primero capture los datos.");
            }
        }


    }
}
