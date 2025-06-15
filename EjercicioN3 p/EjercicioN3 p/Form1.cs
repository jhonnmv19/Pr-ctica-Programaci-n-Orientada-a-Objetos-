using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN3_p
{
 
        public partial class Form1 : Form
        {
            Articulo Articulo1 = new Articulo();
            Articulo Articulo2 = new Articulo();

            public Form1()
            {
                InitializeComponent();
            }

            private void btnAsignar_Click(object sender, EventArgs e)
            {
                int clave = int.Parse(txtClave.Text);
                string descripcion = txtDescripcion.Text;
                double precio = double.Parse(txtPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                if (rbArticulo1.Checked)
                {
                    Articulo1.setClave(clave);
                    Articulo1.setDescripcion(descripcion);
                    Articulo1.setPrecio(precio);
                    Articulo1.setCantidad(cantidad);
                    MessageBox.Show("Datos asignados a Artículo 1");
                }
                else
                {
                    Articulo2.setClave(clave);
                    Articulo2.setDescripcion(descripcion);
                    Articulo2.setPrecio(precio);
                    Articulo2.setCantidad(cantidad);
                    MessageBox.Show("Datos asignados a Artículo 2");
                }
            }

            private void btnIVA_Click(object sender, EventArgs e)
            {
                double iva;

                if (rbArticulo1.Checked)
                {
                    iva = Articulo1.CalcularIVA();
                }
                else
                {
                    iva = Articulo2.CalcularIVA();
                }

                lblResultado.Text = "IVA: Bs " + iva.ToString("0.00");
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
    

}
