namespace EjercicioN6_p
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoordeY = new System.Windows.Forms.TextBox();
            this.txtCoordeX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPunto2 = new System.Windows.Forms.RadioButton();
            this.rbPunto1 = new System.Windows.Forms.RadioButton();
            this.btnCapturarCoorde = new System.Windows.Forms.Button();
            this.btnCalcularDistancia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCoordeY);
            this.groupBox1.Controls.Add(this.txtCoordeX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(64, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas del Punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordenada Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordenada X";
            // 
            // txtCoordeY
            // 
            this.txtCoordeY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoordeY.Location = new System.Drawing.Point(181, 101);
            this.txtCoordeY.Name = "txtCoordeY";
            this.txtCoordeY.Size = new System.Drawing.Size(78, 22);
            this.txtCoordeY.TabIndex = 1;
            // 
            // txtCoordeX
            // 
            this.txtCoordeX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoordeX.Location = new System.Drawing.Point(181, 59);
            this.txtCoordeX.Name = "txtCoordeX";
            this.txtCoordeX.Size = new System.Drawing.Size(78, 22);
            this.txtCoordeX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPunto2);
            this.groupBox2.Controls.Add(this.rbPunto1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(64, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione el Punto";
            // 
            // rbPunto2
            // 
            this.rbPunto2.AutoSize = true;
            this.rbPunto2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPunto2.Location = new System.Drawing.Point(35, 85);
            this.rbPunto2.Name = "rbPunto2";
            this.rbPunto2.Size = new System.Drawing.Size(79, 20);
            this.rbPunto2.TabIndex = 1;
            this.rbPunto2.TabStop = true;
            this.rbPunto2.Text = "Punto 2";
            this.rbPunto2.UseVisualStyleBackColor = true;
            // 
            // rbPunto1
            // 
            this.rbPunto1.AutoSize = true;
            this.rbPunto1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPunto1.Location = new System.Drawing.Point(35, 36);
            this.rbPunto1.Name = "rbPunto1";
            this.rbPunto1.Size = new System.Drawing.Size(79, 20);
            this.rbPunto1.TabIndex = 0;
            this.rbPunto1.TabStop = true;
            this.rbPunto1.Text = "Punto 1";
            this.rbPunto1.UseVisualStyleBackColor = true;
            // 
            // btnCapturarCoorde
            // 
            this.btnCapturarCoorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturarCoorde.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCapturarCoorde.Location = new System.Drawing.Point(442, 108);
            this.btnCapturarCoorde.Name = "btnCapturarCoorde";
            this.btnCapturarCoorde.Size = new System.Drawing.Size(136, 56);
            this.btnCapturarCoorde.TabIndex = 2;
            this.btnCapturarCoorde.Text = "Capturar Coordenadas";
            this.btnCapturarCoorde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapturarCoorde.UseVisualStyleBackColor = true;
            this.btnCapturarCoorde.Click += new System.EventHandler(this.btnCapturarCoorde_Click);
            // 
            // btnCalcularDistancia
            // 
            this.btnCalcularDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDistancia.Location = new System.Drawing.Point(442, 204);
            this.btnCalcularDistancia.Name = "btnCalcularDistancia";
            this.btnCalcularDistancia.Size = new System.Drawing.Size(136, 56);
            this.btnCalcularDistancia.TabIndex = 3;
            this.btnCalcularDistancia.Text = "Calcular Distancia";
            this.btnCalcularDistancia.UseVisualStyleBackColor = true;
            this.btnCalcularDistancia.Click += new System.EventHandler(this.btnCalcularDistancia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(442, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 56);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 511);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularDistancia);
            this.Controls.Add(this.btnCapturarCoorde);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Coordenadas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoordeY;
        private System.Windows.Forms.TextBox txtCoordeX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPunto2;
        private System.Windows.Forms.RadioButton rbPunto1;
        private System.Windows.Forms.Button btnCapturarCoorde;
        private System.Windows.Forms.Button btnCalcularDistancia;
        private System.Windows.Forms.Button btnSalir;
    }
}

