namespace EjercicioN8_p
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbDatoExtra;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblDatoExtra;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbMostrar;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método requerido para el diseñador: no modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbDatoExtra = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblDatoExtra = new System.Windows.Forms.Label();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(182, 101);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 24);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDomicilio.Location = new System.Drawing.Point(182, 134);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(200, 24);
            this.tbDomicilio.TabIndex = 3;
            // 
            // tbDatoExtra
            // 
            this.tbDatoExtra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDatoExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatoExtra.Location = new System.Drawing.Point(182, 166);
            this.tbDatoExtra.Name = "tbDatoExtra";
            this.tbDatoExtra.Size = new System.Drawing.Size(200, 24);
            this.tbDatoExtra.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(88, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(88, 134);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(84, 18);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblDatoExtra
            // 
            this.lblDatoExtra.AutoSize = true;
            this.lblDatoExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoExtra.Location = new System.Drawing.Point(88, 169);
            this.lblDatoExtra.Name = "lblDatoExtra";
            this.lblDatoExtra.Size = new System.Drawing.Size(68, 18);
            this.lblDatoExtra.TabIndex = 4;
            this.lblDatoExtra.Text = "Crédito:";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.BackColor = System.Drawing.Color.White;
            this.rbCliente.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbCliente.Checked = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.Location = new System.Drawing.Point(143, 210);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(81, 22);
            this.rbCliente.TabIndex = 6;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = false;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.BackColor = System.Drawing.Color.White;
            this.rbEmpleado.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleado.Location = new System.Drawing.Point(248, 210);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(104, 22);
            this.rbEmpleado.TabIndex = 7;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = false;
            this.rbEmpleado.CheckedChanged += new System.EventHandler(this.rbEmpleado_CheckedChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(85, 259);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(97, 37);
            this.btnCapturar.TabIndex = 8;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Yellow;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(185, 259);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(97, 37);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(285, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 37);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbMostrar
            // 
            this.lbMostrar.BackColor = System.Drawing.Color.MintCream;
            this.lbMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrar.Location = new System.Drawing.Point(85, 313);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(297, 80);
            this.lbMostrar.TabIndex = 11;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(485, 516);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.lblDatoExtra);
            this.Controls.Add(this.tbDatoExtra);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.rbEmpleado);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbMostrar);
            this.Name = "Form1";
            this.Text = "Gestión de Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

