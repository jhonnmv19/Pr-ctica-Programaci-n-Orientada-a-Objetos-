using System;
using System.Windows.Forms;
using EjercicioN1_P;

namespace TuProyecto
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
