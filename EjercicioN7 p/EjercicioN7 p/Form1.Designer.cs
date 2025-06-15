namespace EjercicioN7_p
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDelantero = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbDefensa = new System.Windows.Forms.RadioButton();
            this.rbPortero = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGolesAnotados = new System.Windows.Forms.TextBox();
            this.txtMinJugados = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumUniforne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrardatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelantero);
            this.groupBox1.Controls.Add(this.rbMedio);
            this.groupBox1.Controls.Add(this.rbDefensa);
            this.groupBox1.Controls.Add(this.rbPortero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posicion del Jugador";
            // 
            // rbDelantero
            // 
            this.rbDelantero.AutoSize = true;
            this.rbDelantero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelantero.Location = new System.Drawing.Point(36, 131);
            this.rbDelantero.Name = "rbDelantero";
            this.rbDelantero.Size = new System.Drawing.Size(102, 22);
            this.rbDelantero.TabIndex = 3;
            this.rbDelantero.TabStop = true;
            this.rbDelantero.Text = "Delantero";
            this.rbDelantero.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedio.Location = new System.Drawing.Point(36, 100);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(75, 22);
            this.rbMedio.TabIndex = 2;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Medio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbDefensa
            // 
            this.rbDefensa.AutoSize = true;
            this.rbDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefensa.Location = new System.Drawing.Point(36, 70);
            this.rbDefensa.Name = "rbDefensa";
            this.rbDefensa.Size = new System.Drawing.Size(91, 22);
            this.rbDefensa.TabIndex = 1;
            this.rbDefensa.TabStop = true;
            this.rbDefensa.Text = "Defensa";
            this.rbDefensa.UseVisualStyleBackColor = true;
            // 
            // rbPortero
            // 
            this.rbPortero.AutoSize = true;
            this.rbPortero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPortero.Location = new System.Drawing.Point(36, 42);
            this.rbPortero.Name = "rbPortero";
            this.rbPortero.Size = new System.Drawing.Size(86, 22);
            this.rbPortero.TabIndex = 0;
            this.rbPortero.TabStop = true;
            this.rbPortero.Text = "Portero";
            this.rbPortero.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGolesAnotados);
            this.groupBox2.Controls.Add(this.txtMinJugados);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtNumUniforne);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Jugador";
            // 
            // txtGolesAnotados
            // 
            this.txtGolesAnotados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGolesAnotados.Location = new System.Drawing.Point(179, 163);
            this.txtGolesAnotados.Name = "txtGolesAnotados";
            this.txtGolesAnotados.Size = new System.Drawing.Size(77, 24);
            this.txtGolesAnotados.TabIndex = 7;
            // 
            // txtMinJugados
            // 
            this.txtMinJugados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinJugados.Location = new System.Drawing.Point(179, 116);
            this.txtMinJugados.Name = "txtMinJugados";
            this.txtMinJugados.Size = new System.Drawing.Size(77, 24);
            this.txtMinJugados.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(179, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 24);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNumUniforne
            // 
            this.txtNumUniforne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumUniforne.Location = new System.Drawing.Point(179, 39);
            this.txtNumUniforne.Name = "txtNumUniforne";
            this.txtNumUniforne.Size = new System.Drawing.Size(77, 24);
            this.txtNumUniforne.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goles Anotados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min. Jugados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. Uniforme";
            // 
            // BtnCapturarDatos
            // 
            this.BtnCapturarDatos.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnCapturarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapturarDatos.Location = new System.Drawing.Point(297, 62);
            this.BtnCapturarDatos.Name = "BtnCapturarDatos";
            this.BtnCapturarDatos.Size = new System.Drawing.Size(152, 51);
            this.BtnCapturarDatos.TabIndex = 2;
            this.BtnCapturarDatos.Text = "Capturar Datos";
            this.BtnCapturarDatos.UseVisualStyleBackColor = true;
            this.BtnCapturarDatos.Click += new System.EventHandler(this.BtnCapturarDatos_Click);
            // 
            // btnMostrardatos
            // 
            this.btnMostrardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrardatos.Location = new System.Drawing.Point(297, 143);
            this.btnMostrardatos.Name = "btnMostrardatos";
            this.btnMostrardatos.Size = new System.Drawing.Size(152, 51);
            this.btnMostrardatos.TabIndex = 3;
            this.btnMostrardatos.Text = "Mostrar Datos";
            this.btnMostrardatos.UseVisualStyleBackColor = true;
            this.btnMostrardatos.Click += new System.EventHandler(this.btnMostrardatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(297, 221);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 51);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 544);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrardatos);
            this.Controls.Add(this.BtnCapturarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Jugador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCapturarDatos;
        private System.Windows.Forms.Button btnMostrardatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rbPortero;
        private System.Windows.Forms.RadioButton rbDelantero;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbDefensa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGolesAnotados;
        private System.Windows.Forms.TextBox txtMinJugados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumUniforne;
    }
}

