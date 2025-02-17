namespace interfazPpal
{
    partial class FrmBuscarPaquete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMostrarPaquetes = new System.Windows.Forms.DataGridView();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblIdPaquete = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIntervaloSalida = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(19, 29);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(53, 16);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(1169, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMostrarPaquetes
            // 
            this.dgvMostrarPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarPaquetes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMostrarPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarPaquetes.Location = new System.Drawing.Point(42, 185);
            this.dgvMostrarPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrarPaquetes.Name = "dgvMostrarPaquetes";
            this.dgvMostrarPaquetes.RowHeadersWidth = 51;
            this.dgvMostrarPaquetes.Size = new System.Drawing.Size(1365, 568);
            this.dgvMostrarPaquetes.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(149, 71);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(485, 71);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(43, 16);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Hasta";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(205, 70);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(272, 22);
            this.dtpFechaSalida.TabIndex = 6;
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Location = new System.Drawing.Point(536, 70);
            this.dtpFechaRegreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(268, 22);
            this.dtpFechaRegreso.TabIndex = 7;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReservar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservar.Location = new System.Drawing.Point(1169, 80);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(117, 39);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1169, 127);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(19, 106);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(90, 103);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(208, 24);
            this.cmbEstado.TabIndex = 29;
            // 
            // lblIdPaquete
            // 
            this.lblIdPaquete.AutoSize = true;
            this.lblIdPaquete.Location = new System.Drawing.Point(343, 32);
            this.lblIdPaquete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPaquete.Name = "lblIdPaquete";
            this.lblIdPaquete.Size = new System.Drawing.Size(78, 16);
            this.lblIdPaquete.TabIndex = 30;
            this.lblIdPaquete.Text = "Id. Paquete:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(422, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 31;
            // 
            // lblIntervaloSalida
            // 
            this.lblIntervaloSalida.AutoSize = true;
            this.lblIntervaloSalida.Location = new System.Drawing.Point(19, 71);
            this.lblIntervaloSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervaloSalida.Name = "lblIntervaloSalida";
            this.lblIntervaloSalida.Size = new System.Drawing.Size(122, 16);
            this.lblIntervaloSalida.TabIndex = 32;
            this.lblIntervaloSalida.Text = "Intervalo de Salida:";
            // 
            // txtDestino
            // 
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestino.Location = new System.Drawing.Point(90, 30);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(208, 22);
            this.txtDestino.TabIndex = 1;
            // 
            // FrmBuscarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 844);
            this.Controls.Add(this.lblIntervaloSalida);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdPaquete);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFechaRegreso);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dgvMostrarPaquetes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarPaquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarPaquete";
            this.Load += new System.EventHandler(this.FrmBuscarPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMostrarPaquetes;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblIdPaquete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIntervaloSalida;
        private System.Windows.Forms.TextBox txtDestino;
    }
}