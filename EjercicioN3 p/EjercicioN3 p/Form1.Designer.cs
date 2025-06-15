namespace EjercicioN3_p
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnIVA;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rbArticulo1;
        private System.Windows.Forms.RadioButton rbArticulo2;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnIVA = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbArticulo1 = new System.Windows.Forms.RadioButton();
            this.rbArticulo2 = new System.Windows.Forms.RadioButton();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClave.Location = new System.Drawing.Point(258, 24);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(128, 22);
            this.txtClave.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Location = new System.Drawing.Point(258, 64);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(128, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrecio.Location = new System.Drawing.Point(258, 104);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCantidad.Location = new System.Drawing.Point(258, 144);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(90, 247);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 49);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnIVA
            // 
            this.btnIVA.BackColor = System.Drawing.Color.Gold;
            this.btnIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIVA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIVA.Location = new System.Drawing.Point(384, 247);
            this.btnIVA.Name = "btnIVA";
            this.btnIVA.Size = new System.Drawing.Size(100, 49);
            this.btnIVA.TabIndex = 11;
            this.btnIVA.Text = "Calcular IVA";
            this.btnIVA.UseVisualStyleBackColor = false;
            this.btnIVA.Click += new System.EventHandler(this.btnIVA_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(236, 247);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 49);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(370, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(114, 20);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "IVA: Bs 0.00";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // rbArticulo1
            // 
            this.rbArticulo1.Checked = true;
            this.rbArticulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArticulo1.Location = new System.Drawing.Point(118, 186);
            this.rbArticulo1.Name = "rbArticulo1";
            this.rbArticulo1.Size = new System.Drawing.Size(116, 24);
            this.rbArticulo1.TabIndex = 8;
            this.rbArticulo1.TabStop = true;
            this.rbArticulo1.Text = "Artículo 1";
            // 
            // rbArticulo2
            // 
            this.rbArticulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArticulo2.Location = new System.Drawing.Point(240, 188);
            this.rbArticulo2.Name = "rbArticulo2";
            this.rbArticulo2.Size = new System.Drawing.Size(121, 24);
            this.rbArticulo2.TabIndex = 9;
            this.rbArticulo2.Text = "Artículo 2";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(118, 26);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(62, 20);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(118, 66);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(118, 106);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(118, 146);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(572, 378);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.rbArticulo1);
            this.Controls.Add(this.rbArticulo2);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnIVA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "IVA de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

