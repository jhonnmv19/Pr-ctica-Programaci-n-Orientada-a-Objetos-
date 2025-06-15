namespace EjercicioN9_p
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.ComboBox comboBoxTipoCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxAhorro;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxCheques;
        private System.Windows.Forms.TextBox txtComisionUso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComisionInsuf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnDepositarInteres;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label10;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.comboBoxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAhorro = new System.Windows.Forms.GroupBox();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxCheques = new System.Windows.Forms.GroupBox();
            this.txtComisionUso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComisionInsuf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnDepositarInteres = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxAhorro.SuspendLayout();
            this.groupBoxCheques.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Cuenta:";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(236, 49);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(241, 24);
            this.txtNumeroCuenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(236, 79);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(241, 24);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo Inicial:";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.Location = new System.Drawing.Point(236, 109);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(241, 24);
            this.txtSaldoInicial.TabIndex = 5;
            // 
            // comboBoxTipoCuenta
            // 
            this.comboBoxTipoCuenta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoCuenta.Items.AddRange(new object[] {
            "Ahorro",
            "Cheques"});
            this.comboBoxTipoCuenta.Location = new System.Drawing.Point(236, 139);
            this.comboBoxTipoCuenta.Name = "comboBoxTipoCuenta";
            this.comboBoxTipoCuenta.Size = new System.Drawing.Size(241, 26);
            this.comboBoxTipoCuenta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Cuenta:";
            // 
            // groupBoxAhorro
            // 
            this.groupBoxAhorro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxAhorro.Controls.Add(this.dateTimePickerVencimiento);
            this.groupBoxAhorro.Controls.Add(this.label5);
            this.groupBoxAhorro.Controls.Add(this.txtInteres);
            this.groupBoxAhorro.Controls.Add(this.label6);
            this.groupBoxAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAhorro.Location = new System.Drawing.Point(96, 183);
            this.groupBoxAhorro.Name = "groupBoxAhorro";
            this.groupBoxAhorro.Size = new System.Drawing.Size(370, 90);
            this.groupBoxAhorro.TabIndex = 8;
            this.groupBoxAhorro.TabStop = false;
            this.groupBoxAhorro.Text = "Datos Cuenta Ahorro";
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(100, 21);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(150, 24);
            this.dateTimePickerVencimiento.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha Vencimiento:";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(100, 55);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(150, 24);
            this.txtInteres.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Interés % Mensual:";
            // 
            // groupBoxCheques
            // 
            this.groupBoxCheques.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxCheques.Controls.Add(this.txtComisionUso);
            this.groupBoxCheques.Controls.Add(this.label7);
            this.groupBoxCheques.Controls.Add(this.txtComisionInsuf);
            this.groupBoxCheques.Controls.Add(this.label8);
            this.groupBoxCheques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCheques.Location = new System.Drawing.Point(97, 183);
            this.groupBoxCheques.Name = "groupBoxCheques";
            this.groupBoxCheques.Size = new System.Drawing.Size(370, 90);
            this.groupBoxCheques.TabIndex = 9;
            this.groupBoxCheques.TabStop = false;
            this.groupBoxCheques.Text = "Datos Cuenta Cheques";
            this.groupBoxCheques.Visible = false;
            // 
            // txtComisionUso
            // 
            this.txtComisionUso.Location = new System.Drawing.Point(130, 25);
            this.txtComisionUso.Name = "txtComisionUso";
            this.txtComisionUso.Size = new System.Drawing.Size(120, 24);
            this.txtComisionUso.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Comisión Uso Chequera:";
            // 
            // txtComisionInsuf
            // 
            this.txtComisionInsuf.Location = new System.Drawing.Point(130, 55);
            this.txtComisionInsuf.Name = "txtComisionInsuf";
            this.txtComisionInsuf.Size = new System.Drawing.Size(120, 24);
            this.txtComisionInsuf.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Comisión Cheque Insuf.:";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.LightCoral;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(183, 279);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(195, 37);
            this.btnCrearCuenta.TabIndex = 10;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(237, 322);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 24);
            this.txtMonto.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Monto:";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(79, 368);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(96, 48);
            this.btnDepositar.TabIndex = 13;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.DeepPink;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(220, 368);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(96, 48);
            this.btnRetirar.TabIndex = 14;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            // 
            // btnDepositarInteres
            // 
            this.btnDepositarInteres.BackColor = System.Drawing.Color.Silver;
            this.btnDepositarInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositarInteres.Location = new System.Drawing.Point(370, 368);
            this.btnDepositarInteres.Name = "btnDepositarInteres";
            this.btnDepositarInteres.Size = new System.Drawing.Size(96, 48);
            this.btnDepositarInteres.TabIndex = 15;
            this.btnDepositarInteres.Text = "Interés Mensual";
            this.btnDepositarInteres.UseVisualStyleBackColor = false;
            this.btnDepositarInteres.Click += new System.EventHandler(this.btnDepositarInteres_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(96, 459);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatos.Size = new System.Drawing.Size(388, 120);
            this.txtDatos.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Datos Cuenta:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(556, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTipoCuenta);
            this.Controls.Add(this.groupBoxAhorro);
            this.Controls.Add(this.groupBoxCheques);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositarInteres);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDatos);
            this.Name = "Form1";
            this.Text = "Banco";
            this.groupBoxAhorro.ResumeLayout(false);
            this.groupBoxAhorro.PerformLayout();
            this.groupBoxCheques.ResumeLayout(false);
            this.groupBoxCheques.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}


